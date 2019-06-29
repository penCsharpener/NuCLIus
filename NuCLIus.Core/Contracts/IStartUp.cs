using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IStartup {
        void SetupAppDataFolder();
        object InitForm();
    }
}
