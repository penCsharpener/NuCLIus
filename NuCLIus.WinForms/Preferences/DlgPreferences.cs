using NuCLIus.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCLIus.WinForms.Preferences {
    public partial class DlgPreferences : Form {

        private ToolTip _toolTips = new ToolTip();
        private ViewModelPreferences vm;

        public DlgPreferences(IPreferenceService preference) {
            InitializeComponent();
            vm = new ViewModelPreferences(preference);
            Load += DialogLoad;
        }

        private void DialogLoad(object sender, EventArgs e) {
            InitControls();
        }

        private void InitControls() {
            _toolTips.InitialDelay = 100;
            _toolTips.ReshowDelay = 100;
            _toolTips.ShowAlways = true;
            _toolTips.IsBalloon = true;
            _toolTips.SetToolTip(txtNugetExePath, Properties.Resources.pref_nuget_exe_path);
            _toolTips.SetToolTip(txtDefaultOutputPath, Properties.Resources.pref_nuget_default_output_path);
            _toolTips.SetToolTip(txtLocalNugetServer, Properties.Resources.pref_nuget_local_nuget_server);
            _toolTips.SetToolTip(txtLocalDevNugetServer, Properties.Resources.pref_nuget_local_dev_nuget_server);
            _toolTips.SetToolTip(txtRootProjectFolder, Properties.Resources.pref_nuget_root_folder_path);

            InitHandlers();
        }

        private void InitHandlers() {
            btnAddRootFolder.Click += async (s, e) => {
                await vm.AddRootFolder();
            };
            InitBindings();
        }

        private void InitBindings() {
            txtRootProjectFolder.DataBindings.Add(nameof(txtRootProjectFolder.Text), vm, nameof(vm.FolderPath), true, DataSourceUpdateMode.OnPropertyChanged);
            txtSqliteDBLocation.DataBindings.Add(nameof(txtSqliteDBLocation.Text), vm, nameof(vm.SqliteDBLocation), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNugetExePath.DataBindings.Add(nameof(txtNugetExePath.Text), vm, nameof(vm.NugetExePath), true, DataSourceUpdateMode.OnPropertyChanged);
            txtDefaultOutputPath.DataBindings.Add(nameof(txtDefaultOutputPath.Text), vm, nameof(vm.DefaultOutputPath), true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocalNugetServer.DataBindings.Add(nameof(txtLocalNugetServer.Text), vm, nameof(vm.LocalNugetServer), true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocalDevNugetServer.DataBindings.Add(nameof(txtLocalDevNugetServer.Text), vm, nameof(vm.LocalDevNugetServer), true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
