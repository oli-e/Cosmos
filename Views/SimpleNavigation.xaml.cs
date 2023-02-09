using Cosmos.Stores;
using Cosmos.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cosmos.Views
{

    
    /// <summary>
    /// Interaction logic for SimpleNavigation.xaml
    /// </summary>
    public partial class SimpleNavigation : UserControl
    {
        public SimpleNavigation()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var treeView = (TreeView)sender;
            var command = (ICommand)treeView.Tag;
            IdentifableObject selectedItem = (IdentifableObject)treeView.SelectedItem;
            if (selectedItem.Id != null)
            {
                command.Execute(selectedItem.Id);
            }
        }

    }

}
