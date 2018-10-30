using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab13
{
    abstract class Player
    {
        protected string playerName;
        protected int roshValue;

        //public string PlayerName { get; }
        //public int RoshValue { get; }

        abstract public string GenerateRosh();
      


    }
}
