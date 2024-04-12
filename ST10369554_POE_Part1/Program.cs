// See https://aka.ms/new-console-template for more information
using System;
namespace ST10369554_POE_Part1;

class Program
{ 
    static void Main(string[] args)
    {
        bool addAnotherRecipe = true;

        while (addAnotherRecipe)
        {
            Console.WriteLine("Enter number of ingredients");
        int numIngredients = int.Parse(Console.ReadLine());

        Recipe recipe = new Recipe(numIngredients);

        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine($"Enter Name of ingredient {i + 1}:");
            recipe.IngredName[i] = Console.ReadLine();
            Console.WriteLine($"Enter Quantity of ingredient {i + 1}:");
            recipe.IngredQuantity[i] = double.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Unit of measurement for ingredient {i + 1}:");
            recipe.IngredUnit[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter number of steps");
        int numSteps = int.Parse(Console.ReadLine());

        for (int i = 0;i < numSteps; i++) 
        {
        Console.WriteLine($"Enter step {i + 1}:");
            string description = Console.ReadLine();
            recipe.AddStep(description);
        }

        Console.WriteLine("\nRecipe entered:");
        recipe.displayFullRecipe();

        Console.WriteLine("\nScale recipe to:");
        Console.WriteLine("1. Half");
        Console.WriteLine("2. Double");
        Console.WriteLine("3. Triple");
        int scaleOptions = int.Parse(Console.ReadLine());

        switch (scaleOptions) 
        {
            case 1:
                recipe.RecipeScale(0.5);
                break;
            case 2:
                recipe.RecipeScale(2);
                break;
            case 3:
                recipe.RecipeScale(3);
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
        Console.WriteLine("\nScaled");
        recipe.displayFullRecipe();

       

            recipe.ClearRecipe();

            Console.WriteLine("\nDo you want to enter a new recipe? (yes/no)");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() != "yes")
            {
                addAnotherRecipe = false;
            }
        }

        
    }
}