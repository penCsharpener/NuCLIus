using NuCLIus.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NuCLIus.Core.Preferences {
    public static class HelperMethods {
        public static string GetStringSetting(this IEnumerable<Preference> prefs, Settings setting) {
            var item = prefs.FirstOrDefault(x => x.Name == setting.ToString());
            return item.ValueString;
        }

        public static int GetIntSetting(this IEnumerable<Preference> prefs, Settings setting) {
            var item = prefs.FirstOrDefault(x => x.Name == setting.ToString());
            return item.ValueInt;
        }

        public static bool GetBoolSetting(this IEnumerable<Preference> prefs, Settings setting) {
            var item = prefs.FirstOrDefault(x => x.Name == setting.ToString());
            return Convert.ToBoolean(item.ValueInt);
        }
    }
}
