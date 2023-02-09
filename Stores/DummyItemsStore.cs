using Cosmos.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Stores
{
	public class DummyItemsStore
	{
		//public List<CommonObjectViewModel> dummy_list;
		private DataGenerator dataGenerator = new DataGenerator();
		private GalaxyDao galaxyDao;

		public DummyItemsStore(GalaxyDao galaxyDao)
		{
			this.galaxyDao = galaxyDao;

			// Comment out this block of code when you've already generated the data (so you have appropriate files)
			// ----
			//Galaxy g = dataGenerator.GenerateGalaxy();
			//galaxyDao.SaveGalaxy(g);
			//galaxyDao.SaveData();
			// ----
		}

        //To be changed
        public IdentifableObject getItem(int id)
        {
			//Add ifs to handle different types
			IdentifableObject a = (IdentifableObject)galaxyDao.FindById(id);
			System.Diagnostics.Debug.WriteLine(a.GetType().ToString());
			return (IdentifableObject)galaxyDao.FindById(id);

        }
    }
}
