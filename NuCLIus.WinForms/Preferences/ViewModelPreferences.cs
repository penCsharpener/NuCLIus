using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using NuCLIus.Core.Preferences;
using penCsharpener.DotnetUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCLIus.WinForms.Preferences {
    public class ViewModelPreferences : INotifyPropertyChanged {
        public IPreferenceService Preference { get; }
        public IStorageService Storage => Preference.StorageService;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelPreferences(IPreferenceService preference) {
            this.Preference = preference;
            BsRootFolders = new BindingSource();
            BsRootFolders.DataSource = new List<RootFolder>();
            BsIgnorePaths = new BindingSource();
            BsIgnorePaths.DataSource = new List<ScanIgnorePath>();
            SqliteDBLocation = Storage.SqliteDatabaseLocation;
            PropertyChanged += async (s, e) => {
                if (e.PropertyName == nameof(FolderPath)) return;
                else if (e.PropertyName == nameof(SqliteDBLocation)) return;
            };
        }

        #region Application Tab

        public BindingSource BsRootFolders { get; set; }
        public BindingSource BsIgnorePaths { get; set; }

        public string FolderPath { get; set; }
        public string IgnorePath { get; set; }

        public async Task AddRootFolder() {
            if (string.IsNullOrWhiteSpace(FolderPath) == false && Directory.Exists(FolderPath)) {
                var rf = new RootFolder() {
                    Path = FolderPath,
                    PathSha1 = FolderPath.ToSha1()
                };
                try {
                    await Storage.SaveEntity(rf);
                    await GetRootFolders();
                } catch (Exception ex) {
                    // TODO: ILogger
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public async Task AddIgnorePath() {
            if (string.IsNullOrWhiteSpace(FolderPath)) {
                var ip = new ScanIgnorePath() {
                    Path = IgnorePath,
                    PathSha1 = IgnorePath.ToSha1(),
                };
                try {
                    await Storage.SaveEntity(ip);
                    await GetIgnorePaths();
                } catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public async Task GetRootFolders() {
            BsRootFolders.DataSource = (await Storage.GetAll<RootFolder>()).ToList();
        }

        public async Task GetIgnorePaths() {
            BsIgnorePaths.DataSource = (await Storage.GetAll<ScanIgnorePath>()).ToList();
        }

        public async Task PopulateSettings() {
            var prefs = await Preference.GetSettings();
            foreach (var pref in prefs) {
                switch ((Settings)pref.ID) {
                    case Settings.StorageMode:
                        break;
                    case Settings.MySQL_ServerURL:
                        MySQL_ServerURL = pref.GetString();
                        break;
                    case Settings.MySQL_Port:
                        MySQL_Port = pref.GetInt();
                        break;
                    case Settings.MySQL_Database:
                        MySQL_Database = pref.GetString();
                        break;
                    case Settings.MySQL_Username:
                        MySQL_Username = pref.GetString();
                        break;
                    case Settings.MySQL_Password:
                        MySQL_Password = pref.GetString();
                        break;
                    case Settings.StorageFileLocation:
                        StorageFileLocation = pref.GetString();
                        break;
                    case Settings.NugetExePath:
                        NugetExePath = pref.GetString();
                        break;
                    case Settings.NugetDefaultOutputPath:
                        NugetDefaultOutputPath = pref.GetString();
                        break;
                    case Settings.NugetLocalNugetServer:
                        NugetLocalNugetServer = pref.GetString();
                        break;
                    case Settings.NugetLocalDevNugetServer:
                        NugetLocalDevNugetServer = pref.GetString();
                        break;
                }
            }
        }

        public async Task SavePreferences() {
            var propInfos = this.GetType().GetProperties();
            var storedPrefs = await Storage.GetAll<Core.Entities.Preference>();
            var common = storedPrefs.Select(x => x.Name).Intersect(propInfos.Select(x => x.Name));
            foreach (var property in storedPrefs.Where(x => common.Contains(x.Name))) {
                var propInfo = propInfos.FirstOrDefault(x => x.Name == property.Name);
                if (property.GetEnumType() == PreferenceTypes.Int) {
                    property.ValueInt = (int)propInfo.GetValue(this);
                } else if (property.GetEnumType() == PreferenceTypes.Int) {
                    property.ValueString = (string)propInfo.GetValue(this);
                }
                await Storage.UpdateEntity(property);
            }
        }

        public async Task Delete<T>(T entity) where T : class {
            if (entity is RootFolder rf) {
                await Storage.DeleteEntity(rf);
                BsRootFolders.DataSource = await Storage.GetAll<RootFolder>();
            } else if (entity is ScanIgnorePath sip) {
                await Preference.StorageService.DeleteEntity(sip);
                BsIgnorePaths.DataSource = await Preference.StorageService.GetAll<ScanIgnorePath>();
            }
        }

        #endregion

        #region Storage Tab

        public string SqliteDBLocation { get; set; }
        public string MySQL_ServerURL { get; set; }
        public int MySQL_Port { get; set; }
        public string MySQL_Database { get; set; }
        public string MySQL_Username { get; set; }
        public string MySQL_Password { get; set; }
        public string StorageFileLocation { get; set; }


        #endregion

        #region Nuget Tab

        public string NugetExePath { get; set; } = @"C:\Windows\System32\nuget.exe";
        public string NugetDefaultOutputPath { get; set; }
        public string NugetLocalNugetServer { get; set; }
        public string NugetLocalDevNugetServer { get; set; }

        #endregion
    }
}
