using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.ViewModels.SpecificViewModels.MoonViewModels
{
    public class MoonObjectViewModel : BaseViewModel
    {
        private Dictionary<string, string> _properties;
        public Dictionary<string, string> PropertiesDict => _properties;
        private readonly Moon _moonObject;
        public string Name => _moonObject.Name;
        public string Size => _moonObject.Size.Get().ToString();
        public string Mass => _moonObject.Mass.Get().ToString();
        public string DistanceFromEarth => _moonObject.DistanceFromEarth.Get().ToString();
        public string ApparentMagnitude => _moonObject.ApparentMagnitude.Get().ToString();
        public string Declination => _moonObject.Declination.Degress.ToString();
        public string RightAscension => _moonObject.RightAscension.Hours.ToString();

        public MoonObjectViewModel(Moon moon)
        {
            _moonObject = moon;
            _properties = new Dictionary<string, string>();

            //Possibly move it to the other class / generalize the functions
            PropertyInfo[] moonProperties = moon.GetType().GetProperties();
            foreach (PropertyInfo property in moonProperties)
            {
                if(property.Name == "Mass")
                {
                    UnitValue<double> Mass = (UnitValue<double>)property.GetValue(moon);
                    _properties.Add(property.Name, Mass.Get().ToString());
                    continue;
                }
                if (property.Name == "Size")
                {
                    UnitValue<long> Size = (UnitValue<long>)property.GetValue(moon);
                    _properties.Add(property.Name, Size.Get().ToString());
                    continue;
                }
                if (property.Name == "DistanceFromEarth")
                {
                    UnitValue<long> DistanceFromEarth = (UnitValue<long>)property.GetValue(moon);
                    _properties.Add(property.Name,DistanceFromEarth.Get().ToString());
                    continue;
                }
                if (property.Name == "DistanceFromPlanet")
                {
                    UnitValue<long> DistanceFromPlanet = (UnitValue<long>)property.GetValue(moon);
                    _properties.Add(property.Name, DistanceFromPlanet.Get().ToString());
                    continue;
                }
                if (property.Name == "ApparentMagnitude")
                {
                    UnitValue<double> ApparentMagnitude = (UnitValue<double>)property.GetValue(moon);
                    _properties.Add(property.Name, ApparentMagnitude.Get().ToString());
                    continue;
                }
                if(property.Name == "Declination")
                {
                    Declination dec = (Declination)property.GetValue(moon);
                    _properties.Add("DeclinationDegrees", dec.Degress.ToString());
                    _properties.Add("DeclinationMinutes", dec.Minutes.ToString());
                    _properties.Add("DeclinationSeconds", dec.Seconds.ToString());
                    continue;
                }
                if (property.Name == "RightAscension")
                {
                    RightAscension ra = (RightAscension)property.GetValue(moon);
                    _properties.Add("RightAscensionHours", ra.Hours.ToString());
                    _properties.Add("RightAscensionMinutes", ra.Minutes.ToString());
                    _properties.Add("RightAscensionSeconds", ra.Seconds.ToString());
                    continue;
                }
                _properties.Add(property.Name, property.GetValue(moon,null).ToString());
            }
        }
    }
}
