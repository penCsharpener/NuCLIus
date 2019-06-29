using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using penCsharpener.DotnetUtils;

namespace NuCLIus.WinForms.Preferences {
    public class ViewModelPreferences : INotifyPropertyChanged {
        public IPreferenceService Preference { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelPreferences(IPreferenceService preference) {
            this.Preference = preference;
            BsRootFolders = new BindingSource();
            BsRootFolders.DataSource = new List<RootFolder>();
            SqliteDBLocation = preference.StorageService.SqliteDatabaseLocation;
            PropertyChanged += async (s, e) => {
                if (e.PropertyName == nameof(FolderPath)) return;
                else if (e.PropertyName == nameof(SqliteDBLocation)) return;
            };
        }

        #region Application Tab

        public BindingSource BsRootFolders { get; set; }

        public string FolderPath { get; set; }

        public async Task AddRootFolder() {
            if (string.IsNullOrWhiteSpace(FolderPath) == false && Directory.Exists(FolderPath)) {
                var rf = new RootFolder() {
                    Path = FolderPath,
                    PathSha1 = FolderPath.ToSha1()
                };
                try {
                    await Preference.StorageService.SaveRootFolder(rf);
                    await GetRootFolders();
                } catch (Exception ex) {
                    // TODO: ILogger
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public async Task GetRootFolders() {
            BsRootFolders.DataSource = (await Preference.StorageService.GetRootFolders()).ToList();
        }

        public async Task SeedPreferences() {
            FolderPath = Environment.ExpandEnvironmentVariables(@"%userprofile%\Source\Repos");
            await AddRootFolder();
            FolderPath = null;
        }

        #endregion

        #region Storage Tab

        public string SqliteDBLocation { get; set; }

        #endregion

        #region Nuget Tab

        public string NugetExePath { get; set; } = @"C:\Windows\System32\nuget.exe";
        public string DefaultOutputPath { get; set; }
        public string LocalNugetServer { get; set; }
        public string LocalDevNugetServer { get; set; }

        #endregion
    }
}
