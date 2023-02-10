using Cosmos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Stores
{
    public class CurrentItemIDStore
    {
        private int _currentItemID;
        public int CurrentItemID
        {
            get => _currentItemID;
            set
            {
                _currentItemID = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action CurrentViewModelChanged;
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
