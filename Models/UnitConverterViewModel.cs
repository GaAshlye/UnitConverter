using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;

namespace UnitConverter.Models
{
    public class UnitConverterViewModel
    {
        public double Temperature{get; set;}
        public double InputValue{get; set;}              

        public string Operator{get; set;}
        public double Result{get; set;}

    }
}