using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class PlanetViewModel : BaseViewModel
    {
        private Planet _planet;
        public Planet Planet => _planet;
        public string Name { get; set; }
        public long Size { get; set; }
        public string SizeDesc { get; set; }
        public double Mass { get; set; }
        public string MassDesc { get; set; }

        public long DistanceFromEarth { get; set; }
        public string DistanceFromEarthDesc { get; set; }

        public double ApparentMagnitude { get; set; }
        public string ApparentMagnitudeDesc { get; set; }

        public sbyte DeclinationDegress { get; set; }
        public byte DeclinationMinutes { get; set; }
        public double DeclinationSeconds { get; set; }

        public sbyte RightAscensionHours { get; set; }
        public byte RightAscensionMinutes { get; set; }
        public double RightAscensionSeconds { get; set; }
        public PlanetViewModel(ItemRepository itemRepository, int id) {
            Planet planet = (Planet)itemRepository.getItem(id);
            Name = planet.Name;
            Size = planet.Size.Get();
            SizeDesc = planet.Size.GetUnit().ToString();
            Mass = planet.Mass.Get();
            MassDesc = planet.Mass.GetUnit().ToString();
            DistanceFromEarth = planet.DistanceFromEarth.Get();
            DistanceFromEarthDesc = planet.DistanceFromEarth.GetUnit().ToString();
            ApparentMagnitude = planet.ApparentMagnitude.Get();
            ApparentMagnitudeDesc = planet.ApparentMagnitude.GetUnit().ToString();
            DeclinationDegress = planet.Declination.Degress;
            DeclinationMinutes = planet.Declination.Minutes;
            DeclinationSeconds = planet.Declination.Seconds;
            RightAscensionHours = planet.RightAscension.Hours;
            RightAscensionMinutes = planet.RightAscension.Minutes;
            RightAscensionSeconds = planet.RightAscension.Seconds;
        }
    }
}
