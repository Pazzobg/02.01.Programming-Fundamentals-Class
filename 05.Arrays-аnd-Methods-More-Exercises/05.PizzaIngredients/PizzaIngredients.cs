namespace _05.PizzaIngredients
{
    using System;

    public class PizzaIngredients
    {
        public static void Main()
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int maxLength = int.Parse(Console.ReadLine());

            int countIngredients = 0;

            string result = string.Empty;

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == maxLength)
                {
                    result += ingredients[i];
                    result += ", ";
                    countIngredients++;

                    Console.WriteLine($"Adding {ingredients[i]}.");

                    if (countIngredients == 10) break;
                }
            }

            string output = result.Remove(result.Length - 2, 2);

            Console.WriteLine($"Made pizza with total of {countIngredients} ingredients.");
            Console.WriteLine($"The ingredients are: {output}.");
        }
    }
}