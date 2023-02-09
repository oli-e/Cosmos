using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class GalaxyViewModel : BaseViewModel
    {
        private Galaxy GalaxyObject { get; set; }
        public GalaxyViewModel() {
        
            // take item from store, or from current item depending if we want to change it in the Command
        }
    }
}
