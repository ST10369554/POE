using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10369554_POE_Part2
{
     public class Ingredient
    {
        public string Names { get; set; }
        public double Quantities { get; set; }
        public double OriQuantities { get; set; }
        public string Units { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string names, double quantites, string units, double calories, string foodGroup)
        {
            //Initialize for Ingredient detials
            Names = names;
            Quantities = quantites;
            OriQuantities = quantites;
            Units = units;
            Calories = calories;
            FoodGroup = foodGroup;
        }
    }
}
