using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10369554_POE_Part1
{
     class Recipe
    {
        public string RecipeName { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public List<Step> steps { get; set; }
        public delegate void ExceededRecipeCaloriesEventHandler(string recipeName, double totalCalories);
        public event ExceededRecipeCaloriesEventHandler ExceededRecipeCalories;
        //public double IngredQuantity { get; set; }
       // public string IngredUnit { get; set; }
        //public Step Steps { get; private set; }
        //private int stepCount;

     public Recipe(string recipename)
        {
            //Initailize array for recipe details
            RecipeName = recipename;
             //IngredQuantity = new double[numIngredients];
             //IngredUnit = new string[numIngredients];
             ingredients = new List<Ingredient>();
             steps = new List<Step>();
             //stepCount = 0;
        }
        //add ingredient to recipe
        public void AddIngred(string RecipeName, double quantities, string units, double calories, string foodGroup)
        {
            ingredients.Add(new Ingredient(RecipeName, quantities,units, calories, foodGroup));
        }

        public void AddStep(string description)
        { 
        steps.Add(new Step(description));
        }

        public double CalculateTotalCalories()
        {
            double totalCalories = 0;
            foreach (var  ingredient in ingredients)
            {
                totalCalories += ingredient.Calories * ingredient.Quantities;
            }
            return totalCalories;
        }
        //Display Recipe
        public void ShowRecipe()
        {
            Console.WriteLine($"Recipe: {RecipeName}");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantities} {ingredient.Units} of {ingredient.Names}");
            }
            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }
        }

        //Method checks if recipe has exceeded 300 calories is
        public void CalorieCheck()
        {
            double totalCalories = CalculateTotalCalories();
            if (totalCalories > 300 ) 
            { 
                ExceededRecipeCalories?.Invoke(RecipeName, totalCalories);
            }
        }
        //Method for scaling recipe by factor
        /*public void RecipeScale(double factor)
        {
        for (int i = 0; i < IngredQuantity.Length; i++) 
            {
                IngredQuantity[i] *= factor;
            }
        }*/
        //Method for resetting quantities to original values
        public void ResetQuantities(double[] originalQuantities, double[] IngredQuantity)
        {
            //Reset to original values
            Array.Copy(originalQuantities,IngredQuantity, originalQuantities.Length);
        }
        
        //Clear recipe method
      /* public void ClearRecipe()
        {
            IngredName = new string[0];
            IngredQuantity = new double[0];
            IngredUnit = new string[0];
            Steps = new Step[0];
            stepCount = 0;
        }*/

    }
}
