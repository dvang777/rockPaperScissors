﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Paper
    {
        public enum SPR { scissors, paper, rock };

        public void winCondition(int rng)
        {
            switch (rng)
            {
                case 0:
                    Console.WriteLine("I chose {0}, I win.", SPR.scissors);
                    break;
                case 1:
                    Console.WriteLine("I chose {0}, we draw.", SPR.paper);
                    break;
                default:
                    Console.WriteLine("I chose {0}, I lose.", SPR.rock);
                    break;
            }
        }
    }
}