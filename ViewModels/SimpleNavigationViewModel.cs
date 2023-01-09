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
        public ICommand GoToPlanet { get; }
        public ICommand GoToMoon { get; }

        public SimpleNavigationViewModel(NavigationStore navigationStore)
        {
            GoToPlanet = new NavigatePlanet(navigationStore);
            GoToMoon = new NavigateMoon(navigationStore);
        }
    }
}
