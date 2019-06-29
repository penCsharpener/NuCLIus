using NuCLIus.Core.Contracts;
using NuCLIus.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NuCLIus.WinForms.Config {
    public class Startup : IStartup {

        public string AppDataPath { get; set; }

        public Startup() {
            AppDataPath = Environment.ExpandEnvironmentVariables("%appdata%\\NuCLIus");
        }

        public object InitForm() {
            return new Mainform(this);
        }

        public void SetupAppDataFolder() {
            if (Directory.Exists(AppDataPath) == false) {
                Directory.CreateDirectory(AppDataPath);
            }
        }
    }
}
