using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock, Paper, Scissors";

            Console.WriteLine("Please enter your name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("\nHello, {0}.\nPress 1 to play against rock. Or press 2 to play against the computer.", Name);
            int OpponentChoice = int.Parse(Console.ReadLine());

            if (OpponentChoice == 1)
            {                
                #region GetInput
                Console.Clear();
                Console.WriteLine("Choose 1 for Rock 2 for Paper 3 for Scissors");
                int Choice = int.Parse(Console.ReadLine());
                
                HumanPlayer p1 = new HumanPlayer(Name, Choice);

                Rock r1 = new Rock(1);
                #endregion
                
                if (Choice  == 1)
                {
                    Console.WriteLine("Tie");
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("{0} wins!", Name);
                }
                else if (Choice == 3)
                {
                    Console.WriteLine("Rock wins!");
                }
                
                        
                

            }
            else if (OpponentChoice == 2)
            {
                //play random
                Console.Clear();
                Console.WriteLine("Choose 1 for Rock 2 for Paper 3 for Scissors");
                int Choice = int.Parse(Console.ReadLine());
                HumanPlayer p1 = new HumanPlayer(Name, Choice);
            }




        }
    }
}
