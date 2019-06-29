using NuCLIus.Core.Contracts;
using penCsharpener.DotnetUtils;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
