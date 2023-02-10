using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class PlanetViewModel : BaseViewModel
    {
        private Planet _planet;
        public Planet Planet => _planet;
        public string Name { get; set; }
        public string Size { get; set; }
        public PlanetViewModel(ItemRepository itemRepository, int id) {
            Planet planet = (Planet)itemRepository.getItem(id);
            Name = planet.Name;
            Size = planet.Size.Get().ToString();
        }
    }
}
