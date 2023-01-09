using Cosmos.Stores;
using Cosmos.ViewModels.SpecificViewModels.PlanetViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Commands
{
    internal class NavigatePlanet : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigatePlanet(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new PlanetUserControlViewModel();
        }
    }
}
