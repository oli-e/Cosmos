using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class PlanetViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public PlanetViewModel(Planet planet) {
            Name = planet.Name;
            Size = planet.Size.Get().ToString();
        }
    }
}
