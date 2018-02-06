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

                HumanPlayer p1 = new HumanPlayer();
                
                int Choice = p1.GenerateRashambo();

                if (Choice == 1)
                {
                    Console.WriteLine("Draw");
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("{0} wins!", Name);
                }
                else if (Choice == 3)
                {
                    Console.WriteLine("Rock wins!");
                }
                //Rock r1 = new Rock();

                // r1.GenerateRashambo();

                #endregion

                #region RockDecision
                //if (Choice == 1)
                //{
                //    Console.WriteLine("Tie");
                //}
                //else if (Choice == 2)
                //{
                //    Console.WriteLine("{0} wins!", Name);
                //}
                //else if (Choice == 3)
                //{
                //    Console.WriteLine("Rock wins!");
                //}
                #endregion

            }
            else if (OpponentChoice == 2)
            {
                Console.Clear();

                HumanPlayer p1 = new HumanPlayer();

                int Choice = p1.GenerateRashambo();

                RandomPlayer r1 = new RandomPlayer();
                int Rnum = r1.GenerateRashambo();

                if (Choice == Rnum)
                {
                    Console.WriteLine("Draw");
                }
                else if ((Choice == 1 && Rnum == 2) || (Choice == 2 && Rnum == 1) || (Choice == 3 && Rnum == 2))
                {
                    Console.WriteLine("human wins");
                }
                else
                {
                    Console.WriteLine("AI wins");
                }


                Console.Clear();
                Console.WriteLine("Choose 1 for Rock 2 for Paper 3 for Scissors");
                //int Choice = int.Parse(Console.ReadLine());
                //HumanPlayer p1 = new HumanPlayer(Name, Choice);
            }

        }
    }
}
