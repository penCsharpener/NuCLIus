using NuCLIus.Core.Contracts;
using System.Threading.Tasks;

namespace NuCLIus.WinForms.Config {
    public class Startup : IStartup {
        private readonly IPreferenceService _preference;
        private readonly IFileService _files;
        private IStorageService _storage => _preference.StorageService;

        public Startup(IPreferenceService preference, IFileService files) {
            _preference = preference;
            _files = files;
        }

        public IPreferenceService GetPreferenceService() {
            return _preference;
        }

        public IStorageService GetStorageService() {
            return _storage;
        }

        public IFileService GetFileService() {
            return _files;
        }

        public object InitForm() {
            return new Mainform(this);
        }

        public async Task SetupAppDataFolder() {
            await _preference.SetupAppDataFolder();
        }
    }
}
