using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RandomPlayer : Player
    {
        Random r = new Random();

        public override int GenerateRashambo()
        {
            int num = r.Next(1, 3);
            return num;
        }
    }
}
