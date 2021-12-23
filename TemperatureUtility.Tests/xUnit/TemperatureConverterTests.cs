using Xunit;
using TemperatureUtility;
using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureUtility.xUnit.Tests
{
    public class TemperatureConverterTests
    {
        /*
            Kelvin      Celsius     Fahrenheit      Comment
          -------------------------------------------------------------------
            0      K    -273.15°C   -459.67 °F      Absolute zero point
            233.15 K    -40°C       -40 °F
            273.15 K    0°C         32 °F
            293.15 K	20°C	    68.0 °F
            310.15 K	37°C    	98.6 °F         Normal body temperature
            373.15 K	100°C   	212.0 °F        Boiling point of water
          --------------------------------------------------------------------
        */

        [Fact]
        public void CelsiusToFahrenheitTest()
        {
            //Arrange
            double celsius = 0;
            double expected = 32;//Fahrenheit

            //Act
            double result = TemperatureConverter.CelsiusToFahrenheit(celsius);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-459.67, -273.15)]
        [InlineData(-40, -40)]
        [InlineData(32, 0)]
        [InlineData(68.0, 20)]
        [InlineData(98.6, 37)]
        [InlineData(212, 100)]
        public void FahrenheitToCelsiusTest(double fahrenheit, double expected)
        {
            //Arrange

            //Act
            double result = TemperatureConverter.FahrenheitToCelsius(fahrenheit);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        

        [Theory]
        [InlineData(0, TemperatureUnit.Kelvin, TemperatureUnit.Celsius, -273.15)]
        [InlineData(310.15, TemperatureUnit.Kelvin, TemperatureUnit.Fahrenheit, 98.6)]
        [InlineData(-40, TemperatureUnit.Celsius, TemperatureUnit.Kelvin, 233.15)]
        [InlineData(0, TemperatureUnit.Celsius, TemperatureUnit.Fahrenheit, 32)]
        [InlineData(68.0, TemperatureUnit.Fahrenheit, TemperatureUnit.Celsius, 20)]
        [InlineData(212.0, TemperatureUnit.Fahrenheit, TemperatureUnit.Kelvin, 373.15)]

        public void ConvertFromToTest(double temperature, TemperatureUnit fromUnitType, TemperatureUnit toUnitType, double expected)
        {
            //Arrange

            //Act
            double result = TemperatureConverter.ConvertFromTo(temperature, fromUnitType, toUnitType);

            //Assert
            Assert.Equal(expected, result, 2);
        }

        /*
        [Fact]
        public void Test()
        {
            //Arrange

            //Act

            //Assert
            Assert.True(false, "This test needs an implementation");
        }
        */
    }
}