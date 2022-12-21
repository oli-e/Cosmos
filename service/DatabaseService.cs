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
        public List<Planet> planets = new List<Planet>();

        public void SavePlanet(Planet planet)
        {
            planets.Add(planet);
        }

        public void SaveToFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(planets, options);
            File.WriteAllText("data.txt", jsonData);
        }

        public List<Planet> LoadFromFile()
        {
            string data = File.ReadAllText("data.txt");
            List<Planet> loadedData = JsonSerializer.Deserialize<List<Planet>>(data);
            return loadedData;
        }

    }
}
