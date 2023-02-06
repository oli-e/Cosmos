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
         */
        public ICommand GoToPlanetByID { get; }
        public ICommand GoToMoonByID { get; }
        //public ICommand GoToObjectByID { get; }
        public ICommand GoToHelp { get; }

        //TODO SummyItemsStore swap for CurrentItemStore
        public SimpleNavigationViewModel(NavigationStore navigationStore, DummyItemsStore d)
        {
                GoToHelp = new NavigationCommand<HelpViewModel>(navigationStore, () => new HelpViewModel());
                GoToPlanetByID = new NavigationCommand<SingleItemViewViewModel>(navigationStore, () => new SingleItemViewViewModel(d, 0));
                GoToMoonByID = new NavigationCommand<SingleItemViewViewModel>(navigationStore, () => new SingleItemViewViewModel(d, 1));
        }
    }
}
