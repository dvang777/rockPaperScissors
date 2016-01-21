using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Paper
    {
        public enum SPR { scissors, paper, rock, lizard, spock };

        public void PaperWinCondition(string input)
        {
            var value = SPR.paper;
            switch (value)
            {
                case SPR.scissors:
                    Console.WriteLine("I chose Paper, I lose.");
                    break;
                case SPR.paper:
                    Console.WriteLine("I chose Paper, we draw.");
                    break;
                case SPR.rock:
                    Console.WriteLine("I chose Paper, I win.");
                    break;
                case SPR.lizard:
                    Console.WriteLine("I chose Paper, I lose.");
                    break;
                default:
                    Console.WriteLine("I chose Paper, I win.");
                    break;
            }
        }
    }
}