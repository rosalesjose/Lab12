using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Rock : Player
    {
        //generaterashambo only rock
        public override int GenerateRashambo()
        {           
            return 1;
        }       
    }
}
