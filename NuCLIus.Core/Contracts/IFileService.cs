using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IFileService {
        Task<List<IFile>> GetFiles();
    }
}
