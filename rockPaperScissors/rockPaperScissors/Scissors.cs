using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    
    public class Scissors
    {
        public enum SPR { scissors, paper, rock, lizard, spock };

        public void ScissorsWinCondition()
        {
            var value = SPR.scissors;
            switch (value)
            {
                case SPR.scissors:
                    Console.WriteLine("I chose Scissors, we draw.");
                    break;
                case SPR.paper:
                    Console.WriteLine("I chose Scissors, I win.");
                    break;
                case SPR.rock:
                    Console.WriteLine("I chose Scissors, I lose.");
                    break;
                case SPR.lizard:
                    Console.WriteLine("I chose Scissors, I win.");
                    break;
                default:
                    Console.WriteLine("I chose Scissors, I lose.");
                    break;
            }
        }
    }
}