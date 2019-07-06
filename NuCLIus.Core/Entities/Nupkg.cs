using NuCLIus.Core.Contracts;
using penCsharpener.DotnetUtils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace NuCLIus.Core.Entities {
    [DebuggerDisplay("Nupkg '{Path}'")]
    public class Nupkg : IPrimary, IFile {
        public int ID { get; set; }
        public string Path { get; set; }
        public int ProjectID { get; set; }
        public string PathSha1 { get; set; }
        public string PackageSha256 { get; set; }
        public string PackageName { get; set; }
        public string Version { get; set; }

        /// <summary>
        /// populates PackageName and Version properties from the file's name
        /// </summary>
        /// <returns></returns>
        public Nupkg DetermineNugetInfo() {
            var parts = System.IO.Path.GetFileNameWithoutExtension(Path)
                                      .Split(".".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<int, string>();
            for (int i = parts.Length - 1; i >= 0; i--) {
                if (parts[i].IsNumeric()) {
                    dict.Add(i, parts[i]);
                } else {
                    break;
                }
            }

            if (dict.Count <= 4) {
                Version = string.Join(".", dict.Where(x => x.Key >= parts.Length - 4)
                                               .OrderBy(x => x.Key)
                                               .Select(x => x.Value));
            }

            PackageName = System.IO.Path.GetFileNameWithoutExtension(Path)
                                        .Replace($".{Version}", "");

            return this;
        }

        public DirectoryInfo GetDirectoryInfo() {
            return File.Exists(Path) ? new DirectoryInfo(System.IO.Path.GetDirectoryName(Path)) : null;
        }

        public FileInfo GetFileInfo() {
            return File.Exists(Path) ? new FileInfo(Path) : null;
        }
    }
}
