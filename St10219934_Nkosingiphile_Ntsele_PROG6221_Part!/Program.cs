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

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;



            RecipeInformation obj = new RecipeInformation();

            int i = 0;
            do
            {

                int choose;
                Console.WriteLine("Choose the options below \n" +
                                  "1 to write the recipe \n" +
                                  "2 to scale all the quantities \n" +
                                  "3 to reset the quantities as they were \n" +
                                  "4 to print and see the recipe \n" +
                                  "5 to clear all data and write a new recipe ");


                choose = Convert.ToInt32(Console.ReadLine());


                if (choose == 1)
                {
                    obj.recipeDetails();
                    obj.stepDetails();
                }
                else if (choose == 2)
                {
                     obj.scaleQuantity();
                }
                else if (choose == 3)
                {
                    obj.resetQuantity();
                }
                else if (choose == 4)
                {
                    obj.printRecipe();
                }
                else if (choose == 5)
                {
                    obj.clearAllData();
                }
            } while (i <= 5);

        }
    }
 }

