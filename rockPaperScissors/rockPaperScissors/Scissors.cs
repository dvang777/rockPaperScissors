using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    
    public class Scissors
    {
        

    public void winCondition(int value)
        {
            if(value == 1)
            {
                Console.WriteLine("Chose Scissors, we draw.");
            }
            else if(value == 2)
            {
                Console.WriteLine("Chose Paper, I win.");
            }
            else if(value == 3)
            {
                Console.WriteLine("Chose Rock, I lose.");
            }
        }
    }
}