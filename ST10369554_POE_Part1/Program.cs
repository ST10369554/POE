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
                string unit;

                do
                {
                    unit = Console.ReadLine();
                    if (double.TryParse(unit, out _))
                    {
                        Console.WriteLine("Please enter valid input");
                    }
                    else
                    {
                        recipe.IngredUnit[i] = unit;
                    }

                } while (recipe.IngredUnit[i] == null);


            }
            Console.WriteLine("Enter number of steps");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string description = Console.ReadLine();
                recipe.AddStep(description);
            }

            Console.WriteLine("\nRecipe entered:");
            recipe.displayFullRecipe();

            Console.WriteLine("\nEnter scale factor:");
            double scaleFactor = double.Parse(Console.ReadLine());
            recipe.RecipeScale(scaleFactor);
            Console.WriteLine("\nScaled");
            recipe.displayFullRecipe();

            double[] originalQuantities = { };
            double[] IngredQuantity = { };

            Console.WriteLine("\nDo you want to reset ingredient quantities to original values?");
            string resetQuantity = Console.ReadLine().ToLower();

            if (resetQuantity == "yes")
            {
                if (IngredQuantity != null)
                {
                    recipe.ResetQuantities(originalQuantities, IngredQuantity);
                    Console.WriteLine("\nIngredient quantities reset to original values:");
                    DisplayIngredQuantities(IngredQuantity);
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
                DisplayIngredQuantities(IngredQuantity);
            }
            else
            {
                Console.WriteLine("Invalid response.");
            }
            //Display ingredient quantites function
            static void DisplayIngredQuantities(double[] IngredQuantity)
            {
                if (IngredQuantity != null)
                {
                    for (int i = 0; i < IngredQuantity.Length; i++)
                    {
                        Console.WriteLine($"Ingredient {i + 1}: {IngredQuantity[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Ingredient quantities is null.");
                }
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
                continue;
            }
        }

        
    }
}