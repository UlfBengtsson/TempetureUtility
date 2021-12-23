using System;

namespace TemperatureUtility
{
    public class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 1.8) + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) / 1.8;
            return celsius;
        }

        /*
            Sugestion if you want to do some coding yourself here...
            Add Methods to convert to/from Kelvin
            The temperature conversion formula from Celsius to Kelvin is:
            K = C + 273.15
        */

        /// <summary>
        /// Send in a temperature value and what temperature unit it is and what temperature unit you want to convert it into
        /// </summary>
        /// <param name="from">Temperature value to convert from</param>
        /// <param name="fromUnitType">Temperature unit type of the value to convert from</param>
        /// <param name="toUnitType">Temperature unit type to convert incuming value to</param>
        /// <returns></returns>
        public static double ConvertFromTo(double from, TemperatureUnit fromUnitType, TemperatureUnit toUnitType)
        {
            throw new NotImplementedException();
        }
    }

    public enum TemperatureUnit
    {
        Celsius,
        Fahrenheit,
        Kelvin
    }
}
