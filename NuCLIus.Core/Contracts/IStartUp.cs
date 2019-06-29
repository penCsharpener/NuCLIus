using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IStartup {
        Task SetupAppDataFolder();
        object InitForm();
        IStorageService GetStorageService();
        IPreferenceService GetPreferenceService();
    }
}
