using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Spock
    {
        public enum SPR { scissors, paper, rock, lizard, spock };

        public void SpockWinCondition()
        {
            var value = SPR.spock;
            switch (value)
            {
                case SPR.scissors:
                    Console.WriteLine("I chose Spock, I win.");
                    break;
                case SPR.paper:
                    Console.WriteLine("I chose Spock, I lose.");
                    break;
                case SPR.rock:
                    Console.WriteLine("I chose Spock, I win.");
                    break;
                case SPR.lizard:
                    Console.WriteLine("I chose Spock, I lose.");
                    break;
                default:
                    Console.WriteLine("I chose Spock, we draw.");
                    break;
            }
        }
    }
}
