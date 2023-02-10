using Cosmos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Stores
{
    public class TreeViewStore
    {
        private SimpleNavigationViewModel _currentSimpleNavigationViewModel;

        public SimpleNavigationViewModel CurrentSimpleNavigationViewModel
        {
            get => _currentSimpleNavigationViewModel;
            set
            {
                _currentSimpleNavigationViewModel = value;
                OnCurrentNavigationChanged();
            }
        }

        public event Action CurrentNavigationViewChanged;
        private void OnCurrentNavigationChanged()
        {
            CurrentNavigationViewChanged?.Invoke();
        }
    }
}
