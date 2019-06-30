using Autofac;
using NuCLIus.Core.Contracts;
using NuCLIus.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.WinForms.Config {
    public static class DIContainer {
        public static IContainer Config() {
            var builder = new ContainerBuilder();
            builder.RegisterType<Startup>().As<IStartup>().SingleInstance();
            builder.RegisterType<PreferenceService>().As<IPreferenceService>().SingleInstance();
            builder.RegisterType<SqliteStorageService>().As<IStorageService>().SingleInstance();
            builder.RegisterType<FileService>().As<IFileService>().SingleInstance();
            return builder.Build();
        }
    }
}
