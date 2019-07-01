using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using penCsharpener.DotnetUtils;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
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

        public bool SearchAlready { get; set; }

        public async Task<List<IFile>> GetFiles() {
            var fromStorage = await _store.GetFiles();
            foreach (var file in fromStorage) {
                FoundFiles.AddOrUpdate(file.PathSha1, file, (k, v) => v = file);
            }

            if (!SearchAlready) {
                await RefreshFromFileSystem();
                SearchAlready = true;
            }

            return FoundFiles.Values.ToList();
        }

        public async Task UpdateStorage() {
            foreach (var file in FoundFiles.Values) {
                if (file.ID <= 0) {
                    await _store.WriteNewFile(file);
                }
            }
        }

        public async Task RefreshFromFileSystem() {
            var foundFiles = new List<IFile>();
            foundFiles.AddRange(await _search.FindFiles());
            await await Task.Factory.StartNew(async () => {
                foreach (var file in foundFiles) {
                    FoundFiles.AddOrUpdate(file.PathSha1, file, (k, v) => v = file);
                }
                await UpdateStorage();
            });
        }
    }
}
