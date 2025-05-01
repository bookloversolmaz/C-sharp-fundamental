namespace CSharp.DSDicts;
using System;

// Exercise 1: dict of quiz names and their scores
// class Quiz {
//     internal Dictionary<string, int> scores; // keys = team names, vales are scores
//     internal Quiz(Dictionary<string, int> scores) {
//         this.scores = scores;
//     }
//     // add method that adds the team scores to the dict scores
//     // then add the new score to the key value pair
//     public void Add(string teamName, int newScore) {
//         // first find the corresponding team name in the existing dict
//         if(scores.ContainsKey(teamName)) {
//             scores[teamName] += newScore;
//         } else { // if the team doesn't exist, add the entire key value pair to the dict
//             scores.Add(teamName, newScore);
//         }
//     }
//     // use key to retreive team's score
//     public void State(string teamName) {
//         int teamScore = scores[teamName];
//         Console.WriteLine(teamScore);
//     }
//     // use key to change a team's score
//     public void Change(string teamName, int newScore) {
//         // check that the team name exists!
//         if(scores.ContainsKey(teamName)) {
//             scores[teamName] = newScore;
//         } else { // if the team doesn't exist, add the entire key value pair to the dict
//             scores.Add(teamName, newScore);
//         }
//     }
  
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Dictionary<string, int> scores = new Dictionary<string, int>  { {"Quiz masters", 10}, {"Number 1", 5}, {"We are not the champions", 3}};
//         Quiz newScores = new Quiz(scores);
//         // Add score to team
//         newScores.Add("Number 1", 4);
//         newScores.State("Number 1"); //Don't need to use writeline or return as state method already does that.
//         // Change a team's score
//         newScores.Change("Quiz masters", 7);
//         newScores.State("Quiz masters");
//         // Print the new dict of teams and their scores. Scores is a dict of string, int pairs
//         foreach (var teams in scores) {
//             Console.WriteLine($"{teams.Key}: {teams.Value}");
//         }
        
//     }
// }
// Exercise 2: create a dict of strings and lists of ints which stores how each team scored in every round.
// class Quiz {
//     internal Dictionary<string, List<int>> scores; // keys = team names, values are scores
//     internal Quiz(Dictionary<string, List<int>> scores) {
//         this.scores = scores;
//     }
//     // add method that adds the team scores to the end of the list
//     public void Add(string teamName, int newScore) {
//         // first find the corresponding team name in the existing dict
//         if(scores.ContainsKey(teamName)) { 
//             //Add score to the end of the list in the value part, at this point, already within the correct key value pair
//             scores[teamName].Add(newScore);
//         } else { // if the team doesn't exist, add the entire key value pair to the dict
//             scores.Add(teamName, new List<int> { newScore });
//         }
//     }
//     // use key to retrieve team's score
//     public void State(string teamName) {
//         List<int>teamScore = scores[teamName];
//         // print the list of scores, remember list is a variable, not a value, so it has to be converted into a string
//         Console.WriteLine(string.Join(", ", teamScore));
//     }
//     // use key to change a team's score based on the round number, i.e the second score in the list. roundnumber is the round or index in list that 
//     // we want to change. first find that the team exists. Then find that teams list of scores. Find the value within the index based on the index provided in roundnumber
//     // don't forget to minu 1 from roundnumber as indexes start at 0.
//     public void Change(string teamName, int newScore, int roundNumber) {
//         // check that the team name and round exists
//         if(scores.ContainsKey(teamName)) {
//             List<int>teamScore = scores[teamName]; // The scores for each team contained in a list of ints
//             int index = roundNumber - 1; // Find the index of the element (score) that we want to change, based on the number provided in roundnumber
//             teamScore[index] = newScore; // retrive the value in that index update the value using new score
//         } else { // if the team doesn't exist, add the entire key value pair to the dict, comprised of string and list of ints
//             scores.Add(teamName, new List<int> { newScore });
//         }
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Dictionary<string, List<int>> scores = new Dictionary<string, List<int>> 
//     {
//         { "Quiz masters", new List<int> { 10, 5, 7 } },
//         { "Number 1", new List<int> { 5, 3, 1 } },
//         { "We are not the champions", new List<int> { 3, 1, 8 } }
//     };
//         Quiz newScores = new Quiz(scores);
//         // Add score to team
//         newScores.Add("Number 1", 4);
//         newScores.State("Number 1"); //Don't need to use writeline or return as state method already does that.
//         // Change a team's score
//         newScores.Change("Quiz masters", 7, 1);
//         newScores.State("Quiz masters");
//         // Print the new dict of teams and their scores. Scores is a dict where keys are strings and values are a list of ints. Below uses select rather than foreach.
        
//         Console.WriteLine(string.Join(", ", scores.Select(kvp => $"{kvp.Key}: [{string.Join(", ", kvp.Value)}]")));

//     }
// }
// Exercise 3: build rock paper scissors game
class RockPaperScissors {
    // an instance field of a nested dict. Looks like { "rock"{"rock" = "draw", "paper" = lose, "scissors" = win} {}}
    // outer key holders player 1s play, the inner nested holds player 2 options and their outcomes.
    public static Dictionary<string, Dictionary<string, string>> rules = new Dictionary<string, Dictionary<string, string>> {
        ["rock"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["rock"] = "draw",
            ["paper"] = "lose",
            ["scissors"] = "win"
        },
        ["paper"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["rock"] = "win",
            ["paper"] = "draw",
            ["scissors"] = "lose"
        },
        ["scissors"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["rock"] = "lose",
            ["paper"] = "win",
            ["scissors"] = "draw"
        }
    };

    // Method takes player 1 play and loops through outer nested loop till it finds the matching play.
    // 
}