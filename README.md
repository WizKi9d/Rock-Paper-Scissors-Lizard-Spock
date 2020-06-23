# Rock-Paper-Scissors-Lizard-Spock
My version of the game written in C# .Net

The game follows the rules of:
 * Uses 1 (rock), 2 (paper), 3 (scissors), 4 (lizard) and 5 (spock) to choose your move.
 * Uses user input of 'yes' to play another game.
 * Uses || or check for 2 different results in order for the player (you) to win a round.
 * Uses Console.Clear() to make the game cleaner and easier to play.
 * Uses Connsole.CursonVisible() to make sure the cursor highlight is hidden during the start of the game where the start screen opens.
 * Uses Random new Random() so the computer can choose their move.

The game displays the following at the end:
 * The winner.
 * How many turns the game took.
 * Most used move during the game.
 
Added:
 * Enum for choices.
 * Removed the need for Switch when getting the most used move (call: (enum)position)
