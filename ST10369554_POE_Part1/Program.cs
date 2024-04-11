// See https://aka.ms/new-console-template for more information
using System;
namespace ST10369554_POE_Part1;

class Program
{ 
    static void Main(string[] args)
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
    }
}