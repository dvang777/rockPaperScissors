using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    
    public class Scissors : CheckSelection
    {
        string playerChoice = "Scissors";
        int scissors = 2;

        public void WinLoss(int player1choice, int player2choice)
        {
            int winLoss;

            winLoss = (5 + player1choice - player2choice) % 5;
            switch (winLoss)
            {
                case 1:
                    Console.WriteLine("Rock wins, Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Rock loss, Player 2 wins!");
                    break;
                case 3:
                    Console.WriteLine("Rock wins, Player 1 wins!");
                    break;
                case 4:
                    Console.WriteLine("Rock loss, Player 2 wins!");
                    break;
                default:
                    Console.WriteLine("It's a draw.");
                    break;
            }
        }
    }
}