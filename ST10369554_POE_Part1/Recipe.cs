﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10369554_POE_Part1
{
    internal class Recipe
    {
        public string[] IngredName { get; set; }
        public double[] IngredQuantity { get; set; }
        public string[] IngredUnit { get; set; }
        public Step[] steps { get; set; }

        
    }
}