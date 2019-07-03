using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using penCsharpener.DotnetUtils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCLIus.WinForms.Views {
    public class ViewModelFiles : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelFiles(IPreferenceService preferenceService,
                              IFileService fileService) {
            PreferenceService = preferenceService;
            FileService = fileService;
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
                        break;
                    case nameof(OptionRestore):
                        break;
                    case nameof(OptionAddNupkg):
                        break;
                    case nameof(OptionDelete):
                        break;
                    case nameof(OptionList):
                        break;
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
        public bool ProductionSource { get; set; }
        public bool DevSource { get; set; }
        public string CLIOutputLine { get; set; }

        public async Task ExecuteNupkgCmd() {

        }

        public async Task ExecutePackageCmd() {

        }

        #endregion

        #region Log

        #endregion
    }
}
