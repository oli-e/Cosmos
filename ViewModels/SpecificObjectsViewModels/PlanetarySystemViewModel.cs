using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class PlanetarySystemViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public PlanetarySystemViewModel(PlanetarySystem planetarySystem) {
            Name = planetarySystem.Name;
            Size = planetarySystem.Size.Get().ToString();
        }
    }
}
