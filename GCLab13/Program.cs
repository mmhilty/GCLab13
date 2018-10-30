using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game of Rock Paper Scissors!");

            bool killswitch = true;
            while (killswitch)
            {
                int playerChosen = RoshGameplay.choosePlayer();
                int userMove = RoshGameplay.chooseRPS();
                if (playerChosen == 1)
                {
                    PlayerRandom randy = new PlayerRandom(userMove);
                    Console.WriteLine(randy.GenerateRosh());
                }

                else if (playerChosen == 2)
                {
                    PlayerRock rock = new PlayerRock(userMove);
                    Console.WriteLine(rock.GenerateRosh());
                }

                else if (playerChosen == 3)
                {
                    GodPlayer god = new GodPlayer(userMove);
                    Console.WriteLine(god.GenerateRosh());
                }
                else { Console.WriteLine("stuff went wrong"); }

                killswitch = Validation.ContinueIt();
            }
        }

      

}

 
}
