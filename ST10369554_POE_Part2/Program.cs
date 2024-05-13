// See https://aka.ms/new-console-template for more information
using System;
namespace ST10369554_POE_Part2;

class Program
{
    static void Main(string[] args)
    {
        List<Recipe> recipes = new List<Recipe>();

        bool addAnotherRecipe = true;

        while (addAnotherRecipe)
        {
            Console.WriteLine("Enter recipe name:");
            string recipeName = Console.ReadLine();
            Recipe recipe = new Recipe(recipeName);

            Console.WriteLine("Enter number of ingredients");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter Name of ingredient {i + 1}:");
                string names = Console.ReadLine();                
                Console.WriteLine($"Enter Quantity of ingredient {i + 1}:");
                double quantities = double.Parse(Console.ReadLine());                
                Console.WriteLine($"Enter Unit of measurement for ingredient {i + 1}:");
                string units = Console.ReadLine();
                Console.WriteLine($"Enter amount of calories for ingredient {i + 1}:");
                double calories = double.Parse(Console.ReadLine());
                Console.WriteLine($"Enter ingredient food group {i + 1}:");
                string foodGroup = Console.ReadLine();

                recipe.AddIngred(names, quantities, units, calories, foodGroup);

             }

                Console.WriteLine("Enter number of steps");
                int numSteps = int.Parse(Console.ReadLine());

                for (int k = 0; k < numSteps; k++)
                {
                    Console.WriteLine($"Enter step {k + 1}:");
                    string description = Console.ReadLine();
                    recipe.AddStep(description);
                }

                recipes.Add(recipe);

                //subscribe to ExceededRecipeCalories event
                recipe.ExceededRecipeCalories += (recipeName, totalCalories) =>
                {
                    Console.WriteLine($"Warning: Recipe '{recipeName}' has {totalCalories} calories. It exceeds 300 calories");
                };

                //Check if recipe exceeds 300 calories
                recipe.CalorieCheck();

                 Console.WriteLine("\nRecipe entered:");
                 recipe.ShowRecipe();

                 Console.WriteLine("\nEnter scale factor:");
                 double scaleFactor = double.Parse(Console.ReadLine());
                 recipe.ResetQuantities();
                 recipe.RecipeScale(scaleFactor);
                 Console.WriteLine("\nScaled Recipe:");
                 recipe.ShowRecipe();             

                 Console.WriteLine("\nDo you want to reset ingredient quantities to original values?");
                 string resetQuantity = Console.ReadLine().ToLower();

                 if (resetQuantity == "yes")
                 {
                     if (resetQuantity != null)
                     {
                         recipe.ResetQuantities();
                         Console.WriteLine("\nIngredient quantities reset to original values:");
                         recipe.ShowRecipe();
                     }
                     else
                     {
                         Console.WriteLine("Error: Ingredient quantities is null");
                     }
                 }
                 else if (resetQuantity == "no")
                 {
                     //Quantities stays the same
                     Console.WriteLine("\nIngredient quantities remain the same:");
                     recipe.ShowRecipe();
                 }
                 else
                 {
                     Console.WriteLine("Invalid response.");
                 }

                Console.WriteLine("\nDo you want to enter a new recipe? (yes/no)");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() != "yes")
                {
                    addAnotherRecipe = false;
                }
                else
                {
                    Console.Clear();
                }
            }

        //List recipes in alphabetical order
        Console.WriteLine("\nList of Recipe:");
        List<Recipe> sortedRecipes = recipes.OrderBy(r => r.RecipeName).ToList();
        for (int k = 0;k < sortedRecipes.Count;k++)
        {
            Console.WriteLine($"{k + 1}. {sortedRecipes[k].RecipeName}");
        }
        //Choose recipe to display
        Console.WriteLine("\n Enter the recipe number to display");
        int recipeNum = int.Parse(Console.ReadLine());
        if (recipeNum > 0 && recipeNum <= sortedRecipes.Count)
        {
            Console.WriteLine("\nDisplaying recipe:");
            sortedRecipes[recipeNum - 1].ShowRecipe();
        }
        else
        {
            Console.WriteLine("Invalid recipe number.");
        }
        }
    }