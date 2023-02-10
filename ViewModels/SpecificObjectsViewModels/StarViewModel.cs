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
        public string Size { get; set; }
        public StarViewModel(ItemRepository itemRepository, int id) {
            _star = (Star)itemRepository.getItem(id);
            _name = Star.Name;
            Size = Star.Size.Get().ToString();

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
