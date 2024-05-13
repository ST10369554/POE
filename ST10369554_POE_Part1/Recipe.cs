using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10369554_POE_Part1
{
     class Recipe
    {
        public string IngredName { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public List<Step> steps { get; set; }
        public delegate void ExceededRecipeCaloriesEventHandler(string recipeName, double totalCalories);
        public event ExceededRecipeCaloriesEventHandler ExceededRecipeCalories;
        //public double IngredQuantity { get; set; }
       // public string IngredUnit { get; set; }
        //public Step Steps { get; private set; }
        //private int stepCount;

     public Recipe(string ingredname)
        {
            //Initailize array for recipe details
            IngredName = ingredname;
             //IngredQuantity = new double[numIngredients];
             //IngredUnit = new string[numIngredients];
             ingredients = new List<Ingredient>();
             steps = new List<Step>();
             //stepCount = 0;
        }
        //add ingredient to recipe
        public void AddIngred(string ingredName, double quantities, string units, double calories, string foodGroup)
        {
            ingredients.Add(new Ingredient(ingredName, quantities,units, calories, foodGroup));
        }

        public void AddStep(string description)
        { 
        steps.Add(new Step(description));
        }
        //Displaying Recipe method
        public void displayFullRecipe()
        {
            Console.WriteLine("Ingredients");
            for (int i = 0; i < IngredName.Length; i++)
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
        public void ResetQuantities(double[] originalQuantities, double[] IngredQuantity)
        {
            //Reset to original values
            Array.Copy(originalQuantities,IngredQuantity, originalQuantities.Length);
        }
        
        //Clear recipe method
        public void ClearRecipe()
        {
            IngredName = new string[0];
            IngredQuantity = new double[0];
            IngredUnit = new string[0];
            Steps = new Step[0];
            stepCount = 0;
        }

    }
}
