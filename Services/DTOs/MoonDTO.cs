using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Services.DTOs
{
    public class MoonDTO
    {
        public string Name { get; set; }
        public UnitValue<long> Size { get; set; }
        public UnitValue<double> Mass { get; set; }
        public UnitValue<long> DistanceFromEarth { get; set; }
        public UnitValue<double> ApparentMagnitude { get; set; }
        public Declination Declination { get; set; }
        public RightAscension RightAscension { get; set; } 
        public UnitValue<long> DistanceFromPlanet { get; set; }
    }
}
