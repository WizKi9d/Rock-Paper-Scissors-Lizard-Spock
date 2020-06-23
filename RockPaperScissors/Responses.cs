using System;
namespace RockPaperScissors
{
    public static class Responses
    {
        public static string UserChoice { get; } = "Rock, Paper, Scissors, Lizard or Spock? (1, 2, 3, 4 or 5)";

        public static string RoundWin { get; } = "\nYou win this round, one point to you!";
        public static string ComputerWin { get; } = "\nOne point to me!";
        public static string Draw { get; } = "\nWe Drew!";

        public static string WrongChoice { get; } = "That wasn't 1, 2, 3, 4 or 5";
        public static string WrongInput { get; } = "That's not one of the options! Try again.";
    }

}
