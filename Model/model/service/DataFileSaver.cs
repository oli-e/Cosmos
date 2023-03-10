using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Cosmos
{
    public class DataFileSaver
    {
        public void SaveToFile<T>(T obj, string name)
        {
            //DEBUG
            return;

            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(name + ".json", jsonData);
            
        }

        public void SaveAllToFile<T>(List<T> objects, string name)
        {
            //DEBUG
            return;

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonData = JsonSerializer.Serialize(objects, options);
            File.WriteAllText(name + ".json", jsonData);
            
        }

        public List<T> LoadAllFromFile<T>(string name)
        {
            //DEBUG
            return new List<T>();

            string data = File.ReadAllText(name + ".json");
            List<T> loadedData = JsonSerializer.Deserialize<List<T>>(data);
            return loadedData;
           
        }

        public T LoadFromFile<T>(string name)
        {
            //DEBUG
            return default(T);

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
            };
            string data = File.ReadAllText(name + ".json");
            T loadedData = JsonSerializer.Deserialize<T>(data, options);
            return loadedData;
            
        }

    }
}
