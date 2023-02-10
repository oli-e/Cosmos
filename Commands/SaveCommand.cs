using Cosmos.ViewModels;
using Cosmos.ViewModels.SpecificObjectsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Commands
{
    public class SaveCommand : CommandBase
    {
        private BaseViewModel _baseViewModel;
        public SaveCommand(BaseViewModel baseViewModel)
        {
            _baseViewModel = baseViewModel;
            System.Diagnostics.Debug.WriteLine($"Checking Types");
            System.Diagnostics.Debug.WriteLine(baseViewModel.GetType());
        }
        public override void Execute(object parameter)
        {
            if(_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.GalaxyViewModel")
            {
                GalaxyViewModel galaxyViewModel = (GalaxyViewModel)_baseViewModel;
                galaxyViewModel.Galaxy.Name = galaxyViewModel.Name;

                //galaxyViewModel.CanSave = false;
                //galaxyViewModel.CanDiscard = false;
                
            }
            if (_baseViewModel.GetType().ToString() == "Cosmos.ViewModels.SpecificObjectsViewModels.StarViewModel")
            {
                StarViewModel starViewModel = (StarViewModel)_baseViewModel;
                starViewModel.Star.Name = starViewModel.Name;

                //starViewModel.CanSave = false;
                //starViewModel.CanDiscard = false;
            }

        }
        /*public override bool CanExecute(object parameter)
        {
            System.Diagnostics.Debug.WriteLine($"CanSave: {_baseViewModel.CanSave}");
            return _baseViewModel.CanSave && base.CanExecute(parameter);
        }*/
    }
}
