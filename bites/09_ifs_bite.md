# If Statements

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

This bite will show you how to create logical conditions within C# by using 
if statements.

## Introduction

In this section, you'll learn how to build if statements in C#. Let's start by 
looking at an example and imagine that `weather` is normally set to either 
`"sunny"`, `"rainy"` or `"cold"`

```cs
if(weather == "sunny") {
  Console.WriteLine("Don't forget the suncream :)");
} else if(weather == "rainy") {
  Console.WriteLine("You'll need an umbrella today!");
} else if(weather == "cold") {
  Console.WriteLine("Be sure to wrap up warm");
} else {
  Console.WriteLine("There is nothing remarkable about the weather today. What shall we talk about instead?");
}
```

Broadly speaking, the rules for using if statements are the same as most other
languages:

- You must start with an `if`
- You can include an `else if`
- You can include an `else`

If you've used Python before at Makers, you'll want to be aware of a few subtle
differences in the syntax:

- `else if` is used instead of `elif`
- You need brackets `()` around conditions i.e. After `if` and `else if`
- You need curly braces `{}` around code blocks

## Demonstration

[Demonstration Video](https://youtu.be/R-C40dKYd2Q)

## Exercise

FizzBuzz is a great exercise for practising `if` statements in a new language.

<details>
  <summary>Unfamiliar with the "rules" of FizzBuzz? Look within...</summary>
  FizzBuzz is a game where you count up from (for example) 1 to 100, except you 
  occasionally substitute the number for a word:
  
  * If the number is divisible by 3, you say "Fizz"
  * If the number is divisible by 5, you say "Buzz"
  * If the number is divisible by 3 AND 5, you say "FizzBuzz"
  * If the number isn't divisible by 3 or 5, you just say the number

  So, the first few numbers would be:  
  1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz

</details>

For this exercise, implement a FizzBuzz class that can give you the right 
result for one number - it doesn't need to loop through a sequence of numbers.

Your FizzBuzz class should have one static method:
* `Play` -> takes one number as an argument and returns either Fizz, Buzz, 
FizzBuzz or the input number

**Example output:**

```cs
namespace CSharp.IfStatements;

class Program {
  static void Main(string[] args) {
    FizzBuzz.Play(1); // => "1"
    FizzBuzz.Play(3); // => "Fizz"
    FizzBuzz.Play(5); // => "Buzz"
    FizzBuzz.Play(15); //=> "FizzBuzz"
  }
}
```

<br>
<details>
  <summary>Help, I'm stuck!</summary>

  <p>
    If you want to see a solution, watch the video below. If you want a hint, 
    read on.
  </p>
  <p>
    Your <code>Play</code> method has to return <em>either</em> an <code>int</code> or a <code>string</code>. 
    Can you represent a <code>string</code> using a number (in a way that is meaningful to 
    humans)? That could be tricky! Could you represent an <code>int</code> using a 
    <code>string</code>? Yes, you could! The <code>int</code> 1 could be represented as the <code>string</code> "1". So, in C#, how do you convert an <code>int</code> to a <code>string</code>? If you can do that, you can ensure that <code>Play</code> will always return a <code>string</code>.
  </p>

</details>
<br>

[Example Solution]()

## Challenge

**This is a process feedback challenge.** That means you should record yourself
doing it and submit that recording to your coach for feedback. [How do I do
this?](https://github.com/makersacademy/golden-square-in-python/blob/main/pills/process_feedback_challenges.md)

Create a class which will tell you whether a year is a leap year, according 
to the following rules:

* All years divisible by 400 ARE leap years (e.g. 2000 was a leap year)
* All years divisible by 100 but not by 400 are NOT leap years (e.g. 1700, 1800 
and 1900 were not leap years)
* All years divisible by 4 and not by 100 ARE leap years (e.g. 2004, 2008 and 
2012 were leap years)
* All years not divisible by 4 are NOT leap years (e.g. 2009, 2010 and 2011 
were not leap years)

**Example output:**

```cs
namespace CSharp.StaticMethods;

class Program {
  static void Main(string[] args) {
    LeapYear.isLeapYear(2000); // => true
    LeapYear.isLeapYear(1970); // => false
    LeapYear.isLeapYear(1900); // => false
    LeapYear.isLeapYear(1988); // => true
    LeapYear.isLeapYear(1500); // => false
  }
}
```

> After you're done, [submit your code and recording
> here.](https://airtable.com/shrvo9ePjlwnaiLv5?prefill_Item=csharp_ifs).

[Next Challenge](10_loops_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F09_ifs_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F09_ifs_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F09_ifs_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F09_ifs_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F09_ifs_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
