using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10369554_POE_Part1
{
    internal class Ingredient
    {
        public string[] Names { get; set; }
        public double[] Quantities { get; set; }
        public string[] Units { get; set; }

        public Ingredient(int size)
        {
            //Initialize arrays for Ingredient detials
            Names = new string[size];
            Quantities = new double[size];
            Units = new string[size];
        }
        //Overrise ToString method to display Ingredient details
        public override string ToString()
        {
            string[] ingredients = new string[Names.Length];
            for (int i = 0; i < Names.Length; i++) 
            {
                ingredients[i] = $"{Quantities[i]} {Units[i]} of {Names[i]}";
            }
            return string.Join(", ", ingredients);
        }
    }
}
