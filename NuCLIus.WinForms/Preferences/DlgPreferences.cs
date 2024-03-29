﻿using MYaSyncQL.Client.Forms.Controls.Wrappers;
using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using System;
using System.Windows.Forms;

namespace NuCLIus.WinForms.Preferences {
    public partial class DlgPreferences : Form {

        private ToolTip _toolTips = new ToolTip();
        private DGVEnhancer<RootFolder> dgvProjectFolders;
        private DGVEnhancer<ScanIgnorePath> dgvIgnorePaths;
        private ViewModelPreferences vm;

        public DlgPreferences(IPreferenceService preference) {
            InitializeComponent();
            vm = new ViewModelPreferences(preference);
            Load += DialogLoad;
        }

        private async void DialogLoad(object sender, EventArgs e) {
            InitControls();
            await vm.GetIgnorePaths();
            await vm.PopulateSettings();
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
            dgvProjectFolders = new DGVEnhancer<RootFolder>(dataProjectFolders);
            dataProjectFolders.DataSource = vm.BsRootFolders;
            var buttonColumn = new DataGridViewButtonColumn() {
                Text = "✘",
                Name = "RemovePath",
                HeaderText = "Remove",
                Visible = true,
                UseColumnTextForButtonValue = true,
            };
            dgvProjectFolders.SetColumnLayout(new[] {
                new DGVColumnLayout(nameof(RootFolder.Path), "Path", 100, true, false),
                new DGVColumnLayout(buttonColumn, 70, false, false),
            });
            dgvIgnorePaths = new DGVEnhancer<ScanIgnorePath>(dataIgnorePaths);
            dataIgnorePaths.DataSource = vm.BsIgnorePaths;
            var buttonColumn2 = new DataGridViewButtonColumn() {
                Text = "✘",
                Name = "RemovePath",
                HeaderText = "Remove",
                Visible = true,
                UseColumnTextForButtonValue = true,
            };
            dgvIgnorePaths.SetColumnLayout(new[] {
                new DGVColumnLayout(nameof(ScanIgnorePath.Path), "Path", 100, true, false),
                new DGVColumnLayout(buttonColumn2, 70, false, false),
            });

            InitHandlers();
        }

        private void InitHandlers() {
            btnAddRootFolder.Click += async (s, e) => {
                await vm.AddRootFolder();
            };
            btnAddIgnorePath.Click += async (s, e) => {
                await vm.AddIgnorePath();
            };
            dataProjectFolders.CellMouseClick += async (s, e) => {
                if (dataProjectFolders.Columns[e.ColumnIndex].Name == "RemovePath") {
                    if (dataProjectFolders.Rows[e.RowIndex].DataBoundItem is RootFolder proj) {
                        await vm.Delete(proj);
                    }
                }
            };
            dataIgnorePaths.CellMouseClick += async (s, e) => {
                if (dataIgnorePaths.Columns[e.ColumnIndex].Name == "RemovePath") {
                    if (dataIgnorePaths.Rows[e.RowIndex].DataBoundItem is ScanIgnorePath sip) {
                        await vm.Delete(sip);
                    }
                }
            };
            btnSaveSettings.Click += async (s, e) => {
                await vm.SavePreferences();
            };
            InitBindings();
        }

        private void InitBindings() {
            txtRootProjectFolder.DataBindings.Add(nameof(txtRootProjectFolder.Text), vm, nameof(vm.FolderPath), true, DataSourceUpdateMode.OnPropertyChanged);
            txtSqliteDBLocation.DataBindings.Add(nameof(txtSqliteDBLocation.Text), vm, nameof(vm.SqliteDBLocation), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNugetExePath.DataBindings.Add(nameof(txtNugetExePath.Text), vm, nameof(vm.NugetExePath), true, DataSourceUpdateMode.OnPropertyChanged);
            txtDefaultOutputPath.DataBindings.Add(nameof(txtDefaultOutputPath.Text), vm, nameof(vm.NugetDefaultOutputPath), true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocalNugetServer.DataBindings.Add(nameof(txtLocalNugetServer.Text), vm, nameof(vm.NugetLocalNugetServer), true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocalDevNugetServer.DataBindings.Add(nameof(txtLocalDevNugetServer.Text), vm, nameof(vm.NugetLocalDevNugetServer), true, DataSourceUpdateMode.OnPropertyChanged);
            txtServerURL.DataBindings.Add(nameof(txtServerURL.Text), vm, nameof(vm.MySQL_ServerURL), true, DataSourceUpdateMode.OnPropertyChanged);
            numMySqlPort.DataBindings.Add(nameof(numMySqlPort.Value), vm, nameof(vm.MySQL_Port), true, DataSourceUpdateMode.OnPropertyChanged);
            txtUsername.DataBindings.Add(nameof(txtUsername.Text), vm, nameof(vm.MySQL_Username), true, DataSourceUpdateMode.OnPropertyChanged);
            txtDatabase.DataBindings.Add(nameof(txtDatabase.Text), vm, nameof(vm.MySQL_Database), true, DataSourceUpdateMode.OnPropertyChanged);
            txtPassword.DataBindings.Add(nameof(txtPassword.Text), vm, nameof(vm.MySQL_Password), true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
