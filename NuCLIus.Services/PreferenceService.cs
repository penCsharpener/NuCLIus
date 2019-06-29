using NuCLIus.Core.Contracts;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NuCLIus.Services {
    public class PreferenceService : IPreferenceService {
        public string AppDataPath { get; }

        private readonly IStorageService _storage;

        public PreferenceService(IStorageService storage) {
            _storage = storage;
            AppDataPath = Environment.ExpandEnvironmentVariables("%appdata%\\NuCLIus");
        }

        public async Task SetupAppDataFolder() {
            if (Directory.Exists(AppDataPath) == false) {
                Directory.CreateDirectory(AppDataPath);
            }
            await _storage.SetupStorageSolution(AppDataPath);
        }
    }
}
