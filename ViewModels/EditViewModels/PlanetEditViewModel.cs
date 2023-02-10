using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cosmos.ViewModels.EditViewModels
{
    public class PlanetEditViewModel : BaseViewModel
    {
        private readonly Planet _planetObject;

        //COMMENT needs to add validation for string/long values
        public string Name
        {
            get
            {
                return _planetObject.Name.ToString();
            }
            set
            {
                _planetObject.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Size
        {
            get
            {
                return _planetObject.Size.Get().ToString();
            }
            set
            {
                
                _planetObject.Size.Set(long.Parse(value));
                OnPropertyChanged(nameof(Size));
            }
        }
        public string Mass
        {
            get 
            { 
                return _planetObject.Mass.ToString(); 
            }
            set 
            {
                _planetObject.Mass.Set(double.Parse(value));
                OnPropertyChanged(nameof(Mass));
            }
        }
        public string DistanceFromEarth 
        { 
            get 
            { 
                return _planetObject.DistanceFromEarth.ToString(); 
            }
            set 
            {
                _planetObject.DistanceFromEarth.Set(long.Parse(value));
            }
        }
        public string ApparentMagnitude
        {
            get { return _planetObject.ApparentMagnitude.Get().ToString(); }
            set
            {
                _planetObject.ApparentMagnitude.Set(double.Parse(value));
                OnPropertyChanged(nameof(ApparentMagnitude));
            }
        }
        public string Declination
        {
            get { return _planetObject.Declination.Degress.ToString(); }
            set
            {
                _planetObject.Declination.Degress = sbyte.Parse(value);
                OnPropertyChanged(nameof(Declination));
            }
        }
        public string RightAscension
        {
            get { return _planetObject.RightAscension.Hours.ToString(); }
            set
            {
                _planetObject.RightAscension.Hours = sbyte.Parse(value);
                OnPropertyChanged(nameof(RightAscension));
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

    }
}
