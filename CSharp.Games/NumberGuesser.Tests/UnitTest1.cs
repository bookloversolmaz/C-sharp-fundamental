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
    // note that the expected value comes first
    // if it helps, imagine Yoda saying "higher, it should be"
    Assert.AreEqual("higher", game.Guess(9));
  }
}

// for when the number guessed is too low
// for when the number guessed is too high
// for when the number guessed is correct