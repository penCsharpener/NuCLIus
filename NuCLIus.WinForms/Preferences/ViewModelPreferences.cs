using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuCLIus.Core.Contracts;

namespace NuCLIus.WinForms.Preferences {
    public class ViewModelPreferences : INotifyPropertyChanged {
        public IPreferenceService Preference { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelPreferences(IPreferenceService preference) {
            this.Preference = preference;
            SqliteDBLocation = preference.StorageService.SqliteDatabaseLocation;
            PropertyChanged += async (s, e) => {
                if (e.PropertyName == nameof(FolderPath)) return;
                else if (e.PropertyName == nameof(SqliteDBLocation)) return;
            };
        }

        #region Application Tab

        public BindingSource BsRootFolders { get; set; } = new BindingSource();

        public string FolderPath { get; set; }

        public async Task AddRootFolder() {

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
