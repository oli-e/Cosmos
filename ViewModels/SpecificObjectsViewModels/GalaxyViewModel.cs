using Cosmos.Commands;
using Cosmos.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class GalaxyViewModel : BaseViewModel
    {
        //private Galaxy GalaxyObject { get; set; }
        private Galaxy _galaxy;
        private string _name;
        private long _size;
        private string _sizeDesc;
        private long _distanceFromEarth;
        private string _distanceFromEarthDesc;
        private double _apparentMagnitude;
        private string _apparentMagnitudeDesc;
        private sbyte _declinationDegress;
        private byte _declinationMinutes;
        private double _declinationSeconds;
        private sbyte _rightAscensionHours;
        private byte _rightAscensionMinutes;
        private double _rightAscensionSeconds;
        private string _type;
        public Galaxy Galaxy => _galaxy;
        public string Name { 
            get { return _name; }
            set
            {
                if(_name != value)
                {
                    System.Diagnostics.Debug.WriteLine($"Name property of Galaxy Changed");
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public long Size {
            get { return _size; }
            set { 
                if(_size != value)
                {
                    _size = value;
                    OnPropertyChanged(nameof(Size));
                }
            } 
        }
        public string SizeDesc { 
            get { return _sizeDesc; } 
            set {
                if(_sizeDesc != value)
                {
                    _sizeDesc = value;
                    OnPropertyChanged(nameof(SizeDesc));
                }
            }
        }
        public long DistanceFromEarth { 
            get { return _distanceFromEarth; } 
            set { 
                if(_distanceFromEarth != value)
                {
                    _distanceFromEarth = value;
                    OnPropertyChanged(nameof(DistanceFromEarth));
                }
            } 
        }
        public string DistanceFromEarthDesc {
            get { return _distanceFromEarthDesc; }
            set
            {
                if(_distanceFromEarthDesc != value)
                {
                    _distanceFromEarthDesc = value;
                    OnPropertyChanged(nameof(DistanceFromEarthDesc));
                }
            }
        }
        public double ApparentMagnitude {
            get { return _apparentMagnitude; } 
            set { 
                if (_apparentMagnitude != value) {
                    _apparentMagnitude = value;
                    OnPropertyChanged(nameof(ApparentMagnitude));
                } 
            } 
        }
        public string ApparentMagnitudeDesc {
            get { return _apparentMagnitudeDesc; }
            set 
            {
                if(_apparentMagnitudeDesc != value)
                {
                    _apparentMagnitudeDesc = value;
                    OnPropertyChanged(nameof(ApparentMagnitudeDesc));
                }
            } }

        // TODO może da się to zrobić jakoś bardziej fancy (te deklinacje i rektascensje)?
        public sbyte DeclinationDegress {
            get { return _declinationDegress; } 
            set 
            {
                if(_declinationDegress != value)
                {
                    _declinationDegress = value;
                    OnPropertyChanged(nameof(DeclinationDegress));
                }
            } 
        }
        public byte DeclinationMinutes {
            get { return _declinationMinutes; } 
            set { 
                if(_declinationMinutes != value)
                {
                    _declinationMinutes = value;
                    OnPropertyChanged(nameof(DeclinationMinutes));
                }
            } 
        }
        public double DeclinationSeconds {
            get { return _declinationSeconds; }
            set 
            {
                if(value != _declinationSeconds)
                {
                    _declinationSeconds = value;
                    OnPropertyChanged(nameof(DeclinationSeconds));
                }
            } 
        }
        public sbyte RightAscensionHours {
            get { return _rightAscensionHours; }
            set 
            {
                if(_rightAscensionHours != value)
                {
                    _rightAscensionHours = value;
                    OnPropertyChanged(nameof(RightAscensionHours));
                }
            } 
        }
        public byte RightAscensionMinutes {
            get { return _rightAscensionMinutes; } 
            set 
            {
                if(_rightAscensionMinutes != value)
                {
                    _rightAscensionMinutes = value;
                    OnPropertyChanged(nameof(RightAscensionMinutes));
                }
            } 
        }
        public double RightAscensionSeconds {
            get { return _rightAscensionSeconds; }
            set 
            {
                if(_rightAscensionSeconds != value)
                {
                    _rightAscensionSeconds = value;
                    OnPropertyChanged(nameof(RightAscensionSeconds));
                }
            } 
        }

        public string Type { get; set; }

        public GalaxyViewModel(ItemRepository d,NavigationStore navigationStore, CurrentItemIDStore currentItemIDStore,TreeViewStore treeViewStore)
        {
            _galaxy = (Galaxy)d.getItem(currentItemIDStore.CurrentItemID);
            Name = _galaxy.Name;
            Size = _galaxy.Size.Get();
            SizeDesc = _galaxy.Size.GetUnit().ToString();
            DistanceFromEarth = _galaxy.DistanceFromEarth.Get();
            DistanceFromEarthDesc = _galaxy.DistanceFromEarth.GetUnit().ToString();
            ApparentMagnitude = _galaxy.ApparentMagnitude.Get();
            ApparentMagnitudeDesc = _galaxy.ApparentMagnitude.GetUnit().ToString();
            DeclinationDegress = _galaxy.Declination.Degress;
            DeclinationMinutes = _galaxy.Declination.Minutes;
            DeclinationSeconds = _galaxy.Declination.Seconds;
            RightAscensionHours = _galaxy.RightAscension.Hours;
            RightAscensionMinutes = _galaxy.RightAscension.Minutes;
            RightAscensionSeconds = _galaxy.RightAscension.Seconds;
            Type = _galaxy.Type.ToString();

            SaveCommand = new SaveCommand(this,treeViewStore,navigationStore,d,currentItemIDStore);
            SaveCommand.CanExecute(false);
            DiscardChanges = new DiscardChangesCommand(this);
            AddChild = new AddChildCommand(this, treeViewStore, navigationStore, d, currentItemIDStore);
            Delete = new DeleteCommand(this, treeViewStore, navigationStore, d, currentItemIDStore);
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DiscardChanges { get; set; }
        public ICommand AddChild { get; set; }
        public ICommand Delete { get; set; }
    }
}
