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
        //public override int generaterashambo()
        //{
        //    return 1;
        //}

        public Rock(int rashvalue) : base(rashvalue)
        {
            RashValue = 1;
        }
    }
}
