using NuCLIus.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IPreferenceService {
        string AppDataPath { get; }
        IStorageService StorageService { get; }

        Task SetupAppDataFolder();
        Task<IEnumerable<Preference>> GetSettings();
    }
}
