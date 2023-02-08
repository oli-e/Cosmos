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
        private GalaxyDao galaxyDao = new GalaxyDao();

        public DummyItemsStore()
        {
            GlobalIdentificatorProvider.GetInstance().Save();
            Galaxy g = dataGenerator.GenerateGalaxy();
            galaxyDao.SaveGalaxy(g);
        }

        //To be changed
        public IdentifableObject getItem(int id)
        {
            return (IdentifableObject)galaxyDao.FindById(id);
        }
    }
}
