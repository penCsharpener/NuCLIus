using NuCLIus.Core.Contracts;
using System.Threading.Tasks;

namespace NuCLIus.WinForms.Config {
    public class Startup : IStartup {
        private readonly IPreferenceService _preference;

        public Startup(IPreferenceService preference) {
            _preference = preference;
        }

        public IPreferenceService GetPreferenceService() {
            return _preference;
        }

        public IStorageService GetStorageService() {
            return _preference.StorageService;
        }

        public object InitForm() {
            return new Mainform(this);
        }

        public async Task SetupAppDataFolder() {
            await _preference.SetupAppDataFolder();
        }
    }
}
