using Iteration_Exercises;

namespace IterationExercises.Test;

public class LoopingTests
{

    [Test]
    public void WhileLoopReturnsOneNameWithHello()
    {
        //arrange

        //act
        var greetedNames = Looping.WhileLoop(new List<string> { "Alex" }).ToList();

        //assert
        Assert.That(greetedNames.Count, Is.EqualTo(1));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Alex"));
    }

    [Test]
    public void WhileLoopReturnsMultipleNamesWithHello()
    {
        //arrange

        //act
        var greetedNames = Looping.WhileLoop(new List<string> { "Dan", "Joao", "Ryan Le" }).ToList();

        //assert
        Assert.That(greetedNames.Count, Is.EqualTo(3));
        Assert.That(greetedNames[0], Is.EqualTo("Hello Dan"));
        Assert.That(greetedNames[1], Is.EqualTo("Hello Joao"));
        Assert.That(greetedNames[2], Is.EqualTo("Hello Ryan Le"));
    }
}
