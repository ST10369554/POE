using System;
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
        public Step[] Steps { get; set; }

     public Recipe(int numIngredients)
        {
            //Storing variables
             IngredName = new string[numIngredients];
             IngredQuantity = new double[numIngredients];
             IngredUnit = new string[numIngredients];
             Steps = new Step[0];
        }
        //Number of steps can be chosen by user
        public void numOfSteps(Step step)
        { 
        Array.Resize(ref Steps, Steps.Length + 1);
            Steps[Steps.Length - 1] = step;
        }
    }
}
