using Cosmos.Stores;
using Cosmos.ViewModels;
using Cosmos.ViewModels.SpecificObjectsViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Cosmos
{
    public partial class App : Application
    {
        private readonly GalaxyDao galaxyDao = new GalaxyDao();

        protected override void OnStartup(StartupEventArgs e)
        {
            InitializeApplicationData();

            //initialization of the common navigation store
            NavigationStore navigationStore = new NavigationStore();

            //initialization of the TreeView navigation store
            TreeViewStore treeViewStore = new TreeViewStore();
            //Mimic database access
            ItemRepository dummyItemsStore = new ItemRepository(galaxyDao);

            //TODO
            //CurrentItemIDStore for switching the contetnts of single item view
            CurrentItemIDStore currentItemIDStore = new CurrentItemIDStore();
            currentItemIDStore.CurrentItemID = 0;

            //CurrentItemStore
            CurrentItemStore currentItemStore = new CurrentItemStore();
            currentItemStore.CurrentItem = dummyItemsStore.getItem(0);
            System.Diagnostics.Debug.WriteLine(currentItemStore.CurrentItem);

            //initialization of view at the beginning of the application
            navigationStore.CurrentViewModel = new GalaxyViewModel(dummyItemsStore,navigationStore,currentItemIDStore,treeViewStore);
            treeViewStore.CurrentSimpleNavigationViewModel = new SimpleNavigationViewModel(navigationStore,dummyItemsStore,treeViewStore,currentItemIDStore);

            //overriding the startup of the main window
            MainWindow = new MainWindow()
            {
                //TODO swap dummy for CurrentItem
                DataContext = new MainWindowViewModel(dummyItemsStore, navigationStore,treeViewStore, currentItemIDStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        protected void OnExitApplication(object sender, ExitEventArgs e)
        {
            SaveApplicationData();
		}

        private void InitializeApplicationData()
		{
            galaxyDao.LoadData();
        }

        private void SaveApplicationData()
        {
            galaxyDao.SaveData();
        }
    }
}
