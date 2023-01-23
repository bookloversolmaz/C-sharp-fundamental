using Iteration_Exercises;

namespace IterationExercises.Test;

public class LambdaTests
{
    [Test]
    public void LambdaGreetsName()
    {
        Assert.That(Lambda.Greet("Alex"), Is.EqualTo("Hi Alex"));
    }


    [Test]
    [Ignore("Not implemented yet - please work through looping material first")]
    public void LambdaGivesTitle()
    {
        Assert.That(Lambda.Title("Mx", "Addison"), Is.EqualTo("Mx Addison"));
    }

    [Test]
    public void GreetsAll()
    {
        var names = new List<string> { "Alice", "Bob", "Carol" };
        IEnumerable<string> expected = new List<string> { "Hi Alice", "Hi Bob", "Hi Carol" };
        Assert.That(Lambda.GreetAll(names), Is.EquivalentTo(expected));
    }
}
