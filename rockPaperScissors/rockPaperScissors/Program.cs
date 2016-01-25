using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Program
    {
        private static string player1input;
        private static string player2input;
        static void Main(string[] args)
        {
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissors scissors = new Scissors();
            Lizard lizard = new Lizard();
            Spock spock = new Spock();
            Score score = new Score();
            Computer computer = new Computer();
            UserInput userInput = new UserInput();
            //HowManyPlayers howManyPlayers = new HowManyPlayers();

            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");

            //howManyPlayers.NumberOfPlayers(userInput.player1name, userInput.player2name, computer.GetRandomInt(0,4));

            Console.Write("Enter Player 1 name:");
            userInput.player1name = Console.ReadLine();
            Console.Write("Enter Player 2 name:");
            userInput.player2name = Console.ReadLine();
            WinCondition winCondition = new WinCondition();
            Console.WriteLine("Rock = 0, Paper = 1, Scissors = 2, Lizard = 3, Spock = 4");


            while (score.score1 < 5 || score.score2 < 5 || score.scoreC < 5)
            {

                if (score.score1 == 5)
                {
                    Console.WriteLine(player1input + " Wins!");
                    break;
                }
                else if (score.score2 == 5)
                {
                    Console.WriteLine(player2input + " Wins!");
                    break;
                }
                else
                {
                    winCondition.WinLoss(player1.player1Choice(userInput.player1name), player2.player2Choice(userInput.player2name), userInput.player1name, userInput.player2name, ref score.score1, ref score.score2);
                }

            }


        }
    }
}
