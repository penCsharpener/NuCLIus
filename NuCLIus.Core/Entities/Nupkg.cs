using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Core.Entities {
    public class Nupkg {
        public int ID { get; set; }
        public string Path { get; set; }
        public int ProjectID { get; set; }
        public string PathSha1 { get; set; }
        public string PackageSha256 { get; set; }
        public string PackageName { get; set; }
        public string Version { get; set; }
    }
}
