using Cosmos.Commands;
using Cosmos.ViewModels.ObjectViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Stores
{
	public class DummyItemsStore
	{
		public List<CommonObjectViewModel> dummy_list;
		private DataGenerator dataGenerator = new DataGenerator();
		private GalaxyDao galaxyDao;

		public DummyItemsStore(GalaxyDao galaxyDao)
		{
			this.galaxyDao = galaxyDao;
			//Galaxy g = dataGenerator.GenerateGalaxy();
			//galaxyDao.SaveGalaxy(g);
			//galaxyDao.SaveData();
			//galaxyDao.RemoveById(0);
			Console.WriteLine();
		}

		//To be changed
		public CommonObjectViewModel getItem(int id)
		{
			return new CommonObjectViewModel(galaxyDao.FindById(id));
		}
	}
}
