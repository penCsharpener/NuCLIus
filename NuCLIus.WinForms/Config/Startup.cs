using NuCLIus.Core.Contracts;
using NuCLIus.WinForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.WinForms.Config {
    public class Startup : IStartup {
        public Startup() {

        }

        public object InitForm() {
            return new Mainform();
        }

        public void SetupAppDataFolder() {
            Console.WriteLine("Test Autofac");
        }
    }
}
