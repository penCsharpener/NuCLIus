using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IFileService {
        ConcurrentDictionary<string, IFile> FoundFiles { get; }
        Task<List<IFile>> GetFiles();
        Task RefreshFromFileSystem();
        Task WriteFileToStorage(IFile file);
    }
}
