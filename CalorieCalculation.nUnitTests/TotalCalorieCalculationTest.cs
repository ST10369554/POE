using NUnit.Framework;
using ST10369554_POE_Part2;

namespace CalorieCalculation.nUnitTests
{
    public class TotalCalorieCalculationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateTotalCalories_Returns_CorrectTotalCalories()
        {
            //Arrange
            Recipe recipe = new Recipe("Test");
            recipe.AddIngred("Ingredient 1", 50,"g", 30, "Group");
            recipe.AddIngred("Ingredient 2", 2, "l", 10, "Group");
            recipe.AddIngred("Ingredient 3", 123, "ml", 10, "Group");

            //Act
            double totalCalories = recipe.CalculateTotalCalories();

            //Assert
            Assert.AreEqual(50 * 30 + 2 * 10 + 123 * 10, totalCalories);
        }
    }
}