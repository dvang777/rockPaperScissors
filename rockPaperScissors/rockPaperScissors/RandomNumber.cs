﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class RandomNumber
    {
        Random rng = new Random();
        public int GetRandomInt(int min, int max)
        {
            return rng.Next(min, max);
        }
    }
}
