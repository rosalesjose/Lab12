using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer : Player
    {
        public override int GenerateRashambo()
        {
            Console.WriteLine("Choose 1 for Rock 2 for Paper 3 for Scissors");
            int Choice = int.Parse(Console.ReadLine());
            return Choice;
        }
    }
}
