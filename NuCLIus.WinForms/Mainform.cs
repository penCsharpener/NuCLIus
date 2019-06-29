using NuCLIus.Core.Contracts;
using NuCLIus.WinForms.Preferences;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCLIus.WinForms {
    public partial class Mainform : Form {
        private readonly IStartup _startup;

        public Mainform(IStartup startup) {
            InitializeComponent();
            Load += MainformLoad;
            _startup = startup;
        }

        private void MainformLoad(object sender, EventArgs e) {
            _startup.SetupAppDataFolder();
            PreferencesToolStripMenuItem_Click(null, null);
        }

        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e) {
            new DlgPreferences().Show();
        }
    }
}
