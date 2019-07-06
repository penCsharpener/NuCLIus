using NuCLIus.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace NuCLIus.Core.Entities {
    [DebuggerDisplay("Solution '{Path}'")]
    public class Solution : IPrimary, IFile {
        public int ID { get; set; }
        public string Path { get; set; }
        public string PathSha1 { get; set; }

        public DirectoryInfo GetDirectoryInfo() {
            return File.Exists(Path) ? new DirectoryInfo(System.IO.Path.GetDirectoryName(Path)) : null;
        }

        public FileInfo GetFileInfo() {
            return File.Exists(Path) ? new FileInfo(Path) : null;
        }
    }
}
