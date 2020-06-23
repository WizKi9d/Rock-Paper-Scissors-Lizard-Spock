using System;
namespace RockPaperScissors
{
    public static class Responses
    {
        public static string UserChoice { get; } = "Rock, Paper, Scissors, Lizard or Spock? (1, 2, 3, 4 or 5)";

        public static string RoundWin { get; } = "\nYou win this round, one point to you!";
        public static string ComputerWinRound { get; } = "\nOne point to me!";
        public static string Draw { get; } = "\nWe Drew!";

        public static string PlayerWin { get; } = "\n\nYOU WON!\n";
        public static string ComputerWin { get; } = "\n\nSorry, I won. Better luck next time!\n";
        public static string ComputerSadMessage { get; } = "Maybe I'll do better next time.\n";

        public static string WrongChoice { get; } = "That wasn't 1, 2, 3, 4 or 5";
        public static string WrongInput { get; } = "That's not one of the options! Try again.";

        public static string ContinueGame { get; } = "\nWould you like to continue playing? ('yes' or 'no')";
    }

}
