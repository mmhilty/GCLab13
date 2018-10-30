using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    class PlayerRock : Player
    {
        public new string playerName = "The Rock";
        //private string roshValue;

        public PlayerRock(int RoshValue)
        {
            roshValue = RoshValue;

        }
        
        public override string GenerateRosh()
        {
            //RoshamboEnum enumValue = (RoshamboEnum)roshValue;
            //return "rock";

            if (roshValue == 3)
            {
                return $"Can you smell what {playerName} is cooking?! Rock beats scissors!";
            }

            else if (roshValue == 1)
            {
                return $"Stop copying me. Tied.";
            }

            else if (roshValue == 2)
            {
                return $"You have beaten {playerName}. Respect. Paper beats rock.";
            }
            else
            {
                return "something went wrong";
            }
            
        }

    }
}
