namespace CSharp.Games;
using System;

class ScrabbleScore {
    // Holds points dict of points for each letter. key is letter, value is point.
    // Instead of creating a dict of 26 pairs, perhaps create a dict with multiple keys and a single value
    public static Dictionary letterPoints = new Dictionary
    {
        { 'A', 1 }, { 'E', 1 }, { 'I', 1 }, { 'O', 1 }, { 'U', 1 },
        { 'L', 1 }, { 'N', 1 }, { 'S', 1 }, { 'T', 1 }, { 'R', 1 },
        { 'D', 2 }, { 'G', 2 },
        { 'B', 3 }, { 'C', 3 }, { 'M', 3 }, { 'P', 3 },
        { 'F', 4 }, { 'H', 4 }, { 'V', 4 }, { 'W', 4 }, { 'Y', 4 },
        { 'K', 5 },
        { 'J', 8 }, { 'X', 8 },
        { 'Q', 10 }, { 'Z', 10 }
    };
    
    // Method takes a string and returns score for score for each as an int
    // the program needs to iterate through a string, look up every letter, find its value and add all of those values together to return a score.
    public static int Calculate(string ScrabbleScoreWord) {
        // Convert string into a list, each item comprised of a single letter, something like pYTHON'S SPLIT METHOD

    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
