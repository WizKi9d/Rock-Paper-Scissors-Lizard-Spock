using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace RockPaperScissors
{
    class MainClass
    {
        public static string getMostUsedMove(int[] mostUsedMove) {

            int highestValue = mostUsedMove.Max();
            int indexHighestValue = mostUsedMove.ToList().IndexOf(highestValue);

            if (indexHighestValue == 0) {
                return "rock";
            } else if (indexHighestValue == 1) {
                return "paper";
            } else if (indexHighestValue == 2) {
                return "scissors";
            } else if (indexHighestValue == 3) {
                return "lizard";
            } else { return "spock"; }
        }

        public static void displayUserWin() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nYou win this round, one point to you!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Main(string[] args)
        {
            // Disable curson highlight whilst the intro shows
            Console.CursorVisible = false;

            Console.WriteLine("\nRock, Paper, Scissors, Lizard, Spock");
            Thread.Sleep(700);
            Console.WriteLine("Made by Alex Wzorek.\n");
            Thread.Sleep(1200);

            string[] choices = new string[5] { "rock", "paper", "scissors", "lizard", "spock" };

            //See if the user wants to continue, continue with while
            do {
                Console.Clear();
                Console.WriteLine("\nI challenge you to rock, paper, scissors. May the best win!\n");
                Thread.Sleep(700);

                // [0] = rock, [1] = paper, [2] = scissors
                int[] mostUsedMove = new int[5] { 0, 0, 0, 0, 0 };

                int playerScore = 0;
                int computerScore = 0;
                int gameLength = 0;

                bool someoneWon = false;

                // Do -  while someone won != true
                do {
                    // Get computer choice random number
                    Random rand = new Random();
                    int computerChoiceNum = rand.Next(0, 5);

                    Console.CursorVisible = true;
                    Console.WriteLine("Rock, Paper, Scissors, Lizard or Spock? (1, 2, 3, 4 or 5)");
                    // Try to get an int, if it's not an int tell the player that they need to try again.
                    try {
                        int playerChoice = Convert.ToInt32(Console.ReadLine());

                        // Checks if the input is out of bounds
                        if (playerChoice > 5) {
                            Console.WriteLine("That wasn't 1, 2, 3, 4 or 5");
                        } else {
                            // Sees if there is a draw
                            if (playerChoice == computerChoiceNum + 1) {
                                // ComputerChoiceNum tells us the position of the move as the user chose the same
                                // So add 2 instead of 1
                                mostUsedMove[computerChoiceNum] += 2;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nWe drew!!");
                                Console.ForegroundColor = ConsoleColor.White;
                              // Otherwise check for user win possibilities
                            } else {
                                if (playerChoice == 1 && computerChoiceNum == 2 || playerChoice == 1 && computerChoiceNum == 3) {
                                    displayUserWin();
                                    playerScore++;
                                } else if (playerChoice == 2 && computerChoiceNum == 0 || playerChoice == 2 && computerChoiceNum == 4) {
                                    displayUserWin();
                                    playerScore++;
                                } else if(playerChoice == 3 && computerChoiceNum == 4 || playerChoice == 3 && computerChoiceNum == 1) {
                                    displayUserWin();
                                    playerScore++;
                                } else if (playerChoice == 4 && computerChoiceNum == 1 || playerChoice == 4 && computerChoiceNum == 4) {
                                    displayUserWin();
                                    playerScore++;
                                } else if(playerChoice == 5 && computerChoiceNum == 0 || playerChoice == 5 && computerChoiceNum == 2) {
                                    displayUserWin();
                                    playerScore++;
                                } else {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nOne point to me!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    computerScore++;
                                    // See if the computer has won
                                    if (computerScore == 3) {
                                        someoneWon = true;
                                    } 
                                }
                                // After all checks display what the computer chose
                                Console.WriteLine("I used {0}", choices[computerChoiceNum] + "\n");
                                // See if the player has won
                                if (playerScore == 3) {
                                    someoneWon = true;
                                } 
                            }
                            // Add one to game length. Diplay how many turns it took later.
                            gameLength++;
                            // Add 1 to the move. Display what move was most used later.
                            mostUsedMove[playerChoice - 1] += 1;
                            mostUsedMove[computerChoiceNum] += 1;
                        }
                    }
                    // Tell the user that they didn't input the correct input
                    catch (Exception) {
                        Console.WriteLine("That's not one of the options! Try again.");
                    }
                } while (someoneWon != true);

                // If playerscore is less than 3 the computer won.
                if (playerScore < 3) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nSorry, I won. Better luck next time!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("It took me only {0} rounds to win!", Convert.ToString(gameLength));
                } else {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\nYOU WON!");
                    Console.WriteLine("Maybe I'll do better next time.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("It took you only {0} rounds to win!",Convert.ToString(gameLength));
                }

                // Most used move
                string mostUsedMoveString = getMostUsedMove(mostUsedMove);
                Console.WriteLine("The most common move was: {0}", mostUsedMoveString);

                // While looks for 'yes'
                Console.WriteLine("\nWould you like to continue playing? ('yes' or 'no')");

            } while (Console.ReadLine() == "yes");
        }
    }
}
