namespace Cosmos.Tests
{
    public class Tests
    {
        private GalaxyDao galaxyDao;
        private ItemRepository dummyItemsStore;
        private DataGenerator dataGenerator;
        [SetUp]
        public void Setup()
        {
            galaxyDao= new GalaxyDao();
            dataGenerator = new DataGenerator();
            var galaxyExample = dataGenerator.GenerateGalaxy();
            galaxyDao.AddGalaxy(galaxyExample);
            dummyItemsStore = new ItemRepository(galaxyDao);
        }

        [Test]
        public void Test_galaxyDaoCreation()
        {
            Assert.IsNotNull(galaxyDao);    
        }

        [Test]
        public void Test_galaxiesExist()
        {
            Assert.IsNotEmpty(galaxyDao.GetGalaxies());
        }




    }
}