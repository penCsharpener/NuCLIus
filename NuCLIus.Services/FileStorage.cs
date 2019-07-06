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

        public async Task DeleteFile<T>(T file) where T : class, IFile {
            await _storage.DeleteEntity(file);
        }

        public async Task<List<IFile>> GetFiles() {
            var storedFiles = new List<IFile>();
            storedFiles.AddRange(await _storage.GetAll<Project>());
            storedFiles.AddRange(await _storage.GetAll<Solution>());
            storedFiles.AddRange(await _storage.GetAll<Nupkg>());
            return storedFiles;
        }

        public async Task WriteNewFile(IFile file) {
            if (file is Solution sln) {
                await _storage.SaveEntity(sln);
            } else if (file is Project proj) {
                await _storage.SaveEntity(proj);
            } else if (file is Nupkg nupkg && nupkg.Version != null) {
                await _storage.SaveEntity(nupkg);
            }
        }
    }
}
