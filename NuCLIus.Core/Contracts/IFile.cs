using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Core.Contracts {
    public interface IFile {
        string Path { get; set; }
        string PathSha1 { get; set; }
    }
}
