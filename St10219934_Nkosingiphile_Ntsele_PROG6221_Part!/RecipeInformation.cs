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
       
    }

}
