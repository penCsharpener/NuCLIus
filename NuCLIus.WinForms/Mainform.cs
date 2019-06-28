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
        public Mainform() {
            InitializeComponent();
            Load += MainformLoad;
        }

        private void MainformLoad(object sender, EventArgs e) {
            PreferencesToolStripMenuItem_Click(null, null);
        }

        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e) {
            var dlg = new DlgPreferences();
            dlg.ShowDialog();
        }
    }
}
