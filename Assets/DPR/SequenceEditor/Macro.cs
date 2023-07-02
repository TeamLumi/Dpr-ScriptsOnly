using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.SequenceEditor
{
    [Serializable]
    public class Macro
    {
        public int CommandNo;
        public string Name;
        public List<MacroValue> Values;
        public Macro()
        {
        }

        public Macro(Macro other)
        {
            this.CommandNo = other.CommandNo;
            this.Name = other.Name;
            this.Values = new List<MacroValue>(other.Values);
        }

        public MacroValue GetValue(string key)
        {
            return Values.Find(value => value.Key == key);
        }

        public string ParseString(MacroValue value, string def)
        {
            return string.IsNullOrEmpty(value.Value) ? def : value.Value;
        }

        public static int ParseInt(string value, int def)
        {
            if (string.IsNullOrEmpty(value))
            {
                return def;
            }

            if (int.TryParse(value, out int result))
            {
                return result;
            }
            else
            {
                return def;
            }
        }

        public static Vector3 ParseVector3(float defaultValue, string str, long index)
        {
            Vector3 result = new Vector3(defaultValue, defaultValue, defaultValue);

            if (!string.IsNullOrEmpty(str))
            {
                if (index < 1)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }

                result.x = float.Parse(str);

                if (index < 2)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }

                result.y = float.Parse(str);

                if (index < 3)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }

                result.z = float.Parse(str);
            }

            return result;
        }

        public static Vector3 ParseVector3(object value, bool defX, bool defY, float defZ)
        {
            return Vector3.zero;
        }

        public float ParseFloat(MacroValue value, float def)
        {
            return string.IsNullOrEmpty(value.Value) ? def : float.Parse(value.Value);
        }

        public bool ParseBool(MacroValue value, int def)
        {
            return string.IsNullOrEmpty(value.Value) ? def == 1 : int.Parse(value.Value) == 1;
        }

        public static bool[] ParseBoolArray(Macro.Value value, bool def)
        {
            if (string.IsNullOrEmpty(value.Item))
            {
                return new bool[] { def, def, def };
            }
            else
            {
                var parts = value.Item.Split(',');
                return new bool[]
                {
                    parts.Length > 0 ? int.Parse(parts[0]) == 1 : def,
                    parts.Length > 1 ? int.Parse(parts[1]) == 1 : def,
                    parts.Length > 2 ? int.Parse(parts[2]) == 1 : def
                };
            }
        }

        public static bool[] ParseBoolArray(Macro.Value value, int def0, int def1, int def2)
        {
            if (string.IsNullOrEmpty(value.Item))
            {
                return new bool[] { def0 == 1, def1 == 1, def2 == 1 };
            }
            else
            {
                var parts = value.Item.Split(',');
                return new bool[]
                {
                    parts.Length > 0 ? int.Parse(parts[0]) == 1 : def0 == 1,
                    parts.Length > 1 ? int.Parse(parts[1]) == 1 : def1 == 1,
                    parts.Length > 2 ? int.Parse(parts[2]) == 1 : def2 == 1
                };
            }
        }

        public GameObject Default;
        public GameObject CamFile;
        public object culture_us;

        [Serializable]
        public sealed class Value
        {
            public string Item => "";
            public string Name;
            public GameObject Values;
        }

        [Serializable]
        public class MacroValue
        {
            public string Key;
            public string Value;
        }

    }
}
