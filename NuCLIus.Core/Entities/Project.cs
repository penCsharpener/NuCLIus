using NuCLIus.Core.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NuCLIus.Core.Entities {
    public class Project : IPrimary, IFile {
        public int ID { get; set; }
        public string Path { get; set; }
        public string PathSha1 { get; set; }
        public int SolutionID { get; set; }
        public int GitRepoID { get; set; }

        private string _gitRepoPath;
        public string FindGitRepo() {
            FindGitRepoRecursively(System.IO.Path.GetDirectoryName(Path), 4);
            return _gitRepoPath;
        }

        private void FindGitRepoRecursively(string path, int iteration) {
            if (iteration == 0) {
                return;
            }
            var dirInfo = new DirectoryInfo(path);
            var potentialGitPath = System.IO.Path.Combine(dirInfo.FullName, ".git");
            if (Directory.Exists(potentialGitPath)) {
                _gitRepoPath = potentialGitPath;
                return;
            } else {
                FindGitRepoRecursively(dirInfo.Parent.FullName, --iteration);
            }
        }
    }
}
