using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Paper
    {

        public void winCondition(int value)
        {
            if (value == 1)
            {
                Console.WriteLine("Chose Scissors, I lose.");
            }
            else if (value == 2)
            {
                Console.WriteLine("Chose Paper, we draw.");
            }
            else if (value == 3)
            {
                Console.WriteLine("Chose Rock, I win.");
            }
        }

    }
}
