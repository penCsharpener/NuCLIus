using NuCLIus.Core.Entities;
using NuCLIus.Core.Preferences;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IPreferenceService {
        string AppDataPath { get; }
        IStorageService StorageService { get; }

        Task SetupAppDataFolder();
        Task<IEnumerable<Preference>> GetSettings();
        Task<Preference> GetSetting(Settings setting);
        Task SaveSetting(Settings setting, string value);
        Task SaveSetting(Settings setting, int value);
        Task SaveSetting(Settings setting, bool value);
    }
}
