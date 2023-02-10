namespace Cosmos.Tests
{
    public class ObjectsTests
    {
        private Galaxy testGalaxy;
        private Star hotBlue;
        private PlanetarySystem solarSystem;
        private DataGenerator dataGenerator;
        private GalaxyDao galaxyDao;
        private Planet earth;
        private Moon moon;

        Galaxy generatorGalaxy;
        [SetUp]
        public void Setup()

        {
            // dataGenerator = new DataGenerator();
            //  generatorGalaxy = dataGenerator.GenerateGalaxy();
            //  galaxyDao = new GalaxyDao(generatorGalaxy);
            //
            //  testGalaxy = new Galaxy("Galaxy",
            //      UnitValue<long>.Of(130_000, Unit.KM),
            //      UnitValue<long>.Of(200_000_000, Unit.KM),
            //      UnitValue<double>.Of(1, Unit.MAGNITUDE),
            //      new Declination(10, 5, 1),
            //      new RightAscension(5, 3, 12),
            //      GalaxyType.SPIRAL);
            //
            //  hotBlue = new Star(
            //      "Star",
            //      UnitValue<long>.Of(130_000, Unit.KM),
            //      UnitValue<double>.Of(1, Unit.SUN_MASS),
            //      UnitValue<long>.Of(200_000_000, Unit.KM),
            //      UnitValue<double>.Of(1, Unit.MAGNITUDE),
            //      new Declination(10, 5, 1),
            //      new RightAscension(5, 3, 12),
            //      StarType.HOT_BLUE);

           //  solarSystem = new PlanetarySystem(
           //    "Solar system",
           //    UnitValue<long>.Of(130_000, Unit.KM)
           //    );
            // earth = new Planet(
            //    "Earth",
            //    UnitValue<long>.Of(130_000, Unit.KM),
            //    UnitValue<double>.Of(1, Unit.SUN_MASS),
            //    UnitValue<long>.Of(200_000_000, Unit.KM),
            //    UnitValue<double>.Of(1, Unit.MAGNITUDE),
            //    new Declination(10, 5, 1),
            //    new RightAscension(5, 3, 12)
            //    );
           //  moon = new Moon(
           //     "Moon",
           //     UnitValue<long>.Of(40_000, Unit.KM),
           //     UnitValue<double>.Of(0.05, Unit.SUN_MASS),
           //     UnitValue<long>.Of(200_000_000, Unit.KM),
           //     UnitValue<double>.Of(1, Unit.MAGNITUDE),
           //     new Declination(10, 5, 1),
           //     new RightAscension(5, 3, 12),
           //     UnitValue<long>.Of(350_000, Unit.KM)
           //     );

           // milkyWay.AddStar(sun);
          //  sun.AddPlanetarySystem(solarSystem);
          //  solarSystem.AddPlanet(earth);
          //  earth.AddMoon(moon);
        }

        [Test]
        public void Test_galaxyCreation()
        {
          //  Assert.IsNotNull(testGalaxy);
          //  Assert.IsTrue(testGalaxy.ToString() != "");
          //  Assert.True(testGalaxy.Name == "Galaxy");
          //  Assert.True(testGalaxy.Type == GalaxyType.SPIRAL);
          //  Assert.True(testGalaxy.DistanceFromEarth.Value == 200_000_000);
          //  Assert.True(testGalaxy.DistanceFromEarth.Unit == Unit.KM);
          //  Assert.False(testGalaxy.Size.Value == 200_000_000);
          //  Assert.False(testGalaxy.Size.Unit == Unit.SUN_MASS);
        }
        [Test]
        public void Test_setGalaxyType()
        {
          //  testGalaxy.Type = GalaxyType.IRREGULAR;
          //  Assert.True(testGalaxy.Type == GalaxyType.IRREGULAR);
        }

        [Test]
        public void Test_addStarToGalaxy()
        {
          //  Assert.IsEmpty(testGalaxy.Stars);
          //  testGalaxy.AddStar(hotBlue);
          //  Assert.True(testGalaxy.Stars.Contains(hotBlue));
          //  Assert.True(testGalaxy.Stars.Count == 1);
        }

        [Test]
        public void Test_starCreation()
        {
           // Assert.IsNotNull(hotBlue);
           // Assert.True(hotBlue.Name == "Star");
           // Assert.True(hotBlue.Type == StarType.HOT_BLUE);
           // Assert.True(hotBlue.DistanceFromEarth.Value == 200_000_000);
        }

        [Test]
        public void Test_setStarType()
        {
            // hotBlue.Type = StarType.BLACK_HOLE;
            // Assert.True(hotBlue.Type == StarType.BLACK_HOLE);

        }

        [Test]
        public void Test_planetCreation()
        {
           // Assert.IsNotNull(earth);
           // Assert.True(earth.Name == "Earth");
        }

        [Test]
        public void Test_PlanetarySystemCreation()
        {
            // Assert.IsNotNull(solarSystem);
            // Assert.True(solarSystem.Name == "Solar system");
        }

        [Test]
        public void Test_MoonCreation()
        {
           // Assert.IsNotNull(moon);
           // Assert.True(moon.Name == "Moon");
        }


        [Test]
        public void Test_PlanetarySystemHasPlanets()
        {
           // Assert.IsNotEmpty(solarSystem.GetPlanets());
        }

        [Test]
        public void Test_PlanetHasMoon()
        {
            // Assert.IsNotEmpty(earth.GetMoons());
        }

        [Test]
        public void Test_galaxyHasStar()
        {
            // Assert.IsNotEmpty(generatorGalaxy.GetStars());
        }

        [Test]
        public void Test_planetAddMoon()
        {
             //  earth.AddMoon(new Moon("Another Moon",
             //     UnitValue<long>.Of(40_000, Unit.KM),
             //     UnitValue<double>.Of(0.05, Unit.SUN_MASS),
             //     UnitValue<long>.Of(200_000_000, Unit.KM),
             //     UnitValue<double>.Of(1, Unit.MAGNITUDE),
             //     new Declination(10, 5, 1),
             //     new RightAscension(5, 3, 12),
             //     UnitValue<long>.Of(350_000, Unit.KM));
             // Assert.That(earth.GetMoons().Count(), Is.EqualTo(2));
             // Assert.IsNotEmpty(earth.GetMoons());
        }
    }
}