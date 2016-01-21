﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Rock
    {
        public enum SPR {scissors, paper, rock, lizard, spock};

        public void winCondition(int rng)
        {
            switch (rng)
            {
                case 0:
                    Console.WriteLine("I chose {0}, I lose.", SPR.scissors);
                    break;
                case 1:
                    Console.WriteLine("I chose {0}, I win.", SPR.paper);
                    break;
                case 2:
                    Console.WriteLine("I chose {0}, we draw.", SPR.rock);
                    break;
                case 3:
                    Console.WriteLine("I chose {0}, I win.", SPR.lizard);
                    break;
                default:
                    Console.WriteLine("I chose {0}, I lose.", SPR.spock);
                    break;
            }
        }
    }
}