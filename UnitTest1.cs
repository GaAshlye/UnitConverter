using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Controllers;
using UnitConverter.Models;

namespace UnitConverterTest
{
    public class UnitConverterTest
    {
        private HomeController controller = new HomeController();

        [Fact]
        public void TestKelvinToCelsius()
        {
            UnitConverterViewModel op = new UnitConverterViewModel();
            op.InputValue = 14;
            op.Operator = "Kelvin To Celsius";
            op.Result = 0; 

            ViewResult vr = (ViewResult)controller.Conversion(op);
            UnitConverterViewModel model = (UnitConverterViewModel)vr.Model;

            Assert.Equal(-259.15, model.Result);
        }

        [Fact]
        public void TestKelvinToFahrenheit()
        {
            UnitConverterViewModel op = new UnitConverterViewModel();
            op.InputValue = 0;
            op.Operator = "Kelvin To Fahrenheit";
            op.Result = 0; 

            ViewResult vr = (ViewResult)controller.Conversion(op);
            UnitConverterViewModel model = (UnitConverterViewModel)vr.Model;

            Assert.Equal(-459.67, model.Result);
        }

        [Fact]
        public void TestFahrenheitToCelsius()
        {
            UnitConverterViewModel op = new UnitConverterViewModel();
            op.InputValue = 32;
            op.Operator = "Fahrenheit to Celsius";
            op.Result = 0; 

            ViewResult vr = (ViewResult)controller.Conversion(op);
            UnitConverterViewModel model = (UnitConverterViewModel)vr.Model;

            Assert.Equal(0, model.Result);
        }

        [Fact]
        public void TestFahrenheitToKelvin()
        {
            UnitConverterViewModel op = new UnitConverterViewModel();
            op.InputValue = 60;
            op.Operator = "Fahrenheit to Kelvin";
            op.Result = 0; 

            ViewResult vr = (ViewResult)controller.Conversion(op);
            UnitConverterViewModel model = (UnitConverterViewModel)vr.Model;

            Assert.Equal(288.71, Math.Round(model.Result, 2));
        }

        [Fact]
        public void TestCelsiusToFahrenheit()
        {
            UnitConverterViewModel op = new UnitConverterViewModel();
            op.InputValue = 0;
            op.Operator = "Celsius to Fahrenheit";
            op.Result = 0; 

            ViewResult vr = (ViewResult)controller.Conversion(op);
            UnitConverterViewModel model = (UnitConverterViewModel)vr.Model;

            Assert.Equal(32, model.Result);
        }

        [Fact]
        public void TestCelsiusToKelvin()
        {
            UnitConverterViewModel op = new UnitConverterViewModel();
            op.InputValue = 0;
            op.Operator = "Celsius to Kelvin";
            op.Result = 0; 

            ViewResult vr = (ViewResult)controller.Conversion(op);
            UnitConverterViewModel model = (UnitConverterViewModel)vr.Model;

            Assert.Equal(273.15, model.Result);
        }
    }
    
}
