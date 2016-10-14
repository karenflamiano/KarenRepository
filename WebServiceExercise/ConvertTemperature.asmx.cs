using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceExercise
{
    /// <summary>
    /// Summary description for ConvertTemperature
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ConvertTemperature : System.Web.Services.WebService
    {
        [WebMethod]
        public double CelciusToFahrenheit(double celcius)
        {
            double fahrenheit = celcius * 1.8 + 32;
            return fahrenheit;
        }

        [WebMethod]
        public double CelciusToKelvin(double celcius)
        {
            double kelvin = celcius + 273.15;
            return kelvin;
        }

        [WebMethod]
        public double FahrenheitToCelcius(double fahrenheit)
        {
            double celcius = (fahrenheit - 32) * 0.55555555555;
            return celcius;
        }

        [WebMethod]
        public double FahrenheitToKelvin(double fahrenheit)
        {
            double kelvin = (fahrenheit + 459.67) * 0.55555555555;
            return kelvin;
        }

        [WebMethod]
        public double KelvinToCelcius(double kelvin)
        {
            double celcius = (kelvin - 273.15);
            return celcius;
        }

        [WebMethod]
        public double KelvinToFahrenheit(double kelvin)
        {
            double fahrenheit = kelvin * 1.8 - 459.67;
            return fahrenheit;
        }
    }
}
