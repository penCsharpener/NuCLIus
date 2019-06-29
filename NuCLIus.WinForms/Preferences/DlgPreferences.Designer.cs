﻿namespace NuCLIus.WinForms.Preferences {
    partial class DlgPreferences {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageApplication = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRootProjectFolder = new System.Windows.Forms.TextBox();
            this.dataProjectFolders = new System.Windows.Forms.DataGridView();
            this.tabPageStorage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numMySqlPort = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageNuget = new System.Windows.Forms.TabPage();
            this.btnGetDefaultOutputPath = new System.Windows.Forms.Button();
            this.btnGetNugetPath = new System.Windows.Forms.Button();
            this.txtLocalDevNugetServer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLocalNugetServer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDefaultOutputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNugetpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetProjectPath = new System.Windows.Forms.Button();
            this.btnAddNuget = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProjectFolders)).BeginInit();
            this.tabPageStorage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMySqlPort)).BeginInit();
            this.tabPageNuget.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageApplication);
            this.tabControl1.Controls.Add(this.tabPageStorage);
            this.tabControl1.Controls.Add(this.tabPageNuget);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(128, 32);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 519);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageApplication
            // 
            this.tabPageApplication.Controls.Add(this.btnAddNuget);
            this.tabPageApplication.Controls.Add(this.btnGetProjectPath);
            this.tabPageApplication.Controls.Add(this.label14);
            this.tabPageApplication.Controls.Add(this.label13);
            this.tabPageApplication.Controls.Add(this.txtRootProjectFolder);
            this.tabPageApplication.Controls.Add(this.dataProjectFolders);
            this.tabPageApplication.Location = new System.Drawing.Point(4, 36);
            this.tabPageApplication.Name = "tabPageApplication";
            this.tabPageApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplication.Size = new System.Drawing.Size(925, 479);
            this.tabPageApplication.TabIndex = 0;
            this.tabPageApplication.Text = "Application";
            this.tabPageApplication.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "Project folders:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Folder path:";
            // 
            // txtRootProjectFolder
            // 
            this.txtRootProjectFolder.Location = new System.Drawing.Point(96, 56);
            this.txtRootProjectFolder.Name = "txtRootProjectFolder";
            this.txtRootProjectFolder.Size = new System.Drawing.Size(420, 23);
            this.txtRootProjectFolder.TabIndex = 1;
            // 
            // dataProjectFolders
            // 
            this.dataProjectFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProjectFolders.Location = new System.Drawing.Point(23, 85);
            this.dataProjectFolders.Name = "dataProjectFolders";
            this.dataProjectFolders.Size = new System.Drawing.Size(578, 211);
            this.dataProjectFolders.TabIndex = 0;
            // 
            // tabPageStorage
            // 
            this.tabPageStorage.Controls.Add(this.tableLayoutPanel1);
            this.tabPageStorage.Location = new System.Drawing.Point(4, 36);
            this.tabPageStorage.Name = "tabPageStorage";
            this.tabPageStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStorage.Size = new System.Drawing.Size(925, 479);
            this.tabPageStorage.TabIndex = 1;
            this.tabPageStorage.Text = "Storage";
            this.tabPageStorage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 473);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Storage Method";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SQLite";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(6, 84);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 19);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "File";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(6, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "MySql / MariaDB";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numMySqlPort);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(713, 467);
            this.panel1.TabIndex = 3;
            // 
            // numMySqlPort
            // 
            this.numMySqlPort.Location = new System.Drawing.Point(127, 182);
            this.numMySqlPort.Maximum = new decimal(new int[] {
            65355,
            0,
            0,
            0});
            this.numMySqlPort.Name = "numMySqlPort";
            this.numMySqlPort.Size = new System.Drawing.Size(112, 23);
            this.numMySqlPort.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 269);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(406, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Password:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(127, 240);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(406, 23);
            this.textBox5.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Username:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(406, 23);
            this.textBox4.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Database:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Port:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Server URL:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(127, 363);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(406, 23);
            this.textBox6.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Folder Location:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(406, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Database Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "MySql / MariaDB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "SQLite";
            // 
            // tabPageNuget
            // 
            this.tabPageNuget.Controls.Add(this.btnGetDefaultOutputPath);
            this.tabPageNuget.Controls.Add(this.btnGetNugetPath);
            this.tabPageNuget.Controls.Add(this.txtLocalDevNugetServer);
            this.tabPageNuget.Controls.Add(this.label16);
            this.tabPageNuget.Controls.Add(this.txtLocalNugetServer);
            this.tabPageNuget.Controls.Add(this.label15);
            this.tabPageNuget.Controls.Add(this.txtDefaultOutputPath);
            this.tabPageNuget.Controls.Add(this.label2);
            this.tabPageNuget.Controls.Add(this.txtNugetpath);
            this.tabPageNuget.Controls.Add(this.label1);
            this.tabPageNuget.Location = new System.Drawing.Point(4, 36);
            this.tabPageNuget.Name = "tabPageNuget";
            this.tabPageNuget.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNuget.Size = new System.Drawing.Size(925, 479);
            this.tabPageNuget.TabIndex = 2;
            this.tabPageNuget.Text = "Nuget";
            this.tabPageNuget.UseVisualStyleBackColor = true;
            // 
            // btnGetDefaultOutputPath
            // 
            this.btnGetDefaultOutputPath.Location = new System.Drawing.Point(455, 48);
            this.btnGetDefaultOutputPath.Name = "btnGetDefaultOutputPath";
            this.btnGetDefaultOutputPath.Size = new System.Drawing.Size(28, 23);
            this.btnGetDefaultOutputPath.TabIndex = 2;
            this.btnGetDefaultOutputPath.Text = "...";
            this.btnGetDefaultOutputPath.UseVisualStyleBackColor = true;
            // 
            // btnGetNugetPath
            // 
            this.btnGetNugetPath.Location = new System.Drawing.Point(455, 19);
            this.btnGetNugetPath.Name = "btnGetNugetPath";
            this.btnGetNugetPath.Size = new System.Drawing.Size(28, 23);
            this.btnGetNugetPath.TabIndex = 2;
            this.btnGetNugetPath.Text = "...";
            this.btnGetNugetPath.UseVisualStyleBackColor = true;
            // 
            // txtLocalDevNugetServer
            // 
            this.txtLocalDevNugetServer.Location = new System.Drawing.Point(135, 129);
            this.txtLocalDevNugetServer.Name = "txtLocalDevNugetServer";
            this.txtLocalDevNugetServer.Size = new System.Drawing.Size(314, 23);
            this.txtLocalDevNugetServer.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "local dev nuget server:";
            // 
            // txtLocalNugetServer
            // 
            this.txtLocalNugetServer.Location = new System.Drawing.Point(135, 100);
            this.txtLocalNugetServer.Name = "txtLocalNugetServer";
            this.txtLocalNugetServer.Size = new System.Drawing.Size(314, 23);
            this.txtLocalNugetServer.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "local nuget server:";
            // 
            // txtDefaultOutputPath
            // 
            this.txtDefaultOutputPath.Location = new System.Drawing.Point(135, 49);
            this.txtDefaultOutputPath.Name = "txtDefaultOutputPath";
            this.txtDefaultOutputPath.Size = new System.Drawing.Size(314, 23);
            this.txtDefaultOutputPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "default output path:";
            // 
            // txtNugetpath
            // 
            this.txtNugetpath.Location = new System.Drawing.Point(135, 20);
            this.txtNugetpath.Name = "txtNugetpath";
            this.txtNugetpath.Size = new System.Drawing.Size(314, 23);
            this.txtNugetpath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "nuget.exe path:";
            // 
            // btnGetProjectPath
            // 
            this.btnGetProjectPath.Location = new System.Drawing.Point(522, 56);
            this.btnGetProjectPath.Name = "btnGetProjectPath";
            this.btnGetProjectPath.Size = new System.Drawing.Size(28, 23);
            this.btnGetProjectPath.TabIndex = 4;
            this.btnGetProjectPath.Text = "...";
            this.btnGetProjectPath.UseVisualStyleBackColor = true;
            // 
            // btnAddNuget
            // 
            this.btnAddNuget.Location = new System.Drawing.Point(556, 56);
            this.btnAddNuget.Name = "btnAddNuget";
            this.btnAddNuget.Size = new System.Drawing.Size(45, 23);
            this.btnAddNuget.TabIndex = 4;
            this.btnAddNuget.Text = "Add";
            this.btnAddNuget.UseVisualStyleBackColor = true;
            // 
            // DlgPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DlgPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DlgPreferences";
            this.tabControl1.ResumeLayout(false);
            this.tabPageApplication.ResumeLayout(false);
            this.tabPageApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProjectFolders)).EndInit();
            this.tabPageStorage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMySqlPort)).EndInit();
            this.tabPageNuget.ResumeLayout(false);
            this.tabPageNuget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageApplication;
        private System.Windows.Forms.TabPage tabPageStorage;
        private System.Windows.Forms.TabPage tabPageNuget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetNugetPath;
        private System.Windows.Forms.TextBox txtNugetpath;
        private System.Windows.Forms.Button btnGetDefaultOutputPath;
        private System.Windows.Forms.TextBox txtDefaultOutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMySqlPort;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRootProjectFolder;
        private System.Windows.Forms.DataGridView dataProjectFolders;
        private System.Windows.Forms.TextBox txtLocalNugetServer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLocalDevNugetServer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddNuget;
        private System.Windows.Forms.Button btnGetProjectPath;
    }
}