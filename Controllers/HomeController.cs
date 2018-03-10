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
        //[HttpPost]
        // public IActionResult DoConvert(UnitConverterViewModel operation)
        // {
            
        //     switch(operation.Operator)
        //     {
        //         case "Kelvin":
        //             operation.Result =
        //     }
        //     //return View();
        // }

    }
}
