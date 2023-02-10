using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Services.DTOs
{
    public class PlanetarySystemDTO
    {
        public String Name { get; set; }
        public UnitValue<long> Size {get; set;}
        public UnitValue<long> DistanceFromEarth { get; set; }
        public UnitValue<double> ApparentMagnitude { get; set; }
        public Declination Declination { get; set; }
        public RightAscension RightAscension { get; set; }
        public List<Planet> Planets { get; set; }
    }
}
