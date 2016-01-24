using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class UserInput
    {
        string player1name = Console.ReadLine();
        string player2name = Console.ReadLine();
        public string player1()
        {
            return player1name;
        }
        public string player2()
        {
            return player2name;
        }
    }
}