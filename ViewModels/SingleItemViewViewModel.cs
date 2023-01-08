using Cosmos.ViewModels.SpecificViewModels.BasicAstronomicalObjectViewModels;
using Cosmos.ViewModels.SpecificViewModels.MoonViewModels;
using Cosmos.ViewModels.SpecificViewModels.PlanetViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cosmos.ViewModels
{
    public class SingleItemViewViewModel : BaseViewModel
    {
        //primitive setting views as a mean to test the views -> redo when adding commands and navigationStore
        public BaseViewModel CurrentUserControlViewModel { get; }

        public SingleItemViewViewModel()
        {
            CurrentUserControlViewModel = new PlanetUserControlViewModel();
        }
    }
}
