﻿using Cosmos.Stores;
using Cosmos.ViewModels.SpecificViewModels.MoonViewModels;
using Cosmos.ViewModels.SpecificViewModels.PlanetViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Commands
{
    public class NavigateMoon : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateMoon(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new MoonUserControlViewModel();
        }
    }
}
