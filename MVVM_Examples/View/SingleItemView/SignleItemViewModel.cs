using MVVM_Examples.Model.DAO;
using MVVM_Examples.Model.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Examples.View.SingleItemView
{
    internal class SingleItemViewModel : INotifyPropertyChanged
    {
        //Implementation of DBObject with INotify
        //private IDBObjectDaoFacade _dbObjects = new DBObjectDaoFacadeImpl();
        
        //Implementation of DBObject without INotify
        private IDBObjectDaoFacade_Basic _dbObjects = new DBObjectDaoFacadeImpl_Basic();
        
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public int currentID { get; set; } = 1;

        public SingleItemViewModel()
        {
            LoadObject(currentID);
            NextCommand = new RelayCommand(NextOne);
            PrevCommand = new RelayCommand(PrevOne);
        }

        public ICommand NextCommand { get; set; }
        public ICommand PrevCommand { get; set; }

        public async void LoadObject(int ID)
        {
            //current_Object = _dbObjects.GetDBObjectAsync(ID).Result;
            current_Object = _dbObjects.GetDBObject_BasicAsync(ID).Result;
        }

        /*
        private DBObject _currentObject;
        public DBObject current_Object
        {
            get
            {
                return _currentObject;
            }
            set
            {
                if (value != _currentObject)
                {
                    _currentObject = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("current_Object"));
                }
            }
        }
        */
        
        private DBObject_Basic _currentObject;
        public DBObject_Basic current_Object
        {
            get
            {
                return _currentObject;
            }
            set
            {
                if (value != _currentObject)
                {
                    _currentObject = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("current_Object"));
                }
            }
        } 
                
        private async void NextOne()
        {
            currentID++;
            LoadObject(currentID);
            //MessageBox.Show(current_Object.Name);
        }

        private async void PrevOne()
        {
            currentID--;
            LoadObject(currentID);
        }
    }
}
