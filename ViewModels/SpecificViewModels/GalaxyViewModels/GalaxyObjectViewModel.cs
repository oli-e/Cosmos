using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificViewModels.GalaxyViewModels
{
    public class GalaxyObjectViewModel : BaseViewModel
    {
        private readonly Galaxy _galaxy;
        public string Name => _galaxy.Name;
        public string Size => _galaxy.Size.Get().ToString();
        public string DistanceFromEarth => _galaxy?.DistanceFromEarth.Get().ToString();
        public string ApparentMagnitude => _galaxy?.ApparentMagnitude.Get().ToString();
        public string Declination => _galaxy?.Declination.Degress.ToString();
        public string RightAscension => _galaxy?.RightAscension.Hours.ToString();

        //Add handler for list
        public List<Star> children => _galaxy.GetStars();
        public GalaxyObjectViewModel(Galaxy galaxy)
        {
            _galaxy = galaxy;
        }
    }
}
