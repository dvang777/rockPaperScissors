using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Paper
    {
        int scissors;
        int paper;
        int rock;

        public void winCondition(int scissors, int paper, int rock)
        {
            if (this.paper == this.paper)
            {
                Console.WriteLine("Draw");

            }
            else if (this.paper > this.rock)
            {
                Console.WriteLine("Victory");
            }
            else if (this.paper < this.scissors)
            {
                Console.WriteLine("Loss");
            }
        }

    }
}
