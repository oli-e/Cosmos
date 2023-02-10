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

        public long DistanceFromPlanet { get; set; }
        public string DistanceFromPlanetDesc { get; set; }

        public MoonViewModel(ItemRepository itemRepository, int id)
        {
            Moon moon = (Moon)itemRepository.getItem(id);
            _moon = moon;
            Name = moon.Name;
            Size = moon.Size.Get();
            SizeDesc = moon.Size.GetUnit().ToString();
            Mass = moon.Mass.Get();
            MassDesc = moon.Mass.GetUnit().ToString();
            DistanceFromEarth = moon.DistanceFromEarth.Get();
            DistanceFromEarthDesc = moon.DistanceFromEarth.GetUnit().ToString();
            ApparentMagnitude = moon.ApparentMagnitude.Get();
            ApparentMagnitudeDesc = moon.ApparentMagnitude.GetUnit().ToString();
            DeclinationDegress = moon.Declination.Degress;
            DeclinationMinutes = moon.Declination.Minutes;
            DeclinationSeconds = moon.Declination.Seconds;
            RightAscensionHours = moon.RightAscension.Hours;
            RightAscensionMinutes = moon.RightAscension.Minutes;
            RightAscensionSeconds = moon.RightAscension.Seconds;
            DistanceFromPlanet = moon.DistanceFromPlanet.Get();
            DistanceFromPlanetDesc = moon.DistanceFromPlanet.GetUnit().ToString();
        }
    }
}
