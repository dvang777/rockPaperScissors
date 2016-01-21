using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Lizard
    {
        public enum SPR { scissors, paper, rock, lizard, spock };
        public void LizardWinCondition(string input)
        {
            var value = SPR.lizard;
            switch (value)
            {
                case SPR.scissors:
                    Console.WriteLine("I chose Lizard, I lose.");
                    break;
                case SPR.paper:
                    Console.WriteLine("I chose Lizard, I win.");
                    break;
                case SPR.rock:
                    Console.WriteLine("I chose Lizard, I lose.");
                    break;
                case SPR.lizard:
                    Console.WriteLine("I chose Lizard, we draw.");
                    break;
                default:
                    Console.WriteLine("I chose Lizard, I win.");
                    break;
            }
        }
    }
}
