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
    public class GalaxyDao
    {
        private const string DATA_FILE_NAME = "data";

        private readonly DataFileSaver dataFileSaver = new DataFileSaver();
        private Dictionary<long, Galaxy> Galaxies { get; set; } = new Dictionary<long, Galaxy>();

        public List<Galaxy> GetGalaxies()
        {
            return Galaxies.Values.ToList();
        }

        public Galaxy GetGalaxy(long id)
        {
            return Galaxies[id];
        }

        public void SaveGalaxy(Galaxy galaxy)
        {
            Galaxies[galaxy.Id] = galaxy;
            SaveData();
        }

        public void RemoveGalaxy(long id)
        {
            Galaxies.Remove(id);
            SaveData();
        }

        public void LoadData()
        {
            List<Galaxy> galaxies = dataFileSaver.LoadAllFromFile<Galaxy>(DATA_FILE_NAME);
            galaxies.ForEach(galaxy => Galaxies[galaxy.Id] = galaxy);
        }

        // TODO saving data after every change
        public void SaveData()
        {
            dataFileSaver.SaveAllToFile(Galaxies.Values.ToList(), DATA_FILE_NAME);
        }
    }
}
