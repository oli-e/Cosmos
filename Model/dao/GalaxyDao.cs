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
    /// <summary>
    /// DAO class for managing a tree hierarchy model.
    /// </summary>
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
            return Galaxies.ContainsKey(id) ? Galaxies[id] : null;
        }

		public void AddGalaxy(Galaxy galaxy)
		{
			Galaxies[galaxy.Id] = galaxy;
		}

		public void RemoveGalaxy(long id)
        {
            Galaxies.Remove(id);
        }

        public void RemoveById(long id)
		{
            Galaxy galaxyToRemove = GetGalaxy(id);
            if (galaxyToRemove != null)
			{
                RemoveGalaxy(id);
                return;
			}
            object objToRemove = FindById(id);
            IRemovable removable = (IRemovable) objToRemove;
            removable.Remove();
		}

        public object FindById(long id)
        {
            foreach (KeyValuePair<long, Galaxy> entry in Galaxies)
            {
                object obj = entry.Value.FindById(id);
                if (obj != null)
                {
                    return obj;
                }
                if (entry.Key == id)
				{
                    return Galaxies[id];
				}
            }
            return null;
        }

        public void LoadData()
        {
            try
			{
                List<Galaxy> galaxies = dataFileSaver.LoadAllFromFile<Galaxy>(DATA_FILE_NAME);
                galaxies.ForEach(galaxy => Galaxies[galaxy.Id] = galaxy);
                InitAllObjects();
            }
            catch (FileNotFoundException e)
			{
                // Ignore missing file
			}
        }

        public void SaveData()
        {
            dataFileSaver.SaveAllToFile(Galaxies.Values.ToList(), DATA_FILE_NAME);
        }

        private void InitAllObjects()
        {
            foreach (KeyValuePair<long, Galaxy> entry in Galaxies)
            {
                entry.Value.Init();
            }
        }

    }
}
