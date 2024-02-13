using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class Project4
    {
        static Random random = new Random();
        static string[] choice = { "rock", "paper", "scissors" };
        static void Main(string[] args)
        {
            string compChoice = computerChoice();
            string playerChoice;

            Console.WriteLine("Welcome to rock, paper, scissors!");

            Console.Write("Your choice: ");
            playerChoice = Console.ReadLine().ToLower();
            try
            {
                while (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                {
                    Console.Write("Invalid input! Please check for spelling errors and retry: ");
                    playerChoice = Console.ReadLine().ToLower();
                }

            } catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }

            Console.WriteLine("Computer's choice: " + compChoice);

            if (String.Compare(playerChoice, compChoice) == 0)
            {
                Console.WriteLine("It's a draw!");
                return;
            } else if ((playerChoice == "scissors" && compChoice == "paper") || 
                        (playerChoice == "rock" && compChoice == "scissors") || 
                        (playerChoice == "paper" && compChoice == "rock"))
            {
                Console.WriteLine("You win!");
                return;
            } else
            {
                Console.WriteLine("You lose!");
                return;
            }
        }

        static string computerChoice()
        {
            string compChoice = choice[random.Next(0, choice.Length - 1)];
            return compChoice;
        }
    }
}
