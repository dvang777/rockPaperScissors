using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class WinCondition
    {
        int currentScore1;
        int currentScore2;
        int winLoss;
        public int WinLoss(int player1choice, int computer, string name1, string name2, int player1score, int player2score)
        {

            winLoss = (5 + player1choice - computer) % 5;
            switch (winLoss)
            {
                case 1:
                    Console.WriteLine(name1 + " wins!");
                    player1score++;
                    Console.WriteLine(name1 + " current score is " + player1score);
                    return player1score;
                case 2:
                    Console.WriteLine(name2 + " wins!");
                    player2score++; ;
                    Console.WriteLine(name2 + " current score is " + player2score);
                    return player2score;
                case 3:
                    Console.WriteLine(name1 + " wins!");
                    player1score++;
                    Console.WriteLine(name1 + " current score is " + player1score);
                    return player1score;
                case 4:
                    Console.WriteLine(name2 + " wins!");
                    player2score++;
                    Console.WriteLine(name2 + " current score is " + player2score);
                    return player2score;
                default:
                    Console.WriteLine("It's a draw.");
                    break;

            }
            return (player1score + player2score);
        }
    }
}