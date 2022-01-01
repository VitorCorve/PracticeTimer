using Newtonsoft.Json;
using System;
using System.IO;

namespace WPFTimer.Model
{

    public class DataHandler
    {
        private readonly string Path = Environment.CurrentDirectory + "\\Data\\";
        private readonly string Filename = "data.json";
        public DataHandler()
        {
            Directory.CreateDirectory(Path);
            if (!File.Exists(Path + Filename))
            {
                File.WriteAllText(Path + Filename, JsonConvert.SerializeObject(new JsonDataModel(), Formatting.Indented));
            }
        }
        public JsonDataModel GetData() => JsonConvert.DeserializeObject<JsonDataModel>(File.ReadAllText(Path + Filename));
        public void SaveData(JsonDataModel jsonData)
        {
            jsonData.LastActivity = DateTime.Now;
            File.WriteAllText(Path + Filename, JsonConvert.SerializeObject(jsonData, Formatting.Indented));
        }
    }
}
