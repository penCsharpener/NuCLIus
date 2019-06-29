﻿using NuCLIus.Core.Contracts;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NuCLIus.Services {
    public class PreferenceService : IPreferenceService {
        public string AppDataPath { get; }

        public IStorageService StorageService { get; }

        public PreferenceService(IStorageService storage) {
            StorageService = storage;
            AppDataPath = Environment.ExpandEnvironmentVariables("%appdata%\\NuCLIus");
        }

        public async Task SetupAppDataFolder() {
            if (Directory.Exists(AppDataPath) == false) {
                Directory.CreateDirectory(AppDataPath);
            }
            await StorageService.SetupStorageSolution(AppDataPath);
        }
    }
}