using Autofac;
using NuCLIus.Core.Contracts;
using NuCLIus.WinForms.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuCLIus.WinForms {
    public static class Program {
        public static Mainform Mainform { get; private set; }
        public static IContainer DI { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DI = DIContainer.Config();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var scope = DI.BeginLifetimeScope()) {
                Application.Run((Mainform)scope.Resolve<IStartup>().InitForm());
            }
        }
    }
}
