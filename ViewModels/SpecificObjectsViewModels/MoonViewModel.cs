using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class MoonViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public MoonViewModel(Moon moon)
        {
            Name = moon.Name;
            Size = moon.Size.Get().ToString();
        }
    }
}
