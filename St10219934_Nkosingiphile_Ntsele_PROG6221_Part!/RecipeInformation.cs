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
            Console.WriteLine("How many ingredients do you want to enter in your recipe ");
            numberOfIngredients = Convert.ToInt32(Console.ReadLine() + "\n");

            //initializing all the variable on how many times they should store details according to the user 
            nameOfIngredient = new string[numberOfIngredients];
            quantity = new double[numberOfIngredients];
            unitMeasure = new string[numberOfIngredients];
            int numberOfSteps;


            //this for loop is for asking the user for recipe details according to the number of recipes they want
            for (int g = 0; g < numberOfIngredients; g++)
            {
                Console.Write("\n Enter ingredient  " + (g + 1) + "\n");
                nameOfIngredient[g] = Console.ReadLine();
                Console.Write(" Quantity \n");
                quantity[g] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Unit  measure");
                unitMeasure[g] = Console.ReadLine();
            }
            originalQuantity = quantity;//initializing the variable originalQuantity so that we will be able to reset the quantity
        }

        //method for asking the number of steps and capturing the descriptions for the steps
        public void stepDetails()
        {

            //asking the user on how many steps do they wish to write
            Console.WriteLine("\n How many steps do you want to enter");
            numberOfSteps = Convert.ToInt32(Console.ReadLine());

            //variable for holding the description entered by user
            Description = new string[numberOfSteps];

            //this for loop is for the application to know how many steps to be written by the user
            for (int i = 0; i < numberOfSteps; i++)
            {

                Console.WriteLine(" Description for step no. " + (i + 1));
                Description[i] = Console.ReadLine()+"\n ";
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
                quantity[i] *= scaleFactor;

                Console.WriteLine("You quantity has been scaled by :"+ scaleFactor);
            }
        }

        //method for resetting the quantity back to original 
        public void resetQuantity()
        {
            //declared a variable to ask the user if they are sure about reseting to the original quantities
            string response;

            // asking the user if they are sure about reseting to the original quantities
            Console.Write("Do you really want to reset your quantity (yes/no) \n");
            response = Console.ReadLine();

            //if and else statement if for the decision taken by the user whether they are reseting or not
            if (response.Equals("yes"))
            {
                //for loop for reseting the quantity back to their origin
                for (int i = 0; i < quantity.Length; i++)
                {
                    //this is where the reseting happens
                    //we devide the quantity by the scalefactor to go to the original quantity
                    quantity[i] /= scaleFactor;

                    Console.WriteLine("Your quantity has been reset to the original value \n");
                }

            }
            //if the user decides no to scale
            else if (response.Equals("no"))
            {
                Console.WriteLine("You did not reset them back \n");
            }
        }

        //method for printing the recipe
        public void printRecipe()
        {
                //changing the text color to be different when printing the full recipe
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(":::::::::::The recipe:::::::::: \n" + "\n"
                + "----------Ingredients----------");

            for (int i = 0; i < numberOfIngredients; i++)
            {

                Console.WriteLine(originalQuantity[i]+ "\t"+ unitMeasure[i]+" of "+ nameOfIngredient[i]);

            }
                Console.WriteLine("\n ------------Method------------- ");
            for (int p = 0; p < numberOfSteps; p++)
            {
                Console.WriteLine("Step" + (p + 1) + "\n" + Description[p] );

            }

        }

        //method for clearing all the data if the user wants to enter another recipe
        public void clearAllData()
        {
            //making a variable to ask the user if they are sure about clearing all the data 
            string choice;

            //Asking the user for a choice to clear data or not
               Console.WriteLine("\n Do you really want to clear all the data and enter a new recipe (yes/no)");
               choice = Console.ReadLine();

            //if and else statement for user's choice of clearing data or not
            if (choice.Equals("yes"))
            {
                

                //this will clear all the data stored in the arrays
                Array.Clear(nameOfIngredient, 0, numberOfIngredients);
                Array.Clear(originalQuantity, 0, numberOfIngredients);
                Array.Clear(unitMeasure, 0, numberOfIngredients);
                Array.Clear(Description, 0, numberOfSteps);

                //letting the user know that the data has been cleared
                Console.WriteLine("Cleared");

            }
            else if (choice.Equals("no"))
            {
                //letting theuser know that the data is still captured
                Console.WriteLine("Your data is still captured ");
            }
        }    
    }

}
