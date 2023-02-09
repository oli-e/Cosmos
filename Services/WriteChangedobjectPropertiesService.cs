using Cosmos.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Services
{
    public class WriteChangedobjectPropertiesService
    {
        public void writeChanges(ObservableCollection<CustomDictionaryClass> newProperties, IdentifableObject obj)
        {
            Type objType = obj.GetType();
            System.Diagnostics.Debug.WriteLine(objType);
            foreach (CustomDictionaryClass property in newProperties)
            {
               
            }
        }
    }
}
