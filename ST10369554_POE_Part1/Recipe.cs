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
        public Step[] Steps { get; private set; }
        private int stepCount;

     public Recipe(int numIngredients, int maxSteps)
        {
            //Initailize array for recipe details
             IngredName = new string[numIngredients];
             IngredQuantity = new double[numIngredients];
             IngredUnit = new string[numIngredients];
             Steps = new Step[maxSteps];
             stepCount = 0;
        }
        //Number of steps being added
        public void AddStep(string description)
        { 
        if (stepCount < Steps.Length)
            {
                Steps[stepCount] = new Step(description);
                stepCount++;
            }
        else 
            {
                Console.WriteLine("Max number of steps reached.");
            }
        }
        //Displaying Recipe method
        public void displayFullRecipe()
        {
            Console.WriteLine("Ingredients");
            for (int i = 0; 1 < IngredName.Length; i++)
            {
                Console.WriteLine($"{IngredQuantity[i]} {IngredUnit[i]} of {IngredName[i]}");
            }
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }
        //Method for scaling recipe by factor
        public void RecipeScale(double factor)
        {
        for (int i = 0; i < IngredQuantity.Length; i++) 
            {
                IngredQuantity[i] *= factor;
            }
        }
        //Method for resetting quantities to original values
        public void ResetQuantities()
        {
            //Reset to original values
        }
        //Clear recipe method
        public void ClearRecipe()
        {
            IngredName = new string[0];
            IngredQuantity = new double[0];
            IngredUnit = new string[0];
            Steps = new Step[0];
        }

    }
}
