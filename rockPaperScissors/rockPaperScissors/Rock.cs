using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Rock
    {
        int scissors;
        int paper;
        int rock;

        public void winCondition(int scissors, int paper, int rock)
        {
            if (this.rock == this.rock)
            {
                Console.WriteLine("Draw");

            }
            else if (this.rock > this.scissors)
            {
                Console.WriteLine("Victory");
            }
            else if (this.rock < this.paper)
            {
                Console.WriteLine("Loss");
            }
        }
    }
}
