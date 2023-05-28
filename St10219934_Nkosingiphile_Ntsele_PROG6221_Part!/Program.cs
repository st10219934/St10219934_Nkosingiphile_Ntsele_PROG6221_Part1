using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St10219934_Nkosingiphile_Ntsele_PROG6221_Part_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Changing the color of the text 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;


            //making an object for the external class to b e able to call the methods in it
            RecipeInformation obj = new RecipeInformation();


            //intialized and declared a loop control varaible for the do while loop
            int i = 0;

            //this is the do while loop for prompting the user for options
            do
            {

                // declared a variable to stored the user's input for an option chosen
                int choose;

                //the menu for the user to choose from
                Console.WriteLine("Choose the options below \n" +
                                  "1 to write the recipe \n" +
                                  "2 to scale all the quantities \n" +
                                  "3 to reset the quantities as they were \n" +
                                  "4 to print and see the recipe \n" +
                                  "5 to clear all data and write a new recipe \n");

                //initialized the variable for storing user's option chosen
                choose = Convert.ToInt32(Console.ReadLine());


                // if and else statement for the application to know which number is chosen by user
                if (choose == 1)
                {
                    //calling the method that prompt theuser for recipe details
                    obj.recipeDetails();

                }
                else if (choose == 2)
                {
                    //calling the method that prompt the user if they want to scale the quantity
                    obj.scaleQuantity();
                }
                else if (choose == 3)
                {
                    //calling the method that prompt the user if they want to reset the quantity back to it's origin
                    obj.resetQuantity();
                }
                else if (choose == 4)
                {
                    //calling the method that prints the recipe entered by the user
                    obj.printRecipe();
                }
                else if (choose == 5)
                {
                    //calling the method that prompt the user if they want to clear all the data and write a new recipe
                    obj.clearAllData();
                }
            } while (i <= 4);

        }
    }
 }

