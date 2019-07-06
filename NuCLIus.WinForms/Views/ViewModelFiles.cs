using Autofac;
using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using NuCLIus.Core.Preferences;
using NuCLIus.NugetCLI;
using NuCLIus.NugetCLI.Interfaces;
using penCsharpener.DotnetUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCLIus.WinForms.Views {
    public class ViewModelFiles : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly IRunNuget _runNuget;

        public ViewModelFiles(IPreferenceService preferenceService,
                              IFileService fileService,
                              IRunNuget runNuget) {
            PreferenceService = preferenceService;
            FileService = fileService;
            _runNuget = runNuget;
            BsFiles.DataSource = new List<IFile>();
            PropertyChanged += async (s, e) => {
                Console.WriteLine(e.PropertyName);
                switch (e.PropertyName) {
                    case nameof(TextSearch):
                    case nameof(CheckCsProj):
                    case nameof(CheckVbProj):
                    case nameof(CheckNupkg):
                    case nameof(CheckSln):
                    case nameof(CheckNuspec):
                    case nameof(CheckSnupkg):
                    await UpdateFilesData();
                        break;
                    case nameof(OptionPack):
                    case nameof(OptionRestore):
                    case nameof(OptionList):
                        break;
                    case nameof(OptionDelete):
                    case nameof(OptionAddNupkg):
                        CheckProductionSource = true;
                        break;
                }
            };
            _runNuget.GetCmdStandardOutput += async (s, e) => {
                try {
                    if (e.Contains("Successfully created package")) {
                        var pathLine = e.Split("'".ToArray(), StringSplitOptions.RemoveEmptyEntries).LastOrDefault(x => x.Contains(":\\") && x.Contains(".nupkg"));
                        if (pathLine != null && File.Exists(pathLine)) {
                            var createFileInfo = new FileInfo(pathLine);
                            if (CheckDevSource) {
                                var devSourceCopy = await PreferenceService.GetSetting(Settings.NugetLocalDevNugetServer);
                                if (!string.IsNullOrWhiteSpace(devSourceCopy.ValueString)) {
                                    var devSourceFileInfo = new FileInfo(Path.Combine(devSourceCopy.ValueString, createFileInfo.Name));
                                    File.Copy(createFileInfo.FullName, devSourceFileInfo.FullName, true);
                                }
                            }
                            try {
                                var newNupkg = new Nupkg() {
                                    Path = pathLine,
                                    PathSha1 = pathLine.ToSha1(),
                                    ProjectID = (SelectedFile as Project)?.ID ?? 0,
                                    PackageSha256 = createFileInfo.ToSha256(),
                                }.DetermineNugetInfo();
                                await FileService.WriteFileToStorage(newNupkg);
                            } catch (Exception ex) {
                                MessageBox.Show($"Writing new nuget package to storage failed:\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"ViewModelFiles:\r\n{ex.Message}", "Error: copying to Dev Source", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        public IPreferenceService PreferenceService { get; }
        public IFileService FileService { get; }
        public BindingSource BsFiles { get; set; } = new BindingSource();
        public BindingSource BsMostFrequent { get; set; } = new BindingSource();
        public BindingSource BsNupkgLog { get; set; } = new BindingSource();
        public IFile SelectedFile => BsFiles.Current as IFile;
        public bool IsSolution => SelectedFile is Solution;
        public bool IsProject => SelectedFile is Project;
        public bool IsNupkg => SelectedFile is Nupkg;

        #region Files

        public bool CheckCsProj { get; set; } = true;
        public bool CheckVbProj { get; set; } = true;
        public bool CheckNupkg { get; set; } = true;
        public bool CheckSln { get; set; } = true;
        public bool CheckNuspec { get; set; } = true;
        public bool CheckSnupkg { get; set; } = true;
        public string TextSearch { get; set; }

        public async Task UpdateFilesData(bool updateView = true) {
            IEnumerable<IFile> files = new List<IFile>();
            await await Task.Factory.StartNew( async () => {
                files = await FileService.GetFiles();
                if (!string.IsNullOrWhiteSpace(TextSearch)) {
                    files = files.Where(x => x.Path.Like(TextSearch));
                }
                var selectedFiles = new List<IFile>();
                if (CheckCsProj) {
                    selectedFiles.AddRange(files.Where(x => x.Path.EndsWith(".csproj", StringComparison.OrdinalIgnoreCase)));
                }
                if (CheckVbProj) {
                    selectedFiles.AddRange(files.Where(x => x.Path.EndsWith(".vbproj", StringComparison.OrdinalIgnoreCase)));
                }
                if (CheckNupkg) {
                    selectedFiles.AddRange(files.Where(x => x.Path.EndsWith(".nupkg", StringComparison.OrdinalIgnoreCase)));
                }
                if (CheckSln) {
                    selectedFiles.AddRange(files.Where(x => x.Path.EndsWith(".sln", StringComparison.OrdinalIgnoreCase)));
                }
                if (CheckNuspec) {
                    selectedFiles.AddRange(files.Where(x => x.Path.EndsWith(".nuspec", StringComparison.OrdinalIgnoreCase)));
                }
                if (CheckSnupkg) {
                    selectedFiles.AddRange(files.Where(x => x.Path.EndsWith(".snupkg", StringComparison.OrdinalIgnoreCase)));
                }
                files = selectedFiles.OrderBy(x => x.Path);
            });
            BsFiles.DataSource = files.ToList();
        }

        public async Task RefreshFromFs() {
            await await Task.Factory.StartNew(async () => {
                await FileService.RefreshFromFileSystem();
            });
            await UpdateFilesData(false);
        }

        #endregion

        #region Nupkg

        public bool OptionPack { get; set; }
        public bool OptionRestore { get; set; }
        public bool OptionAddNupkg { get; set; }
        public bool OptionDelete { get; set; }
        public bool OptionList { get; set; }
        public bool CheckProductionSource { get; set; }
        public bool CheckDevSource { get; set; }
        public string CLIOutputLine { get; set; }

        public async Task ExecuteNupkgCmd() {
            try {
                var proj = SelectedFile as Project;
                if (proj == null) {
                    MessageBox.Show($"File is not a .csproj or .vbproj", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var outputPath = (await PreferenceService.GetSetting(Settings.NugetDefaultOutputPath))?.ValueString;
                var workingDir = Path.GetDirectoryName(proj.Path);
                var cmd = "";
                if (OptionPack) {
                    cmd = Nuget.Init().Pack(proj.Path).OutputDirectory(outputPath).Properties().Configuration().Out;
                }
                if (OptionRestore) {

                }
                await _runNuget.RunAsync(cmd, workingDir);
                await UpdateFilesData();
            } catch (Exception ex) {
                MessageBox.Show($"Execute Nupkg Cmd:\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task ExecutePackageCmd() {
            try {
                var nupkg = (SelectedFile as Nupkg)?.DetermineNugetInfo();
                if (nupkg == null) {
                    MessageBox.Show($"File is not a .nupkg", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var nugetSrv = await PreferenceService.GetSetting(Settings.NugetLocalNugetServer);
                if (string.IsNullOrWhiteSpace(nugetSrv.ValueString) || !Directory.Exists(nugetSrv.ValueString)) {
                    MessageBox.Show($"No local nuget server specified in settings", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var cmd = "";
                var workingDir = Path.GetDirectoryName(nupkg.Path);
                if (OptionAddNupkg) {
                    cmd = Nuget.Init().Add(nupkg.Path).Source(nugetSrv.ValueString).Out;
                }
                if (OptionDelete) {
                    cmd = Nuget.Init().Delete(nupkg.PackageName).PackageVersion(nupkg.Version).Source(nugetSrv.ValueString).Out;
                }
                if (OptionList) {

                }
                await _runNuget.RunAsync(cmd, workingDir);
                await UpdateFilesData();
            } catch (Exception ex) {
                MessageBox.Show($"Execute Package Cmd:\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Log

        #endregion
    }
}
