using System;
using System.Configuration;

namespace KD.CSGO.Logic.Configs
{
    /// <summary>
    /// Contains all settings connected with CS:GO Process.
    /// For more detailed information about each variable / property, see App.config file.
    /// </summary>
    public static class Settings
    {
        public static string ProcessName => GetValueFromConfig("ProcessName");
        public static string ClientModule => GetValueFromConfig("ClientModule");
        public static int DelayBeforeModuleCheck => ParseConfigValue("DelayBeforeModuleCheck");

        /// <summary>
        /// Returns value from Configuration file.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValueFromConfig(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            return value;
        }

        /// <summary>
        /// Parses specified <see cref="string"/> to <see cref="int"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Parse(string value)
        {
            if (value.StartsWith("0x")) // Offsets, Signatures, etc.
            {
                return Convert.ToInt32(value, 16);
            }

            int parsed;
            if (int.TryParse(value, out parsed))
            {
                return parsed;
            }
            else
            {
                throw new FormatException($"Specified value: [{ value }] is not an actual Int32. Check and fix Your config file.");
            }
        }

        /// <summary>
        /// Parses config value using specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int ParseConfigValue(string key)
        {
            string value = GetValueFromConfig(key);
            int parsed = Parse(value);
            return parsed;
        }
    }
}