using NUnit.Framework;
using NumberGuesser;

namespace NumberGuesser.Tests;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}

class GameTests {
  [Test]
  public void Guess_TooLow_ReturnsHigher() {
    Game game = new Game(10);
    var result = game.Guess(9);
    // note that the expected value comes first
    // if it helps, imagine Yoda saying "higher, it should be"
    Assert.That(result, Is.EqualTo("higher"));
  }
  public void Guess_TooHigh_ReturnsLower() {
    Game game = new Game(10);
    var result = game.Guess(15);
    // note that the expected value comes first
    // if it helps, imagine Yoda saying "higher, it should be"
    Assert.That(result, Is.EqualTo("lower"));
  }
  public void Guess_Correct_ReturnCorrect() {
    Game game = new Game(10);
    var result = game.Guess(10);
    Assert.That(result, Is.EqualTo("correct-a-reno!!"));

  }
}

// for when the number guessed is too low
// for when the number guessed is too high
// for when the number guessed is correct