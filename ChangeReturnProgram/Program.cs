using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeReturnProgram
{
    class Program
    {
        static void Main(string[] args)
        {



            // Variable declaration
            string userInput;
            //decimal itemPrice;
            bool isNumeric = false;
            bool isRunning = true;


            Console.WriteLine("Welcome to the random price shop! Where you never really know what you are going to pay!");



            do
            {

                // Creates new random object
                Random itemPrice = new Random(300);
                Console.WriteLine(itemPrice);
                //int itemPrice = itemPrice.Next(300);
             


                // Do-While ensures that the code is re-run until there is a valid number
                do
                {

                    userInput = Console.ReadLine();

                    // Both declaring and assigning 'userMoney' variable within the argument
                    if (decimal.TryParse(userInput, out decimal userMoney))
                    {
                        userMoney = Decimal.Round(userMoney, 2, MidpointRounding.AwayFromZero);
                        Console.WriteLine("You chose " + userMoney);
                    }
                    else if (userMoney == 0)
                    {
                        Console.WriteLine("Please enter a number!");
                        isNumeric = false;
                    }

                } while (isNumeric == false);

            } while (isRunning == true);
            }
    }
}
