using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Services
{
    public class GetObjectPropertiesService
    {
        public Dictionary<string, string> getObjectProperties(IdentifableObject ao)
        {
            Dictionary<string, string>  objectProperties = new Dictionary<string, string>();
            PropertyInfo[] aoProperties = ao.GetType().GetProperties();
            foreach (PropertyInfo property in aoProperties)
            {
                if (property.Name == "Mass")
                {
                    UnitValue<double> Mass = (UnitValue<double>)property.GetValue(ao);
                    objectProperties.Add(property.Name, Mass.Get().ToString());
                    continue;
                }
                if (property.Name == "Size")
                {
                    UnitValue<long> Size = (UnitValue<long>)property.GetValue(ao);
                    objectProperties.Add(property.Name, Size.Get().ToString());
                    continue;
                }
                if (property.Name == "DistanceFromEarth")
                {
                    UnitValue<long> DistanceFromEarth = (UnitValue<long>)property.GetValue(ao);
                    objectProperties.Add(property.Name, DistanceFromEarth.Get().ToString());
                    continue;
                }
                if (property.Name == "DistanceFromPlanet")
                {
                    UnitValue<long> DistanceFromPlanet = (UnitValue<long>)property.GetValue(ao);
                    Console.WriteLine(DistanceFromPlanet.Get().ToString());
                    objectProperties.Add(property.Name, DistanceFromPlanet.Get().ToString());
                    continue;
                }
                if (property.Name == "ApparentMagnitude")
                {
                    UnitValue<double> ApparentMagnitude = (UnitValue<double>)property.GetValue(ao);
                    objectProperties.Add(property.Name, ApparentMagnitude.Get().ToString());
                    continue;
                }
                if (property.Name == "Declination")
                {
                    Declination dec = (Declination)property.GetValue(ao);
                    objectProperties.Add("DeclinationDegrees", dec.Degress.ToString());
                    objectProperties.Add("DeclinationMinutes", dec.Minutes.ToString());
                    objectProperties.Add("DeclinationSeconds", dec.Seconds.ToString());
                    continue;
                }
                if (property.Name == "RightAscension")
                {
                    RightAscension ra = (RightAscension)property.GetValue(ao);
                    objectProperties.Add("RightAscensionHours", ra.Hours.ToString());
                    objectProperties.Add("RightAscensionMinutes", ra.Minutes.ToString());
                    objectProperties.Add("RightAscensionSeconds", ra.Seconds.ToString());
                    continue;
                }
                objectProperties.Add(property.Name, property.GetValue(ao, null).ToString());
            }
            return objectProperties;
        }
    }
}
