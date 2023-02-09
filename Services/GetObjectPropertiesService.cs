using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Services
{
    public class GetObjectPropertiesService
    {
        public ObservableCollection<CustomDictionaryClass> getObjectProperties(IdentifableObject ao)
        {
            ObservableCollection<CustomDictionaryClass> objectProperties = new ObservableCollection<CustomDictionaryClass>();
            PropertyInfo[] aoProperties = ao.GetType().GetProperties();
            foreach (PropertyInfo property in aoProperties)
            {
                if (property.Name == "Name" || property.Name == "Type")
                {
                    objectProperties.Add(new CustomDictionaryClass { Key = property.Name, Value = property.GetValue(ao, null).ToString() });
                    continue;
                }
                if (property.Name == "Mass")
                {
                    UnitValue<double> Mass = (UnitValue<double>)property.GetValue(ao);
                    objectProperties.Add(new CustomDictionaryClass { Key = property.Name, Value = Mass.Get().ToString()});
                    continue;
                }
                if (property.Name == "Size")
                {
                    UnitValue<long> Size = (UnitValue<long>)property.GetValue(ao);
                    objectProperties.Add(new CustomDictionaryClass { Key = property.Name, Value = Size.Get().ToString()});
                    continue;
                }
                if (property.Name == "DistanceFromEarth")
                {
                    UnitValue<long> DistanceFromEarth = (UnitValue<long>)property.GetValue(ao);
                    objectProperties.Add(new CustomDictionaryClass { Key = property.Name, Value = DistanceFromEarth.Get().ToString()});
                    continue;
                }
                if (property.Name == "DistanceFromPlanet")
                {
                    UnitValue<long> DistanceFromPlanet = (UnitValue<long>)property.GetValue(ao);
                    Console.WriteLine(DistanceFromPlanet.Get().ToString());
                    objectProperties.Add(new CustomDictionaryClass { Key = property.Name, Value = DistanceFromPlanet.Get().ToString() });
                    continue;
                }
                if (property.Name == "ApparentMagnitude")
                {
                    UnitValue<double> ApparentMagnitude = (UnitValue<double>)property.GetValue(ao);
                    objectProperties.Add(new CustomDictionaryClass { Key = property.Name, Value = ApparentMagnitude.Get().ToString() });
                    continue;
                }
                if (property.Name == "Declination")
                {
                    Declination dec = (Declination)property.GetValue(ao);
                    objectProperties.Add(new CustomDictionaryClass { Key = "DeclinationDegrees", Value = dec.Degress.ToString()});
                    objectProperties.Add(new CustomDictionaryClass { Key = "DeclinationMinutes", Value = dec.Minutes.ToString()});
                    objectProperties.Add(new CustomDictionaryClass { Key = "DeclinationSeconds", Value = dec.Seconds.ToString()});
                    continue;
                }
                if (property.Name == "RightAscension")
                {
                    RightAscension ra = (RightAscension)property.GetValue(ao);
                    objectProperties.Add(new CustomDictionaryClass { Key = "RightAscensionHours", Value = ra.Hours.ToString()});
                    objectProperties.Add(new CustomDictionaryClass { Key = "RightAscensionMinutes", Value = ra.Minutes.ToString()});
                    objectProperties.Add(new CustomDictionaryClass { Key = "RightAscensionSeconds", Value = ra.Seconds.ToString()});
                    continue;
                }
                if (property.Name == "Id")
                {
                    continue;
                }
                //objectProperties.Add(new CustomDictionaryClass { Key = property.Name, Value = property.GetValue(ao, null).ToString()});
            }
            return objectProperties;
        }
    }
}
