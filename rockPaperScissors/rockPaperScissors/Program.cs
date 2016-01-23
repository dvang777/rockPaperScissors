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

            Console.Write("Enter Player 1 name:");
            player1input = Console.ReadLine();
            Console.Write("Enter Player 2 name:");
            player2input = Console.ReadLine();
            WinCondition winCondition = new WinCondition();

            Console.WriteLine("Rock = 0, Paper = 1, Scissors = 2, Lizard = 3, Spock = 4");
            


            winCondition.WinLoss(player1.player1Choice(player1input), player2.player2Choice(player2input), player1input, player2input);

            

        }
    }
}
