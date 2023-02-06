using Cosmos.Stores;
using Cosmos.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Cosmos
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //initialization of the common navigation store
            NavigationStore navigationStore = new NavigationStore();
            //Mimic database access
            DummyItemsStore dummyItemsStore = new DummyItemsStore();

            //TODO
            //CurrentItemStore curentItemStore = new CurrentItemStore();

            //initialization of view at the beginning of the application
            navigationStore.CurrentViewModel = new SingleItemViewViewModel(dummyItemsStore,0);

            //overriding the startup of the main window
            MainWindow = new MainWindow()
            {
                //TODO swap dummy for CurrentItem
                DataContext = new MainWindowViewModel(dummyItemsStore, navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
