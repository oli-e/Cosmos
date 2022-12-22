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
    public class DatabaseService
    {
        public List<Galaxy> galaxies = new List<Galaxy>();

        public void SaveGalaxy(Galaxy planet)
        {
            galaxies.Add(planet);
        }

        public void SaveToFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(galaxies, options);
            File.WriteAllText("data.json", jsonData);
        }

        public List<Galaxy> LoadFromFile()
        {
            string data = File.ReadAllText("data.json");
            List<Galaxy> loadedData = JsonSerializer.Deserialize<List<Galaxy>>(data);
            return loadedData;
        }

    }
}
