using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificObjectsViewModels
{
    public class PlanetarySystemViewModel : BaseViewModel
    {
        private PlanetarySystem _planetarySystem;
        public PlanetarySystem PlanetarySystem => _planetarySystem;
        private string _name;
        private long _size;
        private string _sizeDesc;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    //System.Diagnostics.Debug.WriteLine($"Name property of Galaxy Changed");
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public long Size
        {
            get { return _size; }
            set
            {
                if (_size != value)
                {
                    _size = value;
                    OnPropertyChanged(nameof(Size));
                }
            }
        }
        public string SizeDesc
        {
            get { return _sizeDesc; }
            set
            {
                if (_sizeDesc != value)
                {
                    _sizeDesc = value;
                    OnPropertyChanged(nameof(SizeDesc));
                }
            }
        }

        public PlanetarySystemViewModel(ItemRepository d, int id) {
            _planetarySystem = (PlanetarySystem)d.getItem(id);
            Name = PlanetarySystem.Name;
            Size = PlanetarySystem.Size.Get();
            SizeDesc = PlanetarySystem.Size.GetUnit().ToString();
        }
    }
}
