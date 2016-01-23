using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class WinCondition
    {
        public void WinLoss(int player1choice, int player2choice, string name1, string name2)
        {
            int winLoss;
            winLoss = (5 + player1choice - player2choice) % 5;
            switch (winLoss)
            {
                case 1:
                    Console.WriteLine(name1 + " wins!");
                    break;
                case 2:
                    Console.WriteLine(name2 + " wins!");
                    break;
                case 3:
                    Console.WriteLine(name1 + " wins!");
                    break;
                case 4:
                    Console.WriteLine(name2 + " wins!");
                    break;
                default:
                    Console.WriteLine("It's a draw.");
                    break;

            }

        }
    }
}
