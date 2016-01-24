using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Player1
    {
        public Player1()
        {
        }

        public int player1Choice(string name)
        {
            Console.WriteLine(name, "Enter Number");
            string player1input = Console.ReadLine();
            int number;
            if (Int32.TryParse(player1input, out number))
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Rock");
                        return number;
                    case 1:
                        Console.WriteLine("Paper");
                        return number;
                    case 2:
                        Console.WriteLine("Scissors");
                        return number;
                    case 3:
                        Console.WriteLine("Lizard");
                        return number;
                    case 4:
                        Console.WriteLine("Spock");
                        return number;  
                }
            }
            return number;
        }
    }
}
