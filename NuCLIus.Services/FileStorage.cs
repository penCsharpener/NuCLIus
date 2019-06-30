using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.Services {
    /// <summary>
    /// CRUD operations with storage related to files
    /// </summary>
    public class FileStorage : IFileStorage {
        private readonly IStorageService _storage;

        public FileStorage(IStorageService storage) {
            _storage = storage;
        }

        public async Task<List<IFile>> GetFiles() {
            var storedFiles = new List<IFile>();
            storedFiles.AddRange(await _storage.GetAll<Project>());
            storedFiles.AddRange(await _storage.GetAll<Solution>());
            storedFiles.AddRange(await _storage.GetAll<Nupkg>());
            return storedFiles;
        }
    }
}
