using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St10219934_Nkosingiphile_Ntsele_PROG6221_Part_
{
    internal class RecipeInformation
    {

        static List<string> namesOfTheRecipe = new List<string>();
        static List<string> ingredients = new List<string>();
        static List<int> colories = new List<int>();
        static List<string> steps = new List<string>();
        static Dictionary<string, Dictionary<int, string>> storeRecipes = new Dictionary<string, Dictionary<int, string>>();
        static Dictionary<string, Dictionary<int, string>> storeSteps = new Dictionary<string, Dictionary<int, string>>();
        int incr;

        static double[] quantity;
        static string[] unitMeasure;
        static string[] foodGroup;
        static double[] originalQuantity;
        static double scaleFactor;
        static double[] scaledQuantity;

        static int numberOfRecipes;
        static int numberOfIngredients;


        // this is a method for saving the recipe ingredients

      

        // method for scalling the quantity of all the ingredients
        public void scaleQuantity()
        {

            // Prompt the user to enter the scale factor for quantity scaling
            Console.WriteLine("How much do you want to scale your quantities");
            scaleFactor = Convert.ToDouble(Console.ReadLine());

            // Create a new array to store the scaled quantities
            scaledQuantity = new double[quantity.Length];


            // Loop through the original quantity array and scale each quantity
            for (int i = 0; i < quantity.Length; i++)
            {
                scaledQuantity[i] = quantity[i] * scaleFactor;
                quantity[i] = scaledQuantity[i];
            }

            // Inform the user that the quantities have been scaled
            Console.WriteLine("Your quantities have been scaled.");

            // Update the original quantity with the scaled quantity.
            quantity = scaledQuantity;
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
      

        //method for clearing all the data if the user wants to enter another recipe
        public void clearAllData()
        {
            Console.WriteLine("Enter the recipe name to delete:");
            string recipeName = Console.ReadLine();

            if (storeRecipes.ContainsKey(recipeName))
            {
                storeRecipes.Remove(recipeName);
                storeSteps.Remove(recipeName);

                // Remove the associated ingredients and quantities
                for (int i = ingredients.Count - 1; i >= 0; i--)
                {
                    if (storeRecipes.Values.Any(dict => dict.Values.Any(val => val.Contains(ingredients[i]))))
                    {
                        ingredients.RemoveAt(i);
                        quantity[i] = 0;
                        unitMeasure[i] = string.Empty;
                        foodGroup[i] = string.Empty;
                        colories.RemoveAt(i);
                    }
                }

                Console.WriteLine("Recipe \"" + recipeName + "\" has been cleared.");
            }
            else
            {
                Console.WriteLine("Recipe \"" + recipeName + "\" not found.");
            }
        }
    }    
}


