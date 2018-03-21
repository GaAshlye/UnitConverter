using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;

namespace UnitConverter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Convert()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Conversion(UnitConverterViewModel operation)
         {
            
         switch(operation.Operator)
            {
                case "Kelvin To Celsius":
                    operation.Result = operation.InputValue - 273.15; 
                    break;
                case "Kelvin To Fahrenheit":
                    operation.Result = ((operation.InputValue * (9/5)) - 459.67);
                    break;
                case "Celsius to Kelvin":
                    operation.Result = operation.InputValue + 273.15; 
                    break;
                case "Fahrenheit to Kelvin": 
                    operation.Result = ((operation.InputValue + 459.67) * (0.55555556)); 
                    break;
                case "Celsius to Fahrenheit":
                    operation.Result = (operation.InputValue * (9/5)) + 32;
                    break;
                case "Fahrenheit to Celsius":
                    operation.Result = (operation.InputValue - 32) * (5/9); 
                    break;
                case "default":
                    Console.WriteLine("Please enter again");
                    break;

            }
            return View(operation);
            }

    }
}
