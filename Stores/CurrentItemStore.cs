using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Stores
{
    public class CurrentItemStore
    {
        private Object _currentItem;
        public Object CurrentItem
        {
            get => _currentItem;
            set
            {
                _currentItem = value;
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
