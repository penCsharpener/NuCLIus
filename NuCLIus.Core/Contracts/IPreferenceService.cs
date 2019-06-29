﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IPreferenceService {
        string AppDataPath { get; }
        IStorageService StorageService { get; }

        Task SetupAppDataFolder();
    }
}