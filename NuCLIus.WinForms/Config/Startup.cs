using NuCLIus.Core.Contracts;

namespace NuCLIus.WinForms.Config {
    public class Startup : IStartup {
        private readonly IPreferenceService _preference;

        public Startup(IPreferenceService preference) {
            _preference = preference;
        }

        public object InitForm() {
            return new Mainform(this);
        }

        public void SetupAppDataFolder() {
            _preference.CreateAppDataFolder();
        }
    }
}
