using Autofac;
using NuCLIus.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.WinForms.Config {
    public static class DIContainer {
        public static IContainer Config() {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(new Startup()).As<IStartup>();
            return builder.Build();
        }
    }
}
