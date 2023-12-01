# Static Methods

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you will learn to define and call your own static methods.

## Introduction

In the previous step we learned that static methods are called on a class, 
rather than on an instance of a class. We didn't, however, see any examples 
beyond `Main`, which is called automatically.

In this section, we'll define and call some of our own static methods.

To recap, a simple C# class, in a namespace and with a `Main` method looks like this:

```cs
using System;
namespace CSharp.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!")
        }
    }
}
```

### Defining Static Methods

In the example below, we define a static method called `Alert` and then call 
it from inside the `Main` method.

```cs
namespace CSharp.StaticMethods;

class Program
{
    static void Main(string[] args)
    {
        Alert();
    }

    static void Alert() {
      Console.WriteLine("Be careful not to forget your 'Main' method!");
    }
}

```

And if we wanted to make `Alert` take an argument, we could do this:

```cs
namespace CSharp.StaticMethods;

class Program
{
    static void Main(string[] args)
    {
        Alert("Be careful not to forget those semi-colons!");
    }

    // remember we have to declare what type the argument is
    static void Alert(string message) {
      Console.WriteLine(message);
    }
}
```

What if we wanted to use our `Alert` method like this?

```cs
Console.WriteLine(Alert("HINT: This method must now return a string!"))
```

The `Alert` method must now return a `string`, right? So let's implement that.

```cs
namespace CSharp.StaticMethods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Alert("HINT: This method must now return a string!"));
    }

    // note that `void` has been replaced with `string`
    static string Alert(message) {
      return message;
    }
}
```

## Demonstration

[Demonstration Video](https://youtu.be/sXZxu8bz3Rw)

## Exercise

Add more static methods to the `Program` class, all of which print 
appropriate messages of your choosing, then call them from inside the `Main` 
method.

* `changeOfPlan`
* `apology`
* `politeNotice`
* `helpNeeded`


[Next Challenge](04_instance_methods_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F03_static_methods_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F03_static_methods_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F03_static_methods_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F03_static_methods_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F03_static_methods_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
