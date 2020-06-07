using System.Configuration;

namespace DesktopColorPicker.common
{
    class Config
    {
        public void Set(string what, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[what].Value = value;
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }
        public string Get(string what)
        {
            return ConfigurationManager.AppSettings.Get(what);
        }
    }
}
