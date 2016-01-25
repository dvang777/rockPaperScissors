using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{

    public class Computer
    {
        Random rng = new Random();
        public int GetRandomInt(int min, int max)
        {
            int rand = rng.Next(min, max);
            switch (rand)
            {
                case 0:
                    Console.WriteLine("CPU chose Rock");
                    return rand;
                case 1:
                    Console.WriteLine("CPU chose Paper");
                    return rand;
                case 2:
                    Console.WriteLine("CPU chose Scissors");
                    return rand;
                case 3:
                    Console.WriteLine("CPU chose Lizard");
                    return rand;
                case 4:
                    Console.WriteLine("CPU chose Spock");
                    return rng.Next(min, max);
            }
            return rand;
        }
    }
}