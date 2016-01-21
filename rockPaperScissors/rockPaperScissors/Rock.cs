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
            if (value == 1)
            {
                Console.WriteLine("Chose Scissors, I win.");
            }
            else if (value == 2)
            {
                Console.WriteLine("Chose Paper, I lose.");
            }
            else if (value == 3)
            {
                Console.WriteLine("Chose Rock, we draw.");
            }
        }
    }
}
