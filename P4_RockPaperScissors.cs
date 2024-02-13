using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class Project4
    {
        static string[] choice = { "rock", "paper", "scissors", "rock", "paper", "scissors" };

        static void Main(string[] args)
        {
            string compChoice = computerChoice();
            string playerChoice;
            int playerScore = 0, computerScore = 0;
            bool loop = true;

            while (loop)
            {
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

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    return;
                }

                Console.WriteLine("Computer's choice: " + compChoice);

                if (String.Compare(playerChoice, compChoice) == 0)
                {
                    Console.WriteLine("It's a draw!");
                    displayScore(playerScore, computerScore);
                    Console.WriteLine();
                }
                else if ((playerChoice == "scissors" && compChoice == "paper") ||
                            (playerChoice == "rock" && compChoice == "scissors") ||
                            (playerChoice == "paper" && compChoice == "rock"))
                {
                    Console.WriteLine("You win!");
                    playerScore++;
                    displayScore(playerScore, computerScore);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You lose!");
                    computerScore++;
                    displayScore(playerScore, computerScore);
                    Console.WriteLine();
                }

                Console.Write("Type 'e' to exit the game: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char exit = keyInfo.KeyChar;

                if (exit == 'e')
                {
                    loop = false;
                }
            }
        }

        static string computerChoice()
        {
            Random random = new Random();
            string compChoice = choice[random.Next(0, choice.Length - 1)];
            return compChoice;
        }

        static void displayScore(int playerScore, int computerScore)
        {
            Console.WriteLine("Your score: " + playerScore);
            Console.WriteLine("Computer's score: " + computerScore);
        }
    }
}
