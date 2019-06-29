﻿using NuCLIus.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IStorageService {
        string SqliteDatabaseLocation { get; }

        Task SetupStorageSolution(string filePath);

        Task<IEnumerable<RootFolder>> GetRootFolders();
        Task SaveRootFolder(RootFolder folder);
    }
}