using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.ObjectViewModels
{
    //a class for all of the "*ObjectViewModel" to inherit (type generalization)
    //Translates a Various DB OBjects to a commong object
    public class CommonObjectViewModel
    {
        private Dictionary<string, string> _objectProperties; 
        public Dictionary<string, string> ObjectProperties
        {
            get { return _objectProperties; }
            set { _objectProperties = value; }
        }

        public CommonObjectViewModel(AstronomicalObject ao)
        {
            _objectProperties = new Dictionary<string, string>();
            PropertyInfo[] aoProperties = ao.GetType().GetProperties();
            foreach (PropertyInfo property in aoProperties)
            {
                if (property.Name == "Mass")
                {
                    UnitValue<double> Mass = (UnitValue<double>)property.GetValue(ao);
                    _objectProperties.Add(property.Name, Mass.Get().ToString());
                    continue;
                }
                if (property.Name == "Size")
                {
                    UnitValue<long> Size = (UnitValue<long>)property.GetValue(ao);
                    _objectProperties.Add(property.Name, Size.Get().ToString());
                    continue;
                }
                if (property.Name == "DistanceFromEarth")
                {
                    UnitValue<long> DistanceFromEarth = (UnitValue<long>)property.GetValue(ao);
                    _objectProperties.Add(property.Name, DistanceFromEarth.Get().ToString());
                    continue;
                }
                if (property.Name == "DistanceFromPlanet")
                {
                    UnitValue<long> DistanceFromPlanet = (UnitValue<long>)property.GetValue(ao);
                    Console.WriteLine(DistanceFromPlanet.Get().ToString());
                    _objectProperties.Add(property.Name, DistanceFromPlanet.Get().ToString());
                    continue;
                }
                if (property.Name == "ApparentMagnitude")
                {
                    UnitValue<double> ApparentMagnitude = (UnitValue<double>)property.GetValue(ao);
                    _objectProperties.Add(property.Name, ApparentMagnitude.Get().ToString());
                    continue;
                }
                if (property.Name == "Declination")
                {
                    Declination dec = (Declination)property.GetValue(ao);
                    _objectProperties.Add("DeclinationDegrees", dec.Degress.ToString());
                    _objectProperties.Add("DeclinationMinutes", dec.Minutes.ToString());
                    _objectProperties.Add("DeclinationSeconds", dec.Seconds.ToString());
                    continue;
                }
                if (property.Name == "RightAscension")
                {
                    RightAscension ra = (RightAscension)property.GetValue(ao);
                    _objectProperties.Add("RightAscensionHours", ra.Hours.ToString());
                    _objectProperties.Add("RightAscensionMinutes", ra.Minutes.ToString());
                    _objectProperties.Add("RightAscensionSeconds", ra.Seconds.ToString());
                    continue;
                }
                _objectProperties.Add(property.Name, property.GetValue(ao, null).ToString());
            }
        }
    }
}
