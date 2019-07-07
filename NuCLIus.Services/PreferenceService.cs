﻿using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using NuCLIus.Core.Preferences;
using SqlKata;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public async Task<IEnumerable<Preference>> GetSettings() {
            return await StorageService.GetAll<Preference>();
        }

        public async Task<Preference> GetSetting(Settings setting) {
            var q = new Query("Preferences").Where("Name", setting.ToString());
            var items = await StorageService.Select<Preference>(q);
            return items.FirstOrDefault();
        }

        public async Task SaveSetting(Settings setting, string value) {
            var pref = await GetSetting(setting);
            pref.ValueString = value;
            await StorageService.UpdateEntity(pref);
        }

        public async Task SaveSetting(Settings setting, int value) {
            var pref = await GetSetting(setting);
            pref.ValueInt = value;
            await StorageService.UpdateEntity(pref);
        }

        public async Task SaveSetting(Settings setting, bool value) {
            var pref = await GetSetting(setting);
            pref.ValueInt = Convert.ToInt32(value);
            await StorageService.UpdateEntity(pref);
        }
    }
}
