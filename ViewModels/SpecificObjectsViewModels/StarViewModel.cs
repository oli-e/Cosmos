using Cosmos.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class StarViewModel : BaseViewModel 
    {
        private Star _star;
        public Star Star => _star;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    System.Diagnostics.Debug.WriteLine($"Name property of Galaxy Changed");
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public long Size { get; set; }
        public string SizeDesc { get; set; }
        public double Mass { get; set; }
        public string MassDesc { get; set; }
        public long DistanceFromEarth { get; set; }
        public string DistanceFromEarthDesc { get; set; }

        public double ApparentMagnitude { get; set; }
        public string ApparentMagnitudeDesc { get; set; }
        public sbyte DeclinationDegress { get; set; }
        public byte DeclinationMinutes { get; set; }
        public double DeclinationSeconds { get; set; }

        public sbyte RightAscensionHours { get; set; }
        public byte RightAscensionMinutes { get; set; }
        public double RightAscensionSeconds { get; set; }

        public string Type { get; set; }

        public StarViewModel(ItemRepository itemRepository, int id) {
            _star = (Star)itemRepository.getItem(id);
            _name = Star.Name;
            Size = Star.Size.Get();
            SizeDesc = Star.Size.GetUnit().ToString();
            Mass = Star.Mass.Get();
            MassDesc = Star.Mass.GetUnit().ToString();
            DistanceFromEarth = Star.DistanceFromEarth.Get();
            DistanceFromEarthDesc = Star.DistanceFromEarth.GetUnit().ToString();
            ApparentMagnitude = Star.ApparentMagnitude.Get();
            ApparentMagnitudeDesc = Star.ApparentMagnitude.GetUnit().ToString();
            DeclinationDegress = Star.Declination.Degress;
            DeclinationMinutes = Star.Declination.Minutes;
            DeclinationSeconds = Star.Declination.Seconds;
            RightAscensionHours = Star.RightAscension.Hours;
            RightAscensionMinutes = Star.RightAscension.Minutes;
            RightAscensionSeconds = Star.RightAscension.Seconds;
            Type = Star.Type.ToString();

            SaveCommand = new SaveCommand(this);
            DiscardChanges = new DiscardChangesCommand(this);
            AddChild = new AddChildCommand(this);
            Delete = new DeleteCommand(this, itemRepository);
        }
        public ICommand SaveCommand { get; set; }
        public ICommand DiscardChanges { get; set; }
        public ICommand AddChild { get; set; }
        public ICommand Delete { get; set; }
    }
}
