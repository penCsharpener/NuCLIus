namespace NuCLIus.WinForms.Views {
    partial class UCFiles {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataRecentNupkg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNupkg = new System.Windows.Forms.TabPage();
            this.groupBoxProjectCmds = new System.Windows.Forms.GroupBox();
            this.radRestore = new System.Windows.Forms.RadioButton();
            this.radPack = new System.Windows.Forms.RadioButton();
            this.btnExecuteNupkg = new System.Windows.Forms.Button();
            this.tabPagePackageSource = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExecutePackageSource = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCLIOutput = new System.Windows.Forms.TextBox();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lnkFsRefresh = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFileTypes = new System.Windows.Forms.GroupBox();
            this.chkNupkg = new System.Windows.Forms.CheckBox();
            this.chkSnupkg = new System.Windows.Forms.CheckBox();
            this.chkVbProj = new System.Windows.Forms.CheckBox();
            this.chkNuspec = new System.Windows.Forms.CheckBox();
            this.chkSln = new System.Windows.Forms.CheckBox();
            this.chkCsProj = new System.Windows.Forms.CheckBox();
            this.dataFiles = new System.Windows.Forms.DataGridView();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGitRepo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetailFullPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataFrequentlyUsed = new System.Windows.Forms.DataGridView();
            this.chkSourceDevelopment = new System.Windows.Forms.CheckBox();
            this.chkSourceProduction = new System.Windows.Forms.CheckBox();
            this.groupBoxNupkgCmds = new System.Windows.Forms.GroupBox();
            this.radList = new System.Windows.Forms.RadioButton();
            this.radDelete = new System.Windows.Forms.RadioButton();
            this.radAddNupkg = new System.Windows.Forms.RadioButton();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNugetExePath = new System.Windows.Forms.TextBox();
            this.txtDefOutput = new System.Windows.Forms.TextBox();
            this.txtLocalNugetServer = new System.Windows.Forms.TextBox();
            this.txtDevNugetServer = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecentNupkg)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageNupkg.SuspendLayout();
            this.groupBoxProjectCmds.SuspendLayout();
            this.tabPagePackageSource.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBoxFileTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiles)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFrequentlyUsed)).BeginInit();
            this.groupBoxNupkgCmds.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.68421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.68421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataFiles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelDetails, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1327, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 5);
            this.panel3.Controls.Add(this.dataRecentNupkg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(634, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 121);
            this.panel3.TabIndex = 5;
            // 
            // dataRecentNupkg
            // 
            this.dataRecentNupkg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecentNupkg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRecentNupkg.Location = new System.Drawing.Point(0, 0);
            this.dataRecentNupkg.Name = "dataRecentNupkg";
            this.dataRecentNupkg.Size = new System.Drawing.Size(690, 121);
            this.dataRecentNupkg.TabIndex = 1;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 5);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(634, 160);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(690, 328);
            this.panel2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNupkg);
            this.tabControl1.Controls.Add(this.tabPagePackageSource);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(72, 27);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(16, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 302);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageNupkg
            // 
            this.tabPageNupkg.AutoScroll = true;
            this.tabPageNupkg.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNupkg.Controls.Add(this.groupBoxSettings);
            this.tabPageNupkg.Controls.Add(this.panel6);
            this.tabPageNupkg.Controls.Add(this.groupBoxNupkgCmds);
            this.tabPageNupkg.Controls.Add(this.groupBoxProjectCmds);
            this.tabPageNupkg.Location = new System.Drawing.Point(4, 31);
            this.tabPageNupkg.Name = "tabPageNupkg";
            this.tabPageNupkg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNupkg.Size = new System.Drawing.Size(682, 267);
            this.tabPageNupkg.TabIndex = 0;
            this.tabPageNupkg.Text = "Nuget CLI";
            // 
            // groupBoxProjectCmds
            // 
            this.groupBoxProjectCmds.Controls.Add(this.radRestore);
            this.groupBoxProjectCmds.Controls.Add(this.radPack);
            this.groupBoxProjectCmds.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxProjectCmds.Location = new System.Drawing.Point(3, 3);
            this.groupBoxProjectCmds.Name = "groupBoxProjectCmds";
            this.groupBoxProjectCmds.Size = new System.Drawing.Size(96, 261);
            this.groupBoxProjectCmds.TabIndex = 2;
            this.groupBoxProjectCmds.TabStop = false;
            this.groupBoxProjectCmds.Text = "with Project";
            // 
            // radRestore
            // 
            this.radRestore.AutoSize = true;
            this.radRestore.Enabled = false;
            this.radRestore.Location = new System.Drawing.Point(6, 47);
            this.radRestore.Name = "radRestore";
            this.radRestore.Size = new System.Drawing.Size(61, 19);
            this.radRestore.TabIndex = 1;
            this.radRestore.TabStop = true;
            this.radRestore.Text = "restore";
            this.radRestore.UseVisualStyleBackColor = true;
            // 
            // radPack
            // 
            this.radPack.AutoSize = true;
            this.radPack.Location = new System.Drawing.Point(6, 22);
            this.radPack.Name = "radPack";
            this.radPack.Size = new System.Drawing.Size(50, 19);
            this.radPack.TabIndex = 1;
            this.radPack.TabStop = true;
            this.radPack.Text = "pack";
            this.radPack.UseVisualStyleBackColor = true;
            // 
            // btnExecuteNupkg
            // 
            this.btnExecuteNupkg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteNupkg.Location = new System.Drawing.Point(87, 222);
            this.btnExecuteNupkg.Name = "btnExecuteNupkg";
            this.btnExecuteNupkg.Size = new System.Drawing.Size(75, 27);
            this.btnExecuteNupkg.TabIndex = 0;
            this.btnExecuteNupkg.Text = "Execute";
            this.btnExecuteNupkg.UseVisualStyleBackColor = true;
            // 
            // tabPagePackageSource
            // 
            this.tabPagePackageSource.AutoScroll = true;
            this.tabPagePackageSource.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePackageSource.Controls.Add(this.groupBox1);
            this.tabPagePackageSource.Controls.Add(this.btnExecutePackageSource);
            this.tabPagePackageSource.Location = new System.Drawing.Point(4, 31);
            this.tabPagePackageSource.Name = "tabPagePackageSource";
            this.tabPagePackageSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePackageSource.Size = new System.Drawing.Size(682, 267);
            this.tabPagePackageSource.TabIndex = 1;
            this.tabPagePackageSource.Text = "package source";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 261);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command";
            // 
            // btnExecutePackageSource
            // 
            this.btnExecutePackageSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutePackageSource.Location = new System.Drawing.Point(601, 234);
            this.btnExecutePackageSource.Name = "btnExecutePackageSource";
            this.btnExecutePackageSource.Size = new System.Drawing.Size(75, 27);
            this.btnExecutePackageSource.TabIndex = 1;
            this.btnExecutePackageSource.Text = "Execute";
            this.btnExecutePackageSource.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCLIOutput);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(690, 26);
            this.panel4.TabIndex = 0;
            // 
            // txtCLIOutput
            // 
            this.txtCLIOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCLIOutput.Location = new System.Drawing.Point(0, 0);
            this.txtCLIOutput.Name = "txtCLIOutput";
            this.txtCLIOutput.Size = new System.Drawing.Size(690, 23);
            this.txtCLIOutput.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.AutoScroll = true;
            this.tableLayoutPanel1.SetColumnSpan(this.panelFilter, 2);
            this.panelFilter.Controls.Add(this.panel5);
            this.panelFilter.Controls.Add(this.groupBoxFileTypes);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(3, 3);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(620, 114);
            this.panelFilter.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lnkFsRefresh);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 107);
            this.panel5.TabIndex = 4;
            // 
            // lnkFsRefresh
            // 
            this.lnkFsRefresh.AutoSize = true;
            this.lnkFsRefresh.Location = new System.Drawing.Point(52, 76);
            this.lnkFsRefresh.Name = "lnkFsRefresh";
            this.lnkFsRefresh.Size = new System.Drawing.Size(134, 15);
            this.lnkFsRefresh.TabIndex = 4;
            this.lnkFsRefresh.TabStop = true;
            this.lnkFsRefresh.Text = "Refresh from file system";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(55, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 23);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // groupBoxFileTypes
            // 
            this.groupBoxFileTypes.Controls.Add(this.chkNupkg);
            this.groupBoxFileTypes.Controls.Add(this.chkSnupkg);
            this.groupBoxFileTypes.Controls.Add(this.chkVbProj);
            this.groupBoxFileTypes.Controls.Add(this.chkNuspec);
            this.groupBoxFileTypes.Controls.Add(this.chkSln);
            this.groupBoxFileTypes.Controls.Add(this.chkCsProj);
            this.groupBoxFileTypes.Location = new System.Drawing.Point(262, 4);
            this.groupBoxFileTypes.Name = "groupBoxFileTypes";
            this.groupBoxFileTypes.Size = new System.Drawing.Size(202, 107);
            this.groupBoxFileTypes.TabIndex = 1;
            this.groupBoxFileTypes.TabStop = false;
            this.groupBoxFileTypes.Text = "File Types";
            // 
            // chkNupkg
            // 
            this.chkNupkg.AutoSize = true;
            this.chkNupkg.Location = new System.Drawing.Point(6, 72);
            this.chkNupkg.Name = "chkNupkg";
            this.chkNupkg.Size = new System.Drawing.Size(63, 19);
            this.chkNupkg.TabIndex = 0;
            this.chkNupkg.Text = ".nupkg";
            this.chkNupkg.UseVisualStyleBackColor = true;
            // 
            // chkSnupkg
            // 
            this.chkSnupkg.AutoSize = true;
            this.chkSnupkg.Location = new System.Drawing.Point(82, 72);
            this.chkSnupkg.Name = "chkSnupkg";
            this.chkSnupkg.Size = new System.Drawing.Size(68, 19);
            this.chkSnupkg.TabIndex = 0;
            this.chkSnupkg.Text = ".snupkg";
            this.chkSnupkg.UseVisualStyleBackColor = true;
            // 
            // chkVbProj
            // 
            this.chkVbProj.AutoSize = true;
            this.chkVbProj.Location = new System.Drawing.Point(6, 47);
            this.chkVbProj.Name = "chkVbProj";
            this.chkVbProj.Size = new System.Drawing.Size(63, 19);
            this.chkVbProj.TabIndex = 0;
            this.chkVbProj.Text = ".vbproj";
            this.chkVbProj.UseVisualStyleBackColor = true;
            // 
            // chkNuspec
            // 
            this.chkNuspec.AutoSize = true;
            this.chkNuspec.Location = new System.Drawing.Point(82, 47);
            this.chkNuspec.Name = "chkNuspec";
            this.chkNuspec.Size = new System.Drawing.Size(67, 19);
            this.chkNuspec.TabIndex = 0;
            this.chkNuspec.Text = ".nuspec";
            this.chkNuspec.UseVisualStyleBackColor = true;
            // 
            // chkSln
            // 
            this.chkSln.AutoSize = true;
            this.chkSln.Location = new System.Drawing.Point(82, 22);
            this.chkSln.Name = "chkSln";
            this.chkSln.Size = new System.Drawing.Size(44, 19);
            this.chkSln.TabIndex = 0;
            this.chkSln.Text = ".sln";
            this.chkSln.UseVisualStyleBackColor = true;
            // 
            // chkCsProj
            // 
            this.chkCsProj.AutoSize = true;
            this.chkCsProj.Location = new System.Drawing.Point(6, 22);
            this.chkCsProj.Name = "chkCsProj";
            this.chkCsProj.Size = new System.Drawing.Size(61, 19);
            this.chkCsProj.TabIndex = 0;
            this.chkCsProj.Text = ".csproj";
            this.chkCsProj.UseVisualStyleBackColor = true;
            // 
            // dataFiles
            // 
            this.dataFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataFiles, 2);
            this.dataFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFiles.Location = new System.Drawing.Point(3, 123);
            this.dataFiles.Name = "dataFiles";
            this.tableLayoutPanel1.SetRowSpan(this.dataFiles, 3);
            this.dataFiles.Size = new System.Drawing.Size(620, 365);
            this.dataFiles.TabIndex = 1;
            // 
            // panelDetails
            // 
            this.panelDetails.AutoScroll = true;
            this.tableLayoutPanel1.SetColumnSpan(this.panelDetails, 2);
            this.panelDetails.Controls.Add(this.dateTimePicker1);
            this.panelDetails.Controls.Add(this.label4);
            this.panelDetails.Controls.Add(this.txtGitRepo);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Controls.Add(this.txtDetailFullPath);
            this.panelDetails.Controls.Add(this.label2);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(3, 494);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(620, 121);
            this.panelDetails.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "last modified:";
            // 
            // txtGitRepo
            // 
            this.txtGitRepo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGitRepo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGitRepo.Location = new System.Drawing.Point(98, 32);
            this.txtGitRepo.Name = "txtGitRepo";
            this.txtGitRepo.ReadOnly = true;
            this.txtGitRepo.Size = new System.Drawing.Size(519, 23);
            this.txtGitRepo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "git repo:";
            // 
            // txtDetailFullPath
            // 
            this.txtDetailFullPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDetailFullPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDetailFullPath.Location = new System.Drawing.Point(98, 3);
            this.txtDetailFullPath.Name = "txtDetailFullPath";
            this.txtDetailFullPath.ReadOnly = true;
            this.txtDetailFullPath.Size = new System.Drawing.Size(519, 23);
            this.txtDetailFullPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "absolute Path:";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.dataFrequentlyUsed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(634, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(690, 151);
            this.panel1.TabIndex = 3;
            // 
            // dataFrequentlyUsed
            // 
            this.dataFrequentlyUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFrequentlyUsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFrequentlyUsed.Location = new System.Drawing.Point(0, 0);
            this.dataFrequentlyUsed.Name = "dataFrequentlyUsed";
            this.dataFrequentlyUsed.Size = new System.Drawing.Size(690, 151);
            this.dataFrequentlyUsed.TabIndex = 0;
            // 
            // chkSourceDevelopment
            // 
            this.chkSourceDevelopment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSourceDevelopment.AutoSize = true;
            this.chkSourceDevelopment.Location = new System.Drawing.Point(24, 194);
            this.chkSourceDevelopment.Name = "chkSourceDevelopment";
            this.chkSourceDevelopment.Size = new System.Drawing.Size(136, 19);
            this.chkSourceDevelopment.TabIndex = 7;
            this.chkSourceDevelopment.Text = "Development Source";
            this.chkSourceDevelopment.UseVisualStyleBackColor = true;
            // 
            // chkSourceProduction
            // 
            this.chkSourceProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSourceProduction.AutoSize = true;
            this.chkSourceProduction.Location = new System.Drawing.Point(24, 169);
            this.chkSourceProduction.Name = "chkSourceProduction";
            this.chkSourceProduction.Size = new System.Drawing.Size(124, 19);
            this.chkSourceProduction.TabIndex = 6;
            this.chkSourceProduction.Text = "Production Source";
            this.chkSourceProduction.UseVisualStyleBackColor = true;
            // 
            // groupBoxNupkgCmds
            // 
            this.groupBoxNupkgCmds.Controls.Add(this.radList);
            this.groupBoxNupkgCmds.Controls.Add(this.radDelete);
            this.groupBoxNupkgCmds.Controls.Add(this.radAddNupkg);
            this.groupBoxNupkgCmds.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxNupkgCmds.Location = new System.Drawing.Point(99, 3);
            this.groupBoxNupkgCmds.Name = "groupBoxNupkgCmds";
            this.groupBoxNupkgCmds.Size = new System.Drawing.Size(106, 261);
            this.groupBoxNupkgCmds.TabIndex = 8;
            this.groupBoxNupkgCmds.TabStop = false;
            this.groupBoxNupkgCmds.Text = "with Package";
            // 
            // radList
            // 
            this.radList.AutoSize = true;
            this.radList.Enabled = false;
            this.radList.Location = new System.Drawing.Point(6, 72);
            this.radList.Name = "radList";
            this.radList.Size = new System.Drawing.Size(40, 19);
            this.radList.TabIndex = 5;
            this.radList.TabStop = true;
            this.radList.Text = "list";
            this.radList.UseVisualStyleBackColor = true;
            // 
            // radDelete
            // 
            this.radDelete.AutoSize = true;
            this.radDelete.Location = new System.Drawing.Point(6, 47);
            this.radDelete.Name = "radDelete";
            this.radDelete.Size = new System.Drawing.Size(57, 19);
            this.radDelete.TabIndex = 6;
            this.radDelete.TabStop = true;
            this.radDelete.Text = "delete";
            this.radDelete.UseVisualStyleBackColor = true;
            // 
            // radAddNupkg
            // 
            this.radAddNupkg.AutoSize = true;
            this.radAddNupkg.Location = new System.Drawing.Point(6, 22);
            this.radAddNupkg.Name = "radAddNupkg";
            this.radAddNupkg.Size = new System.Drawing.Size(45, 19);
            this.radAddNupkg.TabIndex = 7;
            this.radAddNupkg.TabStop = true;
            this.radAddNupkg.Text = "add";
            this.radAddNupkg.UseVisualStyleBackColor = true;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSettings.Location = new System.Drawing.Point(205, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(280, 261);
            this.groupBoxSettings.TabIndex = 9;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "nuget settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtDevNugetServer, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtLocalNugetServer, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDefOutput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNugetExePath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveSettings, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 239);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "nuget .exe";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "default output path:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "local nuget server:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "local dev nuget server:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chkSourceProduction);
            this.panel6.Controls.Add(this.btnExecuteNupkg);
            this.panel6.Controls.Add(this.chkSourceDevelopment);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(485, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 261);
            this.panel6.TabIndex = 10;
            // 
            // txtNugetExePath
            // 
            this.txtNugetExePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNugetExePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNugetExePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNugetExePath.Location = new System.Drawing.Point(153, 3);
            this.txtNugetExePath.Name = "txtNugetExePath";
            this.txtNugetExePath.Size = new System.Drawing.Size(118, 23);
            this.txtNugetExePath.TabIndex = 4;
            // 
            // txtDefOutput
            // 
            this.txtDefOutput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDefOutput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDefOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefOutput.Location = new System.Drawing.Point(153, 30);
            this.txtDefOutput.Name = "txtDefOutput";
            this.txtDefOutput.Size = new System.Drawing.Size(118, 23);
            this.txtDefOutput.TabIndex = 5;
            // 
            // txtLocalNugetServer
            // 
            this.txtLocalNugetServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLocalNugetServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLocalNugetServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocalNugetServer.Location = new System.Drawing.Point(153, 57);
            this.txtLocalNugetServer.Name = "txtLocalNugetServer";
            this.txtLocalNugetServer.Size = new System.Drawing.Size(118, 23);
            this.txtLocalNugetServer.TabIndex = 6;
            // 
            // txtDevNugetServer
            // 
            this.txtDevNugetServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDevNugetServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDevNugetServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDevNugetServer.Location = new System.Drawing.Point(153, 84);
            this.txtDevNugetServer.Name = "txtDevNugetServer";
            this.txtDevNugetServer.Size = new System.Drawing.Size(118, 23);
            this.txtDevNugetServer.TabIndex = 7;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveSettings.Location = new System.Drawing.Point(3, 165);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(144, 21);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            // 
            // UCFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCFiles";
            this.Size = new System.Drawing.Size(1327, 618);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRecentNupkg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageNupkg.ResumeLayout(false);
            this.groupBoxProjectCmds.ResumeLayout(false);
            this.groupBoxProjectCmds.PerformLayout();
            this.tabPagePackageSource.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBoxFileTypes.ResumeLayout(false);
            this.groupBoxFileTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFiles)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFrequentlyUsed)).EndInit();
            this.groupBoxNupkgCmds.ResumeLayout(false);
            this.groupBoxNupkgCmds.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.DataGridView dataFiles;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNupkg;
        private System.Windows.Forms.TabPage tabPagePackageSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCLIOutput;
        private System.Windows.Forms.DataGridView dataFrequentlyUsed;
        private System.Windows.Forms.DataGridView dataRecentNupkg;
        private System.Windows.Forms.CheckBox chkCsProj;
        private System.Windows.Forms.GroupBox groupBoxFileTypes;
        private System.Windows.Forms.CheckBox chkNupkg;
        private System.Windows.Forms.CheckBox chkVbProj;
        private System.Windows.Forms.CheckBox chkSnupkg;
        private System.Windows.Forms.CheckBox chkSln;
        private System.Windows.Forms.CheckBox chkNuspec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGitRepo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetailFullPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExecuteNupkg;
        private System.Windows.Forms.Button btnExecutePackageSource;
        private System.Windows.Forms.GroupBox groupBoxProjectCmds;
        private System.Windows.Forms.RadioButton radPack;
        private System.Windows.Forms.RadioButton radRestore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkFsRefresh;
        private System.Windows.Forms.CheckBox chkSourceDevelopment;
        private System.Windows.Forms.CheckBox chkSourceProduction;
        private System.Windows.Forms.GroupBox groupBoxNupkgCmds;
        private System.Windows.Forms.RadioButton radList;
        private System.Windows.Forms.RadioButton radDelete;
        private System.Windows.Forms.RadioButton radAddNupkg;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtDevNugetServer;
        private System.Windows.Forms.TextBox txtLocalNugetServer;
        private System.Windows.Forms.TextBox txtDefOutput;
        private System.Windows.Forms.TextBox txtNugetExePath;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}
