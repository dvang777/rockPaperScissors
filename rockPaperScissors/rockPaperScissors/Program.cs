using System;
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
            Rock rock = new Rock();
            Scissors scissors = new Scissors();
            Paper paper = new Paper();
            Lizard lizard = new Lizard();
            Spock spock = new Spock();
            Players players = new Players();
            string input = Console.ReadLine();

            Console.Write("Enter Name:");

            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");

            Console.Write("Enter Rock, Paper, Scissors, Lizard or Spock");
            Console.ReadLine();

            rock.RockWinCondition(input);
            //scissors.ScissorsWinCondition(input);
            //paper.PaperWinCondition(input);
            //lizard.LizardWinCondition(input);
            //spock.SpockWinCondition(input);


        }
    }
}
