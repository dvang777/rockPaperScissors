using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Rock
    {
        public enum SPR {scissors, paper, rock, lizard, spock};

        private void RockWinCondition()
        {
            var value = SPR.rock;
            switch (value)
            {
                case SPR.scissors:
                    Console.WriteLine("I chose Rock, I win.");
                    break;
                case SPR.paper :
                    Console.WriteLine("I chose Rock, I lose.");
                    break;
                case SPR.rock:
                    Console.WriteLine("I chose Rock, we draw.");
                    break;
                case SPR.lizard:
                    Console.WriteLine("I chose Rock, I win.");
                    break;
                default:
                    Console.WriteLine("I chose Rock, I lose.");
                    break;
            }
        }
    }
}