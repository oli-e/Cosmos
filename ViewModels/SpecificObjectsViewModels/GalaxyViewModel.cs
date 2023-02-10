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
        public string Size {get; set;}

        public GalaxyViewModel(ItemRepository d, int id) {
            _galaxy = (Galaxy)d.getItem(id);
            _name = _galaxy.Name;
            Size = _galaxy.Size.Get().ToString();
            
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
