using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Cosmos
{
    public class DataGenerator
    {
        public Galaxy GenerateGalaxy()
        {
            Galaxy milkyWay = new Galaxy(
                "Milky Way",
                UnitValue<long>.Of(130_000, Unit.KM),
                UnitValue<long>.Of(200_000_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.MAGNITUDE),
                new Declination(10, 5, 1),
                new RightAscension(5, 3, 12),
                GalaxyType.SPRIAL);
            Star sun = new Star(
                "Sun",
                UnitValue<long>.Of(130_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.SUN_MASS),
                UnitValue<long>.Of(200_000_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.MAGNITUDE),
                new Declination(10, 5, 1),
                new RightAscension(5, 3, 12),
                StarType.SOLAR);
            PlanetarySystem solarSystem = new PlanetarySystem(
                "Solar system",
                UnitValue<long>.Of(130_000, Unit.KM),
                UnitValue<long>.Of(200_000_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.MAGNITUDE),
                new Declination(10, 5, 1),
                new RightAscension(5, 3, 12)
                );
            Planet earth = new Planet(
                "Earth",
                UnitValue<long>.Of(130_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.SUN_MASS),
                UnitValue<long>.Of(200_000_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.MAGNITUDE),
                new Declination(10, 5, 1),
                new RightAscension(5, 3, 12)
                );
            Moon moon = new Moon(
                "Moon",
                UnitValue<long>.Of(40_000, Unit.KM),
                UnitValue<double>.Of(0.05, Unit.SUN_MASS),
                UnitValue<long>.Of(200_000_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.MAGNITUDE),
                new Declination(10, 5, 1),
                new RightAscension(5, 3, 12),
                UnitValue<long>.Of(350_000, Unit.KM));

            milkyWay.AddStar(sun);
            sun.AddPlanetarySystem(solarSystem);
            solarSystem.AddPlanet(earth);
            earth.AddMoon(moon);
            return milkyWay;
        }

    }
}
