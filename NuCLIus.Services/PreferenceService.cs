using NuCLIus.Core.Contracts;
using System;
using System.IO;

namespace NuCLIus.Services {
    public class PreferenceService : IPreferenceService {
        public string AppDataPath { get; set; }

        public PreferenceService() {
            AppDataPath = Environment.ExpandEnvironmentVariables("%appdata%\\NuCLIus");
        }

        public void CreateAppDataFolder() {
            if (Directory.Exists(AppDataPath) == false) {
                Directory.CreateDirectory(AppDataPath);
            }
        }
    }
}
