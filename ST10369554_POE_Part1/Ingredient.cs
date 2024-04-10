using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10369554_POE_Part1
{
    internal class Ingredient
    {
        //Declaring variables
        public string[] Names { get; set; }
        public double[] Quantities { get; set; }
        public string[] Units { get; set; }

        public Ingredient(int size)
        {
            Names = new string[size];
            Quantities = new double[size];
            Units = new string[size];
        }
        public override string ToString()
        {
            string[]
        }
    }
}
