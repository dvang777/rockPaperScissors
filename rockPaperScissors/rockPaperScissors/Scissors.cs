using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    
    public class Scissors
    {
        int scissors;
        int paper;
        int rock;

    public void winCondition()
        {
            if (this.scissors == this.scissors)
            {
                Console.WriteLine("Draw");

            }
            else if (this.scissors > this.paper)
            {
                Console.WriteLine("Victory");
            }
            else if(this.scissors <this.rock)
            {
                Console.WriteLine("Loss");
            }
        }
    }
}