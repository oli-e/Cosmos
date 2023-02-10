using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class MoonViewModel : BaseViewModel
    {
        private Moon _moon;
        public Moon Moon => _moon;
        public string Name { get; set; }
        public string Size { get; set; }
        public MoonViewModel(ItemRepository itemRepository, int id)
        {
            Moon moon = (Moon)itemRepository.getItem(id);
            _moon = moon;
            Name = moon.Name;
            Size = moon.Size.Get().ToString();
        }
    }
}
