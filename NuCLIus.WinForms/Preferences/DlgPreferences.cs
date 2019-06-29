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
            _toolTips.InitialDelay = 100;
            _toolTips.ReshowDelay = 100;
            _toolTips.ShowAlways = true;
            _toolTips.IsBalloon = true;
            _toolTips.SetToolTip(txtNugetpath, Properties.Resources.pref_nuget_exe_path);
            _toolTips.SetToolTip(txtDefaultOutputPath, Properties.Resources.pref_nuget_default_output_path);
            _toolTips.SetToolTip(txtLocalNugetServer, Properties.Resources.pref_nuget_local_nuget_server);
            _toolTips.SetToolTip(txtLocalDevNugetServer, Properties.Resources.pref_nuget_local_dev_nuget_server);
        }
    }
}
