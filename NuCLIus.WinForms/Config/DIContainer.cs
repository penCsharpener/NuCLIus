using Autofac;
using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using NuCLIus.Services;

namespace NuCLIus.WinForms.Config {
    public static class DIContainer {
        public static IContainer Config() {
            var builder = new ContainerBuilder();
            builder.RegisterType<Startup>().As<IStartup>().SingleInstance();
            builder.RegisterType<PreferenceService>().As<IPreferenceService>().SingleInstance();
            builder.RegisterType<SqliteStorageService>().As<IStorageService>().SingleInstance();
            builder.RegisterType<FileService>().As<IFileService>().SingleInstance();
            builder.RegisterType<FileSearch>().As<IFileSearch>().SingleInstance();
            builder.RegisterType<FileStorage>().As<IFileStorage>().SingleInstance();
            return builder.Build();
        }
    }
}
