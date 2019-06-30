using NuCLIus.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Core.Entities {
    public class ScanIgnorePath : IPrimary, IFile {
        public int ID { get; set; }
        public string Path { get; set; }
        public string PathSha1 { get; set; }
    }
}
