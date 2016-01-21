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
            switch (value)
            {
                case 1:
                    Console.WriteLine("Chose Scissors, we draw.");
                    break;
                case 2:
                    Console.WriteLine("Chose Paper, I win.");
                    break;
                default:
                    Console.WriteLine("Chose Rock, I lose.");
                    break;
            }
        }
    }
}