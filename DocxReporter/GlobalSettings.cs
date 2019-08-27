using Newtonsoft.Json;
using System;
using System.IO;

namespace DocxSearcher
{
    public static class GlobalSettings
    {

        private static GlobalSettingsManagement _Management = null;
        public static GlobalSettingsManagement Management
        {
            get
            {
                return (_Management ?? (_Management = new GlobalSettingsManagement()));
            }

        }


        public static ConfigurationData Data => ConfigurationData.Data;
    }

    public class ConfigurationData
    {
        public Configuration Configurations { get; set; }

        public ConfigurationData()
        {
            Configurations = new Configuration()
            {
                DefaultDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            };
        }

        private static ConfigurationData _Data = null;
        public static ConfigurationData Data
        {
            get
            {
                return (_Data ?? (_Data = new ConfigurationData()));
            }

        }

        public static void SetData(ConfigurationData data)
        {
            _Data = data;

            if (_Data == null)
            {
                _Data = new ConfigurationData();
            }
        }
    }

    public class GlobalSettingsManagement
    {
        /// <summary>
        /// 明文配置文件路径
        /// </summary>
        private static string DataFile = System.Environment.CurrentDirectory + @"\data.json";
        private static string ConfigFile = System.Environment.CurrentDirectory + @"\config.json";

        public void LoadConfig()
        {
            if (!File.Exists(ConfigFile))
            {
                var fs = new FileStream(ConfigFile, FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }

            var json = File.ReadAllText(ConfigFile);
            var data = JsonConvert.DeserializeObject<ConfigurationData>(json);
            ConfigurationData.SetData(data);

        }
        public void SaveConfig()
        {
            var jsonSetting = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
            var json = JsonConvert.SerializeObject(ConfigurationData.Data, jsonSetting);

            File.WriteAllText(ConfigFile, json);
        }



        public void Load()
        {
            LoadConfig();

        }
        public void Save()
        {
            SaveConfig();

        }


    }

}
