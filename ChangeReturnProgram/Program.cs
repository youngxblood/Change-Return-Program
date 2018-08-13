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
            decimal itemDollarPrice;
            decimal itemCentPrice;
            decimal finalItemPrice;
            bool isNumeric = false;


            Console.WriteLine("Welcome to the random price shop! Where you never really know what you are going to pay!");





            // Produces a random number from 1-300
            var r = new Random();
            itemDollarPrice = r.Next(1, 300);
            var rand = new Random();
            decimal tempCentPrice = new decimal(rand.NextDouble());

            itemCentPrice = Decimal.Round(tempCentPrice, 2, MidpointRounding.AwayFromZero);

            finalItemPrice = itemDollarPrice + itemCentPrice;

            Console.WriteLine(itemDollarPrice);
            Console.WriteLine(itemCentPrice);
            Console.WriteLine(finalItemPrice);


            // isNumeric = boolean to check if the input is valid
            while (isNumeric == false)
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
