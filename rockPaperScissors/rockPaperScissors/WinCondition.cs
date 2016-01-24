using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class WinCondition
    {
        int currentScore1;
        int currentScore2;
        int winLoss;
        public int WinLoss(int player1choice, int player2choice, string name1, string name2, int player1score, int player2score)
        {
            
            winLoss = (5 + player1choice - player2choice) % 5;
            //switch (winLoss)
            if (winLoss == 3 || winLoss == 1)
            {

                Console.WriteLine(name1 + " wins!");
                player1score ++;
                Console.WriteLine(name1 + "'s current score is " + player1score);
                return player1score;

                //return player1score;

            }
            else if (winLoss == 4 || winLoss == 2)
            {
                 
                Console.WriteLine(name2 + " wins!");
                player2score ++;
                Console.WriteLine(name2 + "'s current score is " + player2score);
                return player2score;
                
                //return player2score;
            }
            else
            {
                Console.WriteLine("It's a draw!");
                //return (currentScore1 + currentScore2);
            }
            return (player1score + player2score) ;
            //{
            //    case 1:
            //        Console.WriteLine(name1 + " wins!");
            //        player1score ++;
            //        Console.WriteLine(name1 + " current score is " + player1score);
            //        break;
            //    case 2:
            //        Console.WriteLine(name2 + " wins!");
            //        player2score ++; ;
            //        Console.WriteLine(name2 + " current score is " + player2score);
            //        break;
            //    case 3:
            //        Console.WriteLine(name1 + " wins!");
            //        player1score++;
            //        Console.WriteLine(name1 + " current score is " + player1score);
            //        break;
            //    case 4:
            //        Console.WriteLine(name2 + " wins!");
            //        player2score++;
            //        Console.WriteLine(name2 + " current score is " + player2score);
            //        break;
            //    default:
            //        Console.WriteLine("It's a draw.");
            //        break;

        }

    }
    }
