using Cosmos.Commands;
using Cosmos.Services;
using Cosmos.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace Cosmos.ViewModels
{

    public class GalaxyModel
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Address { get; set; }
    }
    public class SimpleNavigationViewModel : BaseViewModel
    {
        /*
         * This class would need to be replaced by the TreeView controls
         * How?
         * I have no idea
         * https://www.codeproject.com/Articles/26288/Simplifying-the-WPF-TreeView-by-Using-the-ViewMode
         * https://www.c-sharpcorner.com/article/populating-hierarchical-data-in-treeview-in-wpf-using-mvvm/
         * https://stackoverflow.com/questions/42591273/how-to-identify-which-button-clicked-mvvm -> how to use the Execute method overriding in Navigation Command class
         */

        private ObservableCollection<IdentifableObject> _objectProperties = new ObservableCollection<IdentifableObject>();
        public ObservableCollection<IdentifableObject> ObjectProperties
        {
            get
            {
                return _objectProperties;
            }
            set
            {
                _objectProperties = value;
                OnPropertyChanged(nameof(ObjectProperties));
            }
        }

        public ICommand GoToHelp { get; }
        public ItemRepository dlocal { get; }
        public ICommand GoToObjectByID { get; }
        public ICommand AddGalaxyCommand { get; set; }
        public SimpleNavigationViewModel(NavigationStore navigationStore, ItemRepository itemRepository, TreeViewStore treeViewStore, CurrentItemIDStore currentItemIDStore)
        {
            GoToHelp = new NavigationCommand<HelpViewModel>(navigationStore, currentItemIDStore, itemRepository,treeViewStore);
            GoToObjectByID = new NavigationCommand<BaseViewModel>(navigationStore, currentItemIDStore, itemRepository,treeViewStore);
            AddGalaxyCommand = new AddGalaxyCommand(treeViewStore,navigationStore,itemRepository,currentItemIDStore);
            dlocal = itemRepository;

            foreach(Galaxy g in itemRepository.getData())
            {
                _objectProperties.Add(g);
            }

        }
    }
}
