using System;
using System.Collections.Generic;
using System.Text;

namespace NuCLIus.Core.Entities {
    public class Preference {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string ValueString { get; set; }
        public int ValueInt { get; set; }

        public bool? GetBool() {
            if (((PreferenceTypes)Type) == PreferenceTypes.Bool) {
                return Convert.ToBoolean(ValueInt);
            } else {
                return null;
            }
        }

        public int GetInt() {
            if (((PreferenceTypes)Type) == PreferenceTypes.Int) {
                return ValueInt;
            } else {
                return 0;
            }
        }

        public string GetString() {
            if (((PreferenceTypes)Type) == PreferenceTypes.String) {
                return ValueString;
            } else {
                return null;
            }
        }

        public string GetJson() {
            if (((PreferenceTypes)Type) == PreferenceTypes.Json) {
                return ValueString;
            } else {
                return null;
            }
        }
    }
}
