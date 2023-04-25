using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St10219934_Nkosingiphile_Ntsele_PROG6221_Part_
{
    internal class RecipeInformation
    {

        //declared all the variables for storing the user's input
        static string[] nameOfIngredient;
        static double[] quantity;
        static string[] unitMeasure;
        static int numberOfSteps;
        static string[] Description;
        static double[] originalQuantity;
        static double scaleFactor;

        //declared a variable to hold a number of ingredients
        static int numberOfIngredients;
        
        public void recipeDetails()
        {
            //asking the user on how many ingredients they want to capture
            Console.WriteLine("How many ingredients do you want to write ");
            numberOfIngredients = Convert.ToInt32(Console.ReadLine() + "\n");

            //initializing all the variable on how many times they should store details according to the user 
            nameOfIngredient = new string[numberOfIngredients];
            quantity = new double[numberOfIngredients];
            unitMeasure = new string[numberOfIngredients];
            int numberOfSteps;


            //this for loop is for asking the user for recipe details according to the number of recipes they want
            for (int g = 0; g < numberOfIngredients; g++)
            {
                Console.Write("\n Write the ingredient name " + (g + 1) + "\n");
                nameOfIngredient[g] = Console.ReadLine();
                Console.Write("Write the quantity \n");
                quantity[g] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Unit measure");
                unitMeasure[g] = Console.ReadLine();
            }
            originalQuantity = quantity;//initializing the variable originalQuantity so that we will be able to reset the quantity
        }

        //method for asking the number of steps and capturing the descriptions for the steps
        public void stepDetails()
        {

            //asking the user on how many steps do they wish to write
            Console.WriteLine("\n Number of steps");
            numberOfSteps = Convert.ToInt32(Console.ReadLine());

            //variable for holding the description entered by user
            Description = new string[numberOfSteps];

            //this for loop is for the application to know how many steps to be written by the user
            for (int i = 0; i < numberOfSteps; i++)
            {

                Console.WriteLine(" Description for step :" + (i + 1));
                Description[i] = Console.ReadLine();
            }
        }

        // method for scalling the quantity of all the ingredients
        public void scaleQuantity()
        {
            //asking the user on how much they want to scale their quantities to
            Console.WriteLine("How much do you want to scale your quantities");
            scaleFactor = Convert.ToDouble(Console.ReadLine());

            //this loop is for scalling all the quantities with the number entered by user to scale with
            for (int i = 0; i < quantity.Length; i++)
            {
                //this is where the scalling happen
                //the quantity is multiplied by the number entered by user to scale with
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
