using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    class PlayerRandom : Player
    {

        public new string playerName = "Randy";
        //private string roshValue;

        public PlayerRandom(int RoshValue)
        {
            roshValue = RoshValue;
        }

        private int GenerateRandom()
        {
            Random randomobj = new Random();
            return randomobj.Next(1,4);
        }

        public override string GenerateRosh()
        {
            int randNum = GenerateRandom();

            if (roshValue == 2 && randNum == 3)
            {
                return $"Can you smell what {playerName} is cooking?! Scissors SHRED your paper!";
            }

            else if (roshValue == 1 && randNum == 2)
            {
                return $"Can you smell what {playerName} is cooking?! Paper SMOTHERS your rock.";
            }

            else if (roshValue == 3 && randNum == 1)
            {
                return $"Can you smell what {playerName} is cooking?! Rock SMASHES your scissors.";
            }

            else if (roshValue == randNum)
            {
                return $"Stop copying me. Tied.";
            }
            
            else if (randNum == 2 && roshValue == 3)
            {
                return $"You have beaten {playerName}. Respect. Scissors cut paper.";
            }

            else if (randNum == 1 && roshValue == 2)
            {
                return $"You have beaten {playerName}. Respect. Paper covers rock.";
            }

            else if (randNum == 3 && roshValue == 1)
            {
                return $"You have beaten {playerName}. Respect. Rock breaks scissors.";
            }


            else
            {
                return "something went really wrong";
            }
        }
    }
}
