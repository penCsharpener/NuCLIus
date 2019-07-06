using NuCLIus.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace NuCLIus.Core.Entities {
    [DebuggerDisplay("GitRepo '{Path}'")]
    public class GitRepo : IPrimary, IFile {
        public int ID { get; set; }
        public string Path { get; set; }
        public string PathSha1 { get; set; }

        public DirectoryInfo GetDirectoryInfo() {
            return Directory.Exists(Path) ? new DirectoryInfo(Path) : null;
        }

        FileInfo IFile.GetFileInfo() {
            return null;
        }
    }
}
