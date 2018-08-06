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
            decimal itemPrice;
            decimal itemPriceCents;
            bool isNumeric = false;
            bool isRunning = true;


            Console.WriteLine("Welcome to the random price shop! Where you never really know what you are going to pay!");



            
            
                // Produces a random number from 1-300
                Random r = new Random();
                itemPrice = r.Next(1, 300);
                Console.WriteLine(itemPrice);
             


                // Do-While ensures that the code is re-run until there is a valid number
                if (isNumeric == false)
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

                }

            }
    }
}
