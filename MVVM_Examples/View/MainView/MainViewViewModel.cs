using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_Examples.Model.Model;
using MVVM_Examples.Model.DAO;
using System.Collections.ObjectModel;

namespace MVVM_Examples.View.MainView
{
    internal class MainViewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        private IDBObjectDaoFacade _dbObjects = new DBObjectDaoFacadeImpl();

        public MainViewViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(
               new System.Windows.DependencyObject())) return;

            DBObjectList = new ObservableCollection<DBObject>
                (_dbObjects.GetDBObjectsAsync().Result);
        }

        public ObservableCollection<DBObject> DBObjectList { get; set; }
    }
}
