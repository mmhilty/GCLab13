using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    class RoshamboApp
    {
        public static int choosePlayer()
        {
            Console.WriteLine("Who do you want to play against? \n" +
                "1. Randy \n" +
                "2. The Rock \n" +
                "3. God \n");
            string playerChoice = Console.ReadLine();
            return Convert.ToInt32(Validation.NumberVal(playerChoice));
        }

        public static int chooseRPS()
        {
            Console.WriteLine("What's your move? \n" +
                "1. Rock \n" +
                "2. Paper \n" +
                "3. Scissors \n");
            string playerChoice = Console.ReadLine();
            return Convert.ToInt32(Validation.NumberVal(playerChoice));
        }

    }
}
