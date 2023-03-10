using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class PlanetarySystemViewModel : BaseViewModel
    {
        private PlanetarySystem _planetarySystem;
        public PlanetarySystem PlanetarySystem => _planetarySystem;
        public string Name { get; set; }
        public long Size { get; set; }
        public string SizeDesc { get; set; }

        public PlanetarySystemViewModel(ItemRepository d, int id) {
            _planetarySystem = (PlanetarySystem)d.getItem(id);
            Name = PlanetarySystem.Name;
            Size = PlanetarySystem.Size.Get();
            SizeDesc = PlanetarySystem.Size.GetUnit().ToString();
        }
    }
}
