using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name, int rashvalue) : base(name, rashvalue)
        {
            Name = name;
            RashValue = rashvalue;
        }
    }
}
