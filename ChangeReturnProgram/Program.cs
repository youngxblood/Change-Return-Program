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
            int userMoney;
            bool isNumeric = false;

            Console.WriteLine("Please enter the cost of an item and correct amount of change will be displayed!");

            // Do-While ensures that the code is re-run until there is a valid number
            do
            {
                
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userMoney))
                {
                    Console.WriteLine("You chose " + userMoney);
                }
                else if (userMoney == 0)
                {
                    Console.WriteLine("Please enter a number!");
                    isNumeric = false;
                }

            } while (isNumeric == false);

        }
    }
}
