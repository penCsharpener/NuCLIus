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

        public DlgPreferences() {
            InitializeComponent();
            Load += DialogLoad;
        }

        private void DialogLoad(object sender, EventArgs e) {
            _toolTips.InitialDelay = 1;
            _toolTips.ReshowDelay = 1;
            _toolTips.SetToolTip(txtNugetpath, Properties.Resources.pref_nuget_exe_path);
        }
    }
}
