namespace Adapter
{
    using System.IO;
    using System.Text.Json;
    internal class ConfigurationAdapter : AppConfiguration
    {
        private ConfigurationDTO configuration = null;
        private string FilePath {get;set;}
        private string ConfigurationValue {get;set;}
        private const string XML_EXT = ".xml";
        private const string JSON_EXT = ".json";

        private void ParseJsonConfig() => configuration = (ConfigurationDTO)JsonSerializer.Deserialize(this.ConfigurationValue,typeof(ConfigurationDTO));

        public override ConfigurationDTO ParseConfiguration(string filePath)
        {
            string ext = string.Empty;
            if (File.Exists(filePath))
            {
                this.FilePath= !string.IsNullOrWhiteSpace(filePath) ? filePath : string.Empty;
                ext = Path.GetExtension(this.FilePath);
                this.ConfigurationValue = !string.IsNullOrWhiteSpace(ext) ? File.ReadAllText(filePath) : string.Empty;
            }

            switch (ext)
            {
                case XML_EXT:
                    break;
                case JSON_EXT:
                    ParseJsonConfig();
                    break;
            }
            return configuration;
        }   
    }
}