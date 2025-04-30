namespace CSharp.DSDicts;
using System;

// Exercise 1: dict of quiz names and their scores
class Quiz {
    internal Dictionary<string, int> scores; // keys = team names, vales are scores
    internal Quiz(Dictionary<string, int> scores) {
        this.scores = scores;
    }
    // add method that adds the team scores to the dict scores
    // then add the new score to the key value pair
    public void Add(string teamName, int newScore) {
        // first find the corresponding team name in the existing dict
        if(scores.ContainsKey(teamName)) {
            scores[teamName] += newScore;
        } else { // if the team doesn't exist, add the entire key value pair to the dict
            scores.Add(teamName, newScore);
        }
    }
    // use key to retreive team's score
    public void State(string teamName) {
        int teamScore = scores[teamName];
        Console.WriteLine(teamScore);
    }
    // use key to change a team's score
    public void Change(string teamName, int newScore) {
        // check that the team name exists!
        if(scores.ContainsKey(teamName)) {
            scores[teamName] = newScore;
        } else { // if the team doesn't exist, add the entire key value pair to the dict
            scores.Add(teamName, newScore);
        }
    }
  
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> scores = new Dictionary<string, int>  { {"Quiz masters", 10}, {"Number 1", 5}, {"We are not the champions", 3}};
        Quiz newScores = new Quiz(scores);
        // Add score to team
        newScores.Add("Number 1", 4);
        newScores.State("Number 1"); //Don't need to use writeline or return as state method already does that.
        // Change a team's score
        newScores.Change("Quiz masters", 7);
        newScores.State("Quiz masters");
        // Print the new dict of teams and their scores. How, scores is a dict of string, int pairs
        foreach (var teams in scores) {
            Console.WriteLine($"{teams.Key}: {teams.Value}");
        }
        
    }
}
