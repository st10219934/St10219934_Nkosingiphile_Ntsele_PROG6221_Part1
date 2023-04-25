using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St10219934_Nkosingiphile_Ntsele_PROG6221_Part_
{
    internal class RecipeInformation
    {
        static string[] nameOfIngredient;
        static double[] quantity;
        static string[] unitMeasure;
        static int numberOfSteps;
        static string[] Description;

        double[] originalQuantity;
        double scaleFactor;


        static int numberOfIngredients;



        // this is a method for saving the recipe ingredients

        public void recipeDetails()
        {

            Console.WriteLine("How many ingredients do you want to write ");
            numberOfIngredients = Convert.ToInt32(Console.ReadLine() + "\n");

            nameOfIngredient = new string[numberOfIngredients];
            quantity = new double[numberOfIngredients];
            unitMeasure = new string[numberOfIngredients];
            int numberOfSteps;


            for (int g = 0; g < numberOfIngredients; g++)
            {
                Console.Write("\n Write the ingredient name " + (g + 1) + "\n");
                nameOfIngredient[g] = Console.ReadLine();
                Console.Write("Write the quantity \n");
                quantity[g] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Unit measure");
                unitMeasure[g] = Console.ReadLine();
            }
        }
        public void stepDetails()
        {

            Console.WriteLine("\n Number of steps");
            numberOfSteps = Convert.ToInt32(Console.ReadLine());


            Description = new string[numberOfSteps];
            for (int i = 0; i < numberOfSteps; i++)
            {

                Console.WriteLine(" Description for step :" + (i + 1));
                Description[i] = Console.ReadLine();
            }
        }
        public void scaleQuantity()
        {
            Console.WriteLine("How much do you want to scale your quantities");
            scaleFactor = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < quantity.Length; i++)
            {
                Console.WriteLine(quantity[i] *= scaleFactor);
            }
        }

        public void resetQuantity()
        {
            string response;
            Console.Write("Do you really want to reset your quantity \n");
            response = Console.ReadLine();


            if (response.Equals("yes"))
            {
                for (int i = 0; i < quantity.Length; i++)
                {
                    Console.WriteLine(quantity[i] /= scaleFactor);
                }

            }
            else if (response.Equals("no"))
            {
                Console.WriteLine("You did not reset them back");
            }
        }

        public void printRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(":::::::::::The recipe:::::::::: \n" + "\n"
                + "----------Ingredients----------");

            for (int i = 0; i < numberOfIngredients; i++)
            {

                Console.WriteLine(nameOfIngredient[i] + "\t" + originalQuantity[i] + "\t" + unitMeasure[i]);


            }
            Console.WriteLine("\n------------Method------------- ");
            for (int p = 0; p < numberOfSteps; p++)
            {
                Console.WriteLine("Step" + (p + 1) + "\n" + Description[p] + "\n");

            }

        }

        public void clearAllData()
        {
            Console.WriteLine("Cleared");

            Array.Clear(nameOfIngredient, 0, numberOfIngredients);
            Array.Clear(originalQuantity, 0, numberOfSteps);
            Array.Clear(unitMeasure, 0, numberOfIngredients);
            Array.Clear(Description, 0, numberOfIngredients);
        }
    }

}
