# Test Driven Development

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you'll learn how to use JUnit to incorporate test-driven 
development (TDD) practices into your C# coding.

## Introduction

If you've craving tests, this bite will sate your appetite.

Here, you'll learn how to test-drive a single class using NUnit.

The overall process is exactly the same as it was in Python.

> - Write a test
> - _Red_: Watch it fail
> - _Green_: Write just enough code to make the test pass
> - _Refactor_: Improve your solution

And individual tests can be broken down into...

> - _Arrange_: set up, including object instantiation where needed
> - _Act_: calling the method under test
> - _Assert_: checking that your method does / did what you intended

If you ever get totally lost, come back here and remind yourself of these things.

### Setup

Doing TDD in C# requires you to create two separate projects, one for your tests and one for your application. These are then brought together by a _solution_ (right now, that's all you need to know about solutions). You can find an example in `./examples/tdd` and here's [a video of how we got there]().

### Your First Tests

Now you're going to test drive a small program. First of all, get set up with a new TDD project by following these steps...

1. Create a directory for called `CSharp.Games` for your project and `cd` into it
2. Do `dotnet new sln` to create a new solution
3. Do `dotnet new console --name NumberGuesser`
4. Do `dotnet sln add NumberGuesser/NumberGuesser.csproj` to add the new project to your the solution
5. Create a directory called `NumberGuesser.Tests` and `cd` into it
6. Do `dotnet new nunit`
7.  Do `dotnet add reference ../NumberGuesser/NumberGuesser.csproj` to add NumberGuesser as a dependency of NumberGuesser.Tests
8. `cd` back up to the directory which contains the solution
9. Do `dotnet sln add NumberGuesser.Tests/NumberGuesser.Tests.csproj` to add your new NUnit project to the solution
10. Do `dotnet test` to run the initial tests. There should be one passing test, no failing tests and no errors.

So what next? Let's make a plan. You're going to build a simple guessing game which can be used as follows.

```cs
// player one creates a new game, passing in a secret number
// player two should look away at this point!
Gamne game = new Game(10);

// player two guesses (too low) and sees some helpful feedback
game.Guess(5);
// => "higher"

// player two guesses too high this time
game.Guess(20);
// => "lower"

// and now they guess correctly
game.Guess(10)
// => "correct-a-reno!!"
```

So you're going to need:

* tests
  * for when the number guessed is _too low_
  * for when the number guessed is _too high_
  * for when the number guessed is _correct_
* a class called `Game`
* one method called `Guess` that takes an `int` and returns a `string`
* a constructor that takes one `int` as an argument
* one instance field for holding the secret number

Let's write a test together for when the guessed number is too low. This first test will 
drive us to define the `Game` class, the constructor and the `Guess` 
method.

```cs
class GameTests {
  [Test]
  public void Guess_TooLow_ReturnsHigher() {
    Game game = new Game(10);
    // note that the expected value comes first
    // if it helps, imagine Yoda saying "higher, it should be"
    Assert.AreEqual("higher", Game.Guess(5));
  }
}
```

Now we can take a moment to break this down.

* `[Test]` is what NUnit calls an _attribute_. In this case, it tells NUnit that the method which follows should be run as a test.

* `public` is an access modifier, as you know! Test methods must be `public` because of the way in which they are executed by NUnit. If you get this wrong, your text editor and / or the compiler will let you know :)

* `Guess_TooLow_ReturnsHigher` test, which I have named according to this pattern `MethodUnderTest_StateUnderTest_ExpectedOutcome`. You should use the same pattern when naming your tests later on.

* `Assert.AreEqual` is an _assertion_ and by using it we're saying that the return value of `Game.Guess(5)` should be equal to (the same as) `"higher"`. This assertion, along with `Assert.AreNotEqual` will get you a long way.

> These are classic / legacy Assertions. We chose to use them here because we feel they are a good starting point and it's totally fine to use them for now. You will, however, see [another type of assertion](https://docs.nunit.org/articles/nunit/writing-tests/assertions/assertions.html#two-models) as you browse the internet looking for help.

As things stand, the compiler (and VSCode) will complain about the fact that 
the `Game` class doesn't exist. That's fine for now - you'll address that in the exercise which follows.

## Demonstration

[Demonstration Video]()

## Exercise

Based on the first test and what we've covered in previous sections, you know 
everything you need in order to complete the `Game` class using TDD.

1. Do just enough to satisfy the compiler and no more. For example, you'll need
to define the `Game` class.
2. The `Game` class, its constructor and any methods under test should be `public`
3. Make the first test that we wrote together pass.
4. Complete the program by test driving two more scenarios, one where player two
guesses too high, and one where player two guesses correctly.

<br>
<details>
  <summary>Does the <code>Game</code> class and its methods really need to be <code>public</code>?</summary>
  <p>Actually, no but it's the simplest approach. They have to be accessible to the <code>Game.Test</code> project, which is a separate assembly, but there is another way to achieve that which doesn't involve making things <code>public</code></p>
  <p>
  If you want to try it, do the following...
  <ol>
  <li>
  Create a file called <code>AssemblyInfo.cs</code> alongside <code>Diary.csproj</code>
  </li>
  <li>
  Add this to the new file
  <br>
  <code>
  using System.Runtime.CompilerServices;
  <br>
  [assembly: InternalsVisibleTo("Diary.Tests")]
  </code>
  <br>
  </li>
  <li>
  Make your <code>Game</code> class and its methods internal
  </li>
  <li>
  Run your tests!
  </li>
  </ol>
  </p>
</details>
<br>

[Example Solution]()

## Challenge

**This is a process feedback challenge.** That means you should record yourself
doing it and submit that recording to your coach for feedback. [How do I do
this?](https://github.com/makersacademy/golden-square-in-python/blob/main/pills/process_feedback_challenges.md)

Starting from scratch, test-drive an implementation of `FizzBuzz` that gives 
you the `FizzBuzz` value for a single number.

For example:

```cs
FizzBuzz fizzBuzz = new FizzBuzz();
fizzBuzz.ForNumber(1);
// => "1"
fizzBuzz.ForNumber(3);
// => "Fizz"
fizzBuzz.ForNumber(5);
// => "Buzz"
fizzBuzz.ForNumber(15);
// => "FizzBuzz"
```

> After you're done, [submit your code and recording here.](https://airtable.com/shrvo9ePjlwnaiLv5?prefill_Item=csharp_tdd).

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F16_tdd_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F16_tdd_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F16_tdd_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F16_tdd_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F16_tdd_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
