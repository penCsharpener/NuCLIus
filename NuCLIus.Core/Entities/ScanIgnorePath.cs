using NuCLIus.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace NuCLIus.Core.Entities {
    [DebuggerDisplay("ScanIgnorePath '{Path}'")]
    public class ScanIgnorePath : IPrimary, IFile {
        public int ID { get; set; }
        public string Path { get; set; }
        public string PathSha1 { get; set; }

        DirectoryInfo IFile.GetDirectoryInfo() {
            throw new NotImplementedException();
        }

        FileInfo IFile.GetFileInfo() {
            throw new NotImplementedException();
        }
    }
}
