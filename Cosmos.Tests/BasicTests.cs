using Cosmos.Services;
using Cosmos.Stores;
using Cosmos.ViewModels;
using Cosmos.ViewModels.SpecificObjectsViewModels;
using Moq;
using Cosmos.Commands;

namespace Cosmos.Tests
{
    public class Tests
    {
        private BaseViewModel viewModel;
        private HelpViewModel helpviewModel;
        private GetObjectPropertiesService getObjectPropertiesService;
        private DiscardChangesCommand discard;
        private NavigationStore navigationStore;
        private CurrentItemIDStore currentItemIDStore;
        private CurrentItemStore currentItemStore;

        [SetUp]
        public void Setup()
        {

            viewModel = new BaseViewModel();
            helpviewModel = new HelpViewModel();
            getObjectPropertiesService = new GetObjectPropertiesService();
            navigationStore = new NavigationStore();
            currentItemIDStore = new CurrentItemIDStore();
            currentItemStore = new CurrentItemStore();
            discard = new DiscardChangesCommand(viewModel);
        }

        [Test]
        public void Test_creatingBaseViewModel()
        {
            Assert.IsNotNull(viewModel);
            Assert.IsInstanceOf<BaseViewModel>(helpviewModel);

        }


        [Test]
        public void Test_creatingHelpViewModel()
        {
            Assert.IsNotNull(helpviewModel);
            Assert.IsInstanceOf<HelpViewModel>(helpviewModel);
            Assert.IsInstanceOf<BaseViewModel>(helpviewModel);

        }


        [Test]
        public void Test_creatingPropertiesService()
        {
            Assert.IsNotNull(getObjectPropertiesService);
        }


        [Test]
        public void Test_creatingNavigationStore()
        {
            Assert.IsNotNull(navigationStore);
        }

        [Test]
        public void Test_datafilesExist()
        {
            Assert.True(File.Exists("data.json"));
        }


        [Test]
        public void Test_idsfileExist()
        {
            Assert.True(File.Exists("ids.json"));
        }


        [Test]
        public void Test_discard_command()
        {
            Assert.IsNotNull(discard);
            Assert.IsInstanceOf<DiscardChangesCommand>(discard);
        }



        [Test]
        public void Test_currentItemStore()
        {
            Assert.IsNotNull(currentItemStore);
            Assert.IsInstanceOf<CurrentItemStore>(currentItemStore);
        }


        [Test]
        public void Test_currentItemIDStore()
        {
            Assert.IsNotNull(currentItemIDStore);
            Assert.IsInstanceOf<CurrentItemIDStore>(currentItemIDStore);
        }

    }
}