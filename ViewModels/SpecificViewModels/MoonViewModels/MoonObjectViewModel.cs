using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificViewModels.MoonViewModels
{
    public class MoonObjectViewModel : BaseViewModel
    {
        private readonly Moon _moonObject;
        public string Name => _moonObject.Name;
        public string Size => _moonObject.Size.Get().ToString();
        public string Mass => _moonObject.Mass.Get().ToString();
        public string DistanceFromEarth => _moonObject.DistanceFromEarth.Get().ToString();
        public string ApparentMagnitude => _moonObject.ApparentMagnitude.Get().ToString();
        public string Declination => _moonObject.Declination.Degress.ToString();
        public string RightAscension => _moonObject.RightAscension.Hours.ToString();

        public MoonObjectViewModel(Moon moon)
        {
            _moonObject = moon;
        }
    }
}
