# Data Structures 2: Dictionaries

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you'll learn how to store dictionary-style data (with keys and 
values) by using a C# Dictionary.

## Introduction

Like Python Dictionaries, C# Dictionaries are used to store data 
as key-value pairs. Of course, we need to consider _typing_ here too! When you 
declare a Dictionary in C#, you need to state the type of both the keys and 
values. So, for example, if you wanted to represent a restaurant menu as a 
Dictionary, you might decide that the keys would be the name of each item 
(`string`) and the values would be the prices (`int`). Let's see an example.

```cs
// create an empty Dictionary ready to store string keys and int values
Dictionary<string, int> menu = new Dictionary<string, int>();
```

Beyond creating an empty Dictionary, you need to know the following:

* New key-value pairs are added using `Add`
* A value can be changed using the corresponding key
* A value can be read in several ways - some are simple, others are robust
* Key-value pairs are removed using `Remove`

Let's see some examples:

```cs
// create the empty Dictionary
Dictionary<string, int> menu = new Dictionary<string, int>();

// add a key-value pair
menu.Add("huel", 2);

// add another key-value pair
menu.Add("coffee", 1);

// change the price of coffee
menu["coffee"] = 2;

// read the price of huel
int price = menu["huel"];
// now print it
Console.WriteLine(price)
// => 2

// remove huel from the menu
menu.Remove("huel");
```

Before moving on, create some Dictionaries, try out everything above then answer these questions...

1. What happens if you try to `Add` a key that already exists? For example, what would happen if we did `menu.Add("coffee", 2)` then `menu.Add("coffee", 2)` again?
2. What happens if you try to read the value of a key that doesn't exist? For example, what would happen if we did `int price = menu["tea"]`?
3. What problems might these behaviours cause?

So, you will probably have found that things start to go wrong when you do stuff like try to add keys that already exist or read the values of keys that do not exist.

What problems might this cause? Runtime errors!

These are pretty bad because they're likely to have a detrimental impact on user experience. To avoid this, you need to fist check whether or not a key exists. Of course, there are a few ways to do this - here's one...

```cs
Dictionary<string, int> menu = new Dictionary<string, int>();

menu.Add("huel", 2);
menu.Add("coffee", 1);
if(menu.ContainsKey("chips")) {
    Console.WriteLine(menu["chips"]);
} else {
    Console.WriteLine("No such key");
}
```


## Demonstration

[Demonstration Video]()

## Exercise 1

Then, in the `Main` method of a `Program` class (either new or old)

* Assign an empty `Dictionary<string, int>` to a variable called `scores`
  * The keys will be quiz team names
  * The values will be their scores
* Practice using `Add` to add quiz team scores to the `Dictionary`
* Practice using the key to retrieve a team's score
* Practice using the key to change a team's score

[Example Solution]()

## Exercise 2

Change `scores` from `Dictionary<string, int>` to `Dictionary<string, List<string>>` 
so that the dictionary values are all `List<int>` which can be used to store how each team scored in every quiz round.

Then:

* Practice using `Add` to add quiz team scores to the `Dictionary`
* Practice using the key to retrieve the a team's scores
* Practice using the key to change a team's scores

[Example solution]()

## Exercise 3

This one is quite challenging, so don't be disheartened if you get stuck and 
have to check the example solution! (But do take a moment to digest the video, if you watch it, 
before moving on.)

Define a class called `RockPaperScissors` which has:

* a static field called `rules` which holds a nested `Dictionary` (see below for 
further guidance)

The `rules` `Dictionary` should work like this:

```cs
// player 1 chooses "rock", player 2 choose "paper"
rules["rock"]["paper"];
// => player 1 loses
```

The first key (`"rock"`) returns a `Dictionary` and the second key `"paper"` returns the outcome. 
Building the `rules` `Dictionary` will require a bit of planning and several 
programmatic steps.

[Example Solution]()

## Challenge

Create a new Console Application called `CSharp.Games` then...

Define a class called `ScrabbleScore` with:

* a static field called `letterValues` which holds a `Dictionary` of points for 
each letter. Each key should be a single letter and each value should be its 
points value.
* a static method called `Calculate` which takes a `string` and returns the 
Scrabble score for the word, as an `int` e.g.:

```cs
//  Scrabble player places down the word "EXQUISITELY"
ScrabbleScore.Calculate("EXQUISITELY");
//  => 30
```

__Note__: In the English language version of
[Scrabble](https://en.wikipedia.org/wiki/Scrabble), tiles are worth the
following:

* 1 point - A, E, I, O, U, L, N, S, T, R
* 2 points - D, G
* 3 points - B, C, M, P
* 4 points - F, H, V, W, Y
* 5 points - K
* 8 points - J, X
* 10 points - Q, Z

You might find you need to do a little searching around on the web for this one,
especially for how to get hold of individual letters from the word. Also, remember that there is  a special data type for individual alphanumeric `char`acters ;)

<details>
  <summary>Please give me a hint!</summary>
  
  Calculating the Scrabble score for a whole word will require a few steps:
  
  * Creating a variable to hold the total score - it should start at 0
  * Splitting the word into letters
  * Looping over the letters to get the score for each one
  * Adding the score for each letter to the total score
  * Returning the total score

</details>

[Next Challenge](13_interfaces_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F12_data_structures_2_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F12_data_structures_2_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F12_data_structures_2_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F12_data_structures_2_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F12_data_structures_2_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
