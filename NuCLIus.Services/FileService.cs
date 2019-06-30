using NuCLIus.Core.Contracts;
using NuCLIus.Core.Entities;
using penCsharpener.DotnetUtils;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NuCLIus.Services {
    public class FileService : IFileService {
        private readonly IPreferenceService _preference;

        public FileService(IPreferenceService preference) {
            _preference = preference;
        }

        public async Task<List<IFile>> GetFiles() {
            var rootFolders = await _preference.StorageService.GetAll<RootFolder>();
            var ignorePaths = (await _preference.StorageService.GetAll<ScanIgnorePath>()).Select(x => x.Path).ToArray();
            var files = new List<IFile>();
            foreach (var rf in rootFolders.Select(x => new DirectoryInfo(x.Path))) {
                if (rf.Exists) {
                    files.AddRange(ConvertFiles(rf, ignorePaths));
                }
            }
            return files;
        }

        private IEnumerable<IFile> ConvertFiles(DirectoryInfo rootFolder, string[] ignorePaths) {
            var paths = rootFolder.GetFiles("*.nupkg|*.csproj|*.vbproj|*.sln",
                ignorePaths,
                depth: 1).Select(x => x.FullName).ToList();
            foreach (var path in paths) {
                var fi = new FileInfo(path);
                if (path.EndsWith("nupkg")) {
                    yield return new Nupkg() {
                        Path = path,
                        PathSha1 = path.ToSha1(),
                        PackageName = fi.Name,
                        PackageSha256 = fi.ToSha256(),
                    }.DetermineNugetInfo();
                } else if (path.EndsWith("csproj") || path.EndsWith("vbproj")) {
                    yield return new Project() {
                        Path = path,
                        PathSha1 = path.ToSha1(),
                    };
                } else if (path.EndsWith("sln")) {
                    yield return new Solution() {
                        Path = path,
                        PathSha1 = path.ToSha1(),
                    };
                }
            }
        }
    }
}
