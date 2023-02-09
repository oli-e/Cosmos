using Cosmos.Commands;
using Cosmos.Services;
using Cosmos.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cosmos.ViewModels
{
    public class SimpleNavigationViewModel : BaseViewModel
    {
        /*
         * This class would need to be replaced by the TreeView controls
         * How?
         * I have no idea
         * https://www.codeproject.com/Articles/26288/Simplifying-the-WPF-TreeView-by-Using-the-ViewMode
         * https://www.c-sharpcorner.com/article/populating-hierarchical-data-in-treeview-in-wpf-using-mvvm/
         * https://stackoverflow.com/questions/42591273/how-to-identify-which-button-clicked-mvvm -> how to use the Execute method overriding in Navigation Command class
         */
        //public ICommand GoToPlanetByID { get; } //Seems like won't be needed anymore
        //public ICommand GoToMoonByID { get; } //Seems like won't be needed anymore
        public ICommand GoToHelp { get; }
        public ICommand GoToObjectByID { get; }
        public SimpleNavigationViewModel(NavigationStore navigationStore, ItemRepository d, CurrentItemIDStore currentItemIDStore)
        {
                //GoToHelp = new NavigationCommand<HelpViewModel>(navigationStore, currentItemIDStore,d, () => new HelpViewModel());
                //GoToObjectByID = new NavigationCommand<SingleItemViewViewModel>(navigationStore, currentItemIDStore,d, () => new SingleItemViewViewModel(d, currentItemIDStore));
            GoToHelp = new NavigationCommand<HelpViewModel>(navigationStore, currentItemIDStore, d);
            GoToObjectByID = new NavigationCommand<SingleItemViewViewModel>(navigationStore, currentItemIDStore, d);
        }
    }
}
