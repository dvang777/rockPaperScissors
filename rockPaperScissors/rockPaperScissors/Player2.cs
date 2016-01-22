using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Player2
    {
        public Player2()
        {
            string name = Console.ReadLine();
        }
        public void player2Choice(string name)
        {
            Console.Write(name, "Please Enter object number:");
            string player2choice = Console.ReadLine();
            int number;
            if (Int32.TryParse(player2choice, out number))
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
