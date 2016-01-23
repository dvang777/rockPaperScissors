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
        public int player2Choice(string name)
        {
            Console.WriteLine(name, "Enter Number");
            string player2input = Console.ReadLine();
            int number;
            if (Int32.TryParse(player2input, out number))
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
            return number;
        }
    }
}
