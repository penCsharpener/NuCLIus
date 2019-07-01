using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IFileStorage {
        Task<List<IFile>> GetFiles();
        Task WriteNewFile(IFile file);
    }
}
