﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using NuCLIus.Core.Contracts;
using MYaSyncQL.Client.Forms.Controls.Wrappers;
using NuCLIus.Core.Entities;

namespace NuCLIus.WinForms.Views {
    public partial class UCFiles : UserControl {
        private readonly IStartup _startup;
        private ToolTip _toolTips = new ToolTip();
        private ViewModelFiles vm;
        private DGVEnhancer<IFile> dgvFiles;

        public UCFiles(IStartup startup) {
            InitializeComponent();
            _startup = startup;
            vm = new ViewModelFiles(_startup.GetPreferenceService(), _startup.GetFileService());
            Load += UCFilesLoad;
        }

        private async void UCFilesLoad(object sender, EventArgs e) {
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
            InitBindings();
        }

        private void InitBindings() {
            txtSearch.DataBindings.Add(nameof(txtSearch.Text), vm, nameof(vm.TextSearch), true, DataSourceUpdateMode.OnPropertyChanged);

        }
    }
}
