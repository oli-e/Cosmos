﻿using Cosmos.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
            SaveCommand = new SaveCommand(this);
            SaveCommand.CanExecute(false);
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
