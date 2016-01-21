using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Rock
    {

        public void winCondition(int value)
        {
            switch (value)
            {
                case 1:
                    Console.WriteLine("Chose Scissors, I win.");
                    break;
                case 2:
                    Console.WriteLine("Chose Paper, I lose.");
                    break;
                default:
                    Console.WriteLine("Chose Rock, we draw.");
                    break;
            }
        }
    }
}
