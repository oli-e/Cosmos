using Cosmos.Commands;
using Cosmos.Services;
using Cosmos.Stores;
using Cosmos.ViewModels.SpecificViewModels.MoonViewModels;
using Cosmos.ViewModels.SpecificViewModels.PlanetViewModels;
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
        public ICommand GoToPlanet { get; }
        public ICommand GoToMoon { get; }

        public SimpleNavigationViewModel(NavigationStore navigationStore)
        {
            GoToPlanet = new NavigationCommand<PlanetUserControlViewModel>(navigationStore, () => new PlanetUserControlViewModel());
            GoToMoon = new NavigationCommand<MoonUserControlViewModel>(navigationStore,() => new MoonUserControlViewModel());
        }
    }
}
