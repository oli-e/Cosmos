﻿using Cosmos.Stores;
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
        private GalaxyDao galaxyDao = new GalaxyDao();

        protected override void OnStartup(StartupEventArgs e)
        {
            galaxyDao.LoadData();

            //initialization of the common navigation store
            NavigationStore navigationStore = new NavigationStore();
            //Mimic database access
            DummyItemsStore dummyItemsStore = new DummyItemsStore(galaxyDao);

            //TODO
            //CurrentItemIDStore for switching the contetnts of single item view
            CurrentItemIDStore currentItemIDStore = new CurrentItemIDStore();
            currentItemIDStore.CurrentItemID = 0;

            //CurrentItemStore
            CurrentItemStore currentItemStore = new CurrentItemStore();
            currentItemStore.CurrentItem = dummyItemsStore.getItem(0);
            System.Diagnostics.Debug.WriteLine(currentItemStore.CurrentItem);

            //initialization of view at the beginning of the application
            navigationStore.CurrentViewModel = new SingleItemViewViewModel(dummyItemsStore,currentItemIDStore);

            //overriding the startup of the main window
            MainWindow = new MainWindow()
            {
                //TODO swap dummy for CurrentItem
                DataContext = new MainWindowViewModel(dummyItemsStore, navigationStore, currentItemIDStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
