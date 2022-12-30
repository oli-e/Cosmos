using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Examples.Model.DAO
{
    public class DBObject : INotifyPropertyChanged
    {
        private int objectID;
        private string objectName;
        private int objectWeight;
        //https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/how-to-implement-property-change-notification?view=netframeworkdesktop-4.8
        //Turns out you can have the implementation without the INotifyPropertyChanged as it can be implemented in ViewModel
        public DBObject()
        {

        }

        public DBObject(int iD, string name, int weight)
        {
            objectID = iD;
            objectName = name;
            objectWeight = weight;
        }

        public int ID
        {
            get
            {
                return objectID;
            }
            set
            {
                objectID = value;
                OnPropertyChanged();
            }
        }
        public string Name {
            get
            {
                return objectName;
            }
            set
            {
                objectName = value;
                OnPropertyChanged();
            }
        }
        public int Weight
        {
            get
            {
                return objectWeight;
            }
            set
            {
                objectWeight = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
