using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    class GodPlayer : Player
    {
        // I always win 

        public new string playerName = "God";
        //private string roshValue;

        public GodPlayer(int RoshValue)
        {
            roshValue = RoshValue;
        }

        public override string GenerateRosh()
        {
            RoshamboEnum playerValue = (RoshamboEnum)roshValue;

            if (roshValue == 1)
            {
                RoshamboEnum enumValue = (RoshamboEnum)2;
                return $"{playerName} wins! {enumValue.ToString()} beats {playerValue.ToString()}";
            }
            else if (roshValue == 2)
            {
                RoshamboEnum enumValue = (RoshamboEnum)3;
                return $"{playerName} wins! {enumValue.ToString()} beats {playerValue.ToString()}";                
            }
            else
            {
                RoshamboEnum enumValue = (RoshamboEnum)1;
                return $"{playerName} wins! {enumValue.ToString()} beats {playerValue.ToString()}";
            }
        }            

    }
}
