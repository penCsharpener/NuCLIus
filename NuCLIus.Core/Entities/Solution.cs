using NuCLIus.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NuCLIus.Core.Entities {
    [DebuggerDisplay("Solution '{Path}'")]
    public class Solution : IPrimary, IFile {
        public int ID { get; set; }
        public string Path { get; set; }
        public string PathSha1 { get; set; }
    }
}
