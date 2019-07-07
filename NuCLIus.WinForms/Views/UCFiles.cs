﻿using MYaSyncQL.Client.Forms.Controls.Wrappers;
using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCLIus.WinForms.Views {
    public partial class UCFiles : UserControl {
        private readonly IStartup _startup;
        private ToolTip _toolTips = new ToolTip();
        private ViewModelFiles vm;
        private DGVEnhancer<IFile> dgvFiles;

        public UCFiles(IStartup startup) {
            InitializeComponent();
            _startup = startup;
            vm = new ViewModelFiles(_startup.GetPreferenceService(), _startup.GetFileService(), _startup.GetRunNuget());
            Load += UCFilesLoad;
        }

        private async void UCFilesLoad(object sender, EventArgs e) {
            tabControl1.Controls.Remove(tabPagePackageSource);
            await InitControls();
            await vm.UpdateFilesData();
        }

        private async Task InitControls() {
            dgvFiles = new DGVEnhancer<IFile>(dataFiles);
            dataFiles.DataSource = vm.BsFiles;
            dataFiles.ReadOnly = true;
            dgvFiles.SetColumnLayout(new[] {
                new DGVColumnLayout(nameof(IFile.Path), "Path", 100, true, true),
            });

            InitHandlers();
        }

        private void InitHandlers() {
            lnkFsRefresh.Click += async (s, e) => {
                await vm.RefreshFromFs();
            };
            dataFiles.CellFormatting += (s, e) => {
                if (dataFiles.Rows[e.RowIndex].DataBoundItem is Solution sln) {
                    e.CellStyle.BackColor = Color.LightBlue;
                } else if (dataFiles.Rows[e.RowIndex].DataBoundItem is Project proj) {
                    e.CellStyle.BackColor = Color.LightYellow;
                } else if (dataFiles.Rows[e.RowIndex].DataBoundItem is Nupkg nupkg) {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
            };
            btnExecuteNupkg.Click += async (s, e) => {
                await vm.ExecuteNupkgCmd();
            };
            btnSaveSettings.Click += async (s, e) => {
                await vm.SaveSettings();
            };
            //btnExecutePackageSource.Click += async (s, e) => {
            //    await vm.ExecutePackageCmd();
            //};
            radPack.CheckedChanged += RadNupkgCheckedChanged;
            radRestore.CheckedChanged += RadNupkgCheckedChanged;
            radAddNupkg.CheckedChanged += RadPackagingCheckedChanged;
            radDelete.CheckedChanged += RadPackagingCheckedChanged;
            radList.CheckedChanged += RadPackagingCheckedChanged;
            InitBindings();
        }

        private void RadNupkgCheckedChanged(object sender, EventArgs e) {
            vm.OptionPack = radPack.Checked;
            vm.OptionRestore = radRestore.Checked;
        }

        private void RadPackagingCheckedChanged(object sender, EventArgs e) {
            vm.OptionAddNupkg = radAddNupkg.Checked;
            vm.OptionDelete = radDelete.Checked;
            vm.OptionList = radList.Checked;
        }

        private void InitBindings() {
            txtSearch.DataBindings.Add(nameof(txtSearch.Text), vm, nameof(vm.TextSearch), true, DataSourceUpdateMode.OnPropertyChanged);
            txtCLIOutput.DataBindings.Add(nameof(txtCLIOutput.Text), vm, nameof(vm.CLIOutputLine), true, DataSourceUpdateMode.OnPropertyChanged);
            chkCsProj.DataBindings.Add(nameof(chkCsProj.Checked), vm, nameof(vm.CheckCsProj), true, DataSourceUpdateMode.OnPropertyChanged);
            chkVbProj.DataBindings.Add(nameof(chkVbProj.Checked), vm, nameof(vm.CheckVbProj), true, DataSourceUpdateMode.OnPropertyChanged);
            chkNupkg.DataBindings.Add(nameof(chkNupkg.Checked), vm, nameof(vm.CheckNupkg), true, DataSourceUpdateMode.OnPropertyChanged);
            chkSln.DataBindings.Add(nameof(chkSln.Checked), vm, nameof(vm.CheckSln), true, DataSourceUpdateMode.OnPropertyChanged);
            chkNuspec.DataBindings.Add(nameof(chkNuspec.Checked), vm, nameof(vm.CheckNuspec), true, DataSourceUpdateMode.OnPropertyChanged);
            chkSnupkg.DataBindings.Add(nameof(chkSnupkg.Checked), vm, nameof(vm.CheckSnupkg), true, DataSourceUpdateMode.OnPropertyChanged);
            chkSourceProduction.DataBindings.Add(nameof(chkSourceProduction.Checked), vm, nameof(vm.CheckProductionSource), true, DataSourceUpdateMode.OnPropertyChanged);
            chkSourceDevelopment.DataBindings.Add(nameof(chkSourceDevelopment.Checked), vm, nameof(vm.CheckDevSource), true, DataSourceUpdateMode.OnPropertyChanged);
            groupBoxProjectCmds.DataBindings.Add(nameof(groupBoxProjectCmds.Visible), vm, nameof(vm.IsProject), true, DataSourceUpdateMode.OnPropertyChanged);
            groupBoxNupkgCmds.DataBindings.Add(nameof(groupBoxNupkgCmds.Visible), vm, nameof(vm.IsNupkg), true, DataSourceUpdateMode.OnPropertyChanged);
            groupBoxSettings.DataBindings.Add(nameof(groupBoxSettings.Visible), vm, nameof(vm.SettingsVisible), true, DataSourceUpdateMode.OnPropertyChanged);
            btnExecuteNupkg.DataBindings.Add(nameof(btnExecuteNupkg.Enabled), vm, nameof(vm.ExecuteButtonEnabled), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNugetExePath.DataBindings.Add(nameof(txtNugetExePath.Text), vm, nameof(vm.NugetExePath), true, DataSourceUpdateMode.OnPropertyChanged);
            txtDefOutput.DataBindings.Add(nameof(txtDefOutput.Text), vm, nameof(vm.NugetDefaultOutput), true, DataSourceUpdateMode.OnPropertyChanged);
            txtLocalNugetServer.DataBindings.Add(nameof(txtLocalNugetServer.Text), vm, nameof(vm.NugetLocalServer), true, DataSourceUpdateMode.OnPropertyChanged);
            txtDevNugetServer.DataBindings.Add(nameof(txtDevNugetServer.Text), vm, nameof(vm.NugetLocalDevServer), true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
