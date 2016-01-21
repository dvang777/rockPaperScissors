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
            switch (value)
            {
                case 1:
                    Console.WriteLine("Chose Scissors, I lose.");
                    break;
                case 2:
                    Console.WriteLine("Chose Paper, we draw.");
                    break;
                default:
                    Console.WriteLine("Chose Rock, I win.");
                    break;
            }
        }

    }
}
