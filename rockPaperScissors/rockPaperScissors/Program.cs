﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write( "Enter object number:");
            string player2choice = Console.ReadLine();
            int number;
            if(Int32.TryParse(player2choice, out number))
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Rock");
                        break;
                    case 1:
                        Console.WriteLine("Paper");
                        break;
                    default:
                        Console.WriteLine("Scissors");
                        break;

                    
                }
            }
        }
    }
}
