using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10369554_POE_Part1
{
     class Ingredient
    {
        public string Names { get; set; }
        public double Quantities { get; set; }
        public string Units { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }


        public Ingredient(string names, double quantites, string units, double calories, string foodGroup)
        {
            //Initialize for Ingredient detials
            Names = names;
            Quantities = quantites;
            Units = units;
            Calories = calories;
            FoodGroup = foodGroup;
        }
        /*Override ToString method to display Ingredient details
        public override string ToString()
        {
            string[] ingredients = new string[Names.Length];
            for (int i = 0; i < Names.Length; i++) 
            {
                ingredients[i] = $"{Quantities[i]} {Units[i]} of {Names[i]}";
            }
            return string.Join(", ", ingredients);
        }*/
    }
}
