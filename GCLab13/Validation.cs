using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GCLab13
{
    class Validation
    {
        public static double NumberVal(string numberString)
        {
            string NumberString = numberString;
            double NumberDouble;

            while (true)
            {
                if (double.TryParse(NumberString, out NumberDouble) && (1 <= NumberDouble) &&( NumberDouble <= 3))
                {
                    return NumberDouble;
                }

                else
                {
                    Console.WriteLine("Invalid input. Please make sure your input is a whole number and is a choice on the list.\n" +
                        "Please try again");
                }

                NumberString = Console.ReadLine();

            }
        }

        public static string letterVal(string inputstring)
        {
            string InputString = inputstring;

            while (true)
            {
                if (Regex.IsMatch(InputString.ToLower(), @"^[aeiou]") && !(Regex.IsMatch(InputString, @"[0-9]")))
                {
                    return (InputString);
                }

                else
                {
                    Console.WriteLine("Invalid Input. Please make sure your entry has no numbers in it.");

                }

                InputString = Console.ReadLine();
            }

        }

        public static bool ContinueIt()
        {
            
            Console.WriteLine("Would you like to go again? Y/N");

            while (true)
            {
                string continuechoice = Console.ReadLine();
                if (continuechoice.ToLower() == "y")
                { return true; }
                if (continuechoice.ToLower() == "n")
                { return false; }
                else
                {
                    Console.WriteLine("Well do you want to continue or not?");
                }
        }

        }

    }
}
