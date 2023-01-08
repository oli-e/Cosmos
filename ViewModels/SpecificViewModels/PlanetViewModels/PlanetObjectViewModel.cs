using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificViewModels.PlanetViewModels
{
    public class PlanetObjectViewModel : BaseViewModel
    {
        private readonly Planet _planetObject;
        public string Name => _planetObject.Name;
        public string Size => _planetObject.Size.Get().ToString();
        public string Mass => _planetObject.Mass.Get().ToString();
        public string DistanceFromEarth => _planetObject.DistanceFromEarth.Get().ToString();
        public string ApparentMagnitude => _planetObject.ApparentMagnitude.Get().ToString();
        public string Declination => _planetObject.Declination.Degress.ToString();
        public string RightAscension => _planetObject.RightAscension.Hours.ToString();

        public PlanetObjectViewModel(Planet moon)
        {
            _planetObject = moon;
        }
    }
}
