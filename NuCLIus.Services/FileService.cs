using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuCLIus.Services {
    /// <summary>
    /// Service to search relevant files in root folders, 
    /// save and load those from storage, 
    /// periodically rescan drive for file changes,
    /// update storage with changes.
    /// </summary>
    public class FileService : IFileService {
        private readonly IFileStorage _store;
        private readonly IFileSearch _search;
        public ConcurrentDictionary<string, IFile> FoundFiles { get; private set; }

        public FileService(IFileSearch searcher, IFileStorage merger) {
            FoundFiles = new ConcurrentDictionary<string, IFile>();
            _store = merger;
            _search = searcher;
        }

        public bool SearchedAlready { get; set; }

        public async Task<List<IFile>> GetFiles() {
            var fromStorage = await _store.GetFiles();
            foreach (var file in fromStorage) {
                FoundFiles.AddOrUpdate(file.PathSha1, file, (k, v) => v = file);
            }
            foreach (var dictItem in FoundFiles.Values) {
                if (!fromStorage.Any(x => x.PathSha1 == dictItem.PathSha1)) {
                    FoundFiles.TryRemove(dictItem.PathSha1, out var deletedItem);
                }
            }

            if (!SearchedAlready) {
                await RefreshFromFileSystem();
                SearchedAlready = true;
            }

            return FoundFiles.Values.ToList();
        }

        public async Task UpdateStorage() {
            foreach (var file in FoundFiles.Values) {
                if (file.ID <= 0) {
                    try {
                        await _store.WriteNewFile(file);
                    } catch (Exception ex) {
                        Console.WriteLine($"{ex}");
                    }
                }
            }
        }

        public async Task RefreshFromFileSystem() {
            var foundFiles = new List<IFile>();
            foundFiles.AddRange(await _search.FindFiles());
            await await Task.Factory.StartNew(async () => {
                foreach (var file in foundFiles.Where(x => !FoundFiles.Keys.Contains(x.PathSha1))) {
                    FoundFiles.AddOrUpdate(file.PathSha1, file, (k, v) => v = file);
                }
                await UpdateStorage();
                foreach (var file in FoundFiles.Values.Where(x => x.GetFileInfo() == null)) {
                    if (file is Nupkg nu) await _store.DeleteFile(nu);
                    else if (file is Project pj) await _store.DeleteFile(pj);
                    else if (file is Solution sol) await _store.DeleteFile(sol);
                }
            });
        }

        public async Task WriteFileToStorage(IFile file) {
            await _store.WriteNewFile(file);
        }
    }
}
