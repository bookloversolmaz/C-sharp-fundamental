namespace NumberGuesser;
using System;
//Create a number guessing game.
// a class called Game
// one method called Guess that takes an int and returns a string
// a constructor that takes one int as an argument
// one instance field for holding the secret number
public class Game {
    int gameNumber;
    public Game(int gameNumber) {
        this.gameNumber = gameNumber;
    }

    public string Guess(int playerGuess) {
    // Takes int and returns a string, telling user to guess higher, lower or that they're correct
        if (playerGuess < gameNumber) {
            // Console.WriteLine("higher");
            return "higher";

        }  else if (playerGuess > gameNumber) {
            return "lower";
        } else {
            return "correct-a-reno!!";
        }

        
    }
}
class Program {
    public static void Main(string[] args) {
        Game game = new Game(100);
        game.Guess(10);
        Console.WriteLine("lower");
    }

}