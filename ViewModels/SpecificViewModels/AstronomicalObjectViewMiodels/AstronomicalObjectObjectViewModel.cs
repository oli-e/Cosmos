using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificViewModels.AstronomicalObjectViewMiodels
{
    public class AstronomicalObjectObjectViewModel : BaseViewModel
    {
        private readonly AstronomicalObject _astronomicalObject;

        public string Name => _astronomicalObject.Name;
        public string Size => _astronomicalObject.Size?.ToString();
        public string DistanceFromEarth => _astronomicalObject?.DistanceFromEarth.ToString();
        public string ApparentMagnitude => _astronomicalObject?.ApparentMagnitude.ToString();
        public string Declination => _astronomicalObject?.Declination.ToString();
        public string RightAscension => _astronomicalObject?.RightAscension.ToString();

        public AstronomicalObjectObjectViewModel(AstronomicalObject astronomicalObject)
        {
            _astronomicalObject = astronomicalObject;
        }
    }
}
