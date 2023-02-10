using Cosmos.Commands;
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
                    //CanSave = true;
                    //CanDiscard = true;

                    //System.Diagnostics.Debug.WriteLine($"Name property of Galaxy Changed");
                }
            }
        }
        public long Size {get; set;}
        public string SizeDesc { get; set;}

        public long DistanceFromEarth { get; set; }
        public string DistanceFromEarthDesc { get; set; }

        public double ApparentMagnitude { get; set; }
        public string ApparentMagnitudeDesc { get; set; }

        // TODO może da się to zrobić jakoś bardziej fancy (te deklinacje i rektascensje)?
        public sbyte DeclinationDegress { get; set; }
        public byte DeclinationMinutes { get; set; }
        public double DeclinationSeconds { get; set; }

        public sbyte RightAscensionHours { get; set; }
        public byte RightAscensionMinutes { get; set; }
        public double RightAscensionSeconds { get; set; }

        public string Type { get; set; }

        public GalaxyViewModel(ItemRepository d, int id) {
            _galaxy = (Galaxy)d.getItem(id);
            _name = _galaxy.Name;
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

            SaveCommand = new SaveCommand(this);
            DiscardChanges = new DiscardChangesCommand(this);
            AddChild = new AddChildCommand(this);
            Delete = new DeleteCommand(this, d);
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DiscardChanges { get; set; }
        public ICommand AddChild { get; set; }
        public ICommand Delete { get; set; }
    }
}
