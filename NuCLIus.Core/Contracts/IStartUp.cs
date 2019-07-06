using NuCLIus.NugetCLI.Interfaces;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IStartup {
        Task SetupAppDataFolder();
        object InitForm();
        IStorageService GetStorageService();
        IPreferenceService GetPreferenceService();
        IFileService GetFileService();
        IRunNuget GetRunNuget();
    }
}
