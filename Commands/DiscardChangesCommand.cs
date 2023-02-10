using Cosmos.ViewModels.SpecificObjectsViewModels;
using Cosmos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Commands
{
    public class DiscardChangesCommand : CommandBase
    {
        private BaseViewModel _baseViewModel;
        public DiscardChangesCommand(BaseViewModel baseViewModel)
        {
            _baseViewModel = baseViewModel;
            System.Diagnostics.Debug.WriteLine($"Checking Types");
            System.Diagnostics.Debug.WriteLine(baseViewModel.GetType());
        }
        public override void Execute(object parameter)
        {
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.GalaxyViewModel")
            {
                GalaxyViewModel galaxyViewModel = (GalaxyViewModel)_baseViewModel;
                galaxyViewModel.Name = galaxyViewModel.Galaxy.Name;

            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.StarViewModel")
            {
                StarViewModel starViewModel = (StarViewModel)_baseViewModel;
                starViewModel.Name = starViewModel.Star.Name;
            }

            //TODO remaining objects

            //throw new NotImplementedException();
        }
        /*public override bool CanExecute(object parameter)
        {
            return _baseViewModel.CanDiscard;
        }*/
    }
}
