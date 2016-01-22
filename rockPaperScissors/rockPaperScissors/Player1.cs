using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Player1
    {
        public Player1()
        {
            string name;
        }

        public void player1Choice()
        {
            Console.Write("Enter object number:");
            string player1choice = Console.ReadLine();
            int number;
            if (Int32.TryParse(player1choice, out number))
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Rock");
                        break;
                    case 1:
                        Console.WriteLine("Paper");
                        break;
                    case 2:
                        Console.WriteLine("Scissors");
                        break;
                    case 3:
                        Console.WriteLine("Lizard");
                        break;
                    default:
                        Console.WriteLine("Spock");
                        break;
                }

            }
        }
    }
}
