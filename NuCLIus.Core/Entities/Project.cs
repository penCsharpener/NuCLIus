using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Core.Entities {
    public class Project {
        public int ID { get; set; }
        public string Path { get; set; }
        public string PathSha1 { get; set; }
        public int SolutionID { get; set; }
        public int GitRepoID { get; set; }
    }
}
