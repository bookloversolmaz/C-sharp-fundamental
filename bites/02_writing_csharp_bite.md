# Writing C#

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you will learn to build your first basic program in C#.

## Introduction

In this section, you'll learn how to build a minimal C# program. Let's start 
by looking at `Program.cs` which you ran in the previous step.

```cs
Console.WriteLine("Hello, World!");
```

`Console.WriteLine` is, as you might have guessed, equivalent to `print` but the most interesting thing in this tiny program is probably the semi-colon. Some, but not all, lines of C# need to end with a semi colon? So how do you know when to use them?

- Statements like variable assignment, method calls and object instantiation all need to end with a semi-colon.

- Namespace, Class and Method definitions (which all use curly braces) do not end with semi-colons.

You'll see plenty of examples of both but, if in doubt, watch out for feedback from your IDE and from the compiler. They will let you know if you have made a mistake :)

The compilation error for a missing semi colon looks like this (below). It's a bit verbose but if you read carefully you'll find
  * <code style="color : red">Program.cs(17,47)</code> which tells you where the problem is - the numbers in brackets are line number and column number
  * <code style="color : red">error CS1002: ; expected</code> which tells you a semi-colon was expected (is missing)

<code style="color : red">
/Users/eddie/development/csharp/bites/examples/CSharp.Main/Program.cs(17,47): error CS1002: ; expected [/Users/eddie/development/slug/materials/universe/language_intros/challenges/csharp/bites/examples/CSharp.Main/CSharp.Main.csproj]

The build failed. Fix the build errors and run again.
</code>

Code like the example above, which just sits in a file, outside any class or method definitions is called a 'top-level statement'. It's the simplest way to write C# but you can only use top-level statements in one file per application. Everything else must be wrapped inside a class.

So let's see what that looks like...

```cs
// imports classes, such as `Console` that are defined in the `System` namespace
using System;
// a `namespace` is a container (or scope) for classes
namespace CSharp.Intro
{
    // the class definition begins here
    class Program
    {
        // static methods are like Ruby's class methods
        // void means that this method returns nothing
        // the Main method takes an array of strings as an arg - `string[]`
        static void Main(string[] args)
        {
            // The Main method is called automatically when you execute the program
            // When that happens, you'll see "Hello, Makers!" printed to the terminal
            Console.WriteLine("Hello, World!");
        }
    }
}
```

NOTE: You can find the above example in `bites/examples/CSharp.Main`. If you want to run it, `cd` into that directory and do `dotnet run`.

### What is `static void`?

C# method definitions often involve a few different keywords. Here we needed to use two:

* `static` - static methods are methods where you don't need to create an 
instance of the class in order to call the method.

* `void` - this is where things get really interesting! C# is a _statically 
typed_ language, which means we must declare what _type_ of thing methods will 
return. Our `Main` method doesn't return anything though, and we declare that 
using the `void` keyword.

### OK What if my Method Does Return Something?

In that case, you would replace `void` with another keyword - the name of the type that your method returns. C# has 18 built-in types but you don't need to know them _all_ right now. Here are the types we'll use in this module.

- `string`: a sequence of alphanumeric characters like someone's name or the title of a book
- `bool`: `true` or `false`
- `char`: a single alphanumeric character like the letter 'a' or one of these '@'
- `double`: a decimal number (other decimal types are available)
- `int`: a whole number

Please (!) do not go down the rabbit hole of trying to learn about each one now, but do bookmark [this page on C# types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) for later.

> You'll see how to use these types when defining methods in the next bite.

### Is `string[] args` one argument or two?

This is one argument. As mentioned above, C# is _statically typed_. In 
addition to declaring what a method returns, we also have to declare what a method 
receive as arguments. In this case, we use `string[]` to declare that our `Main` 
method will receive an array of `string`s. If it were going to receive a 
single `string`, we'd change `string[] args` to `string arg`.

<br>
<details>
<summary>How would we declare that the method would receive an array of 
<code>int</code>s?</summary>
<br>
We'd use <code>int[] args</code>.
<br>
</details>

### Does the filename have to match the class name?

No, but it's conventional for them to be the same - so that's what you should do!

### How does the `Main` method get called?

If you pay close attention to the code above, you'll see that we just define 
the `Program` class and `Main` method, but there is no place that we do anything like 
`Program.Main()`. Clearly the `Main` method does get called, because we see 
`Hello, World!` printed.

The `Main` method is a special method in C# programs that is called 
automatically when a program is executed. So, every C# program must have one, 
and only one, `Main` method.

> You can test this quite easily by renaming the `Main` method in `CSharp.Main` to _anything_ 
else, and trying to run your code.

> What about `CSharp.Intro`? There was no `Main` method! Well, the compiler actually created one for you, with your top-level statement/s inside. How thoughtful. So what happens if you add a top-level statement to a program that does have a `Main` method? You can test this by adding a top-level statement to `CSharp.Main`. NOTE: Put your top-level statement under `using System` and above the `namespace` declaration (line 3 should work nicely).

### Creating Your Own .NET Console Application

The small codebases in `/examples` are what .NET calls Console Applications (since they are applications which run in the console / command line) - and they were largely generated using the `dotnet` command line interface (CLI).

To create your own .NET Console Application from scratch, go to wherever you keep your programming projects (mine are in `~/development`) and decide what you want to call your Console Application (for the sake of this demo, I've chosen to call it `CSharp.MyProject`) and then do this in your terminal...

```shell
# --use-program-main tells dotnet to create a class called Program with a Main method
# What happens when you omit that bit?
; dotnet new console --name CSharp.MyProject --use-program-main
```

And you're done! The command you just ran will have created a new directory (in my case it's called `CSharp.MyProject`) so you can now `cd` into it and have a look at the files, if you like.

> Using a `.` in the name of a Console Application (or any other project) is a .NET convention. The intention is that you call your projects (or 'Assemblies' in .NET lingo) something like `CompanyName.ApplicationName`. It felt strange to me at first too :)

## Demonstration

[Demonstration Video]()

## Exercise

Use dotnet to create a new Console Application called `CSharp.Quiz` and then, in `Program.cs` add a class called `Program` and give it a `Main` method.

Inside the main method, use `Console.WriteLine` to print answers to the following questions.

> Don't forget those semi colons!

1. Does all C# code have to be inside a class?
2. What is compilation?
3. What is special about the `Main` method?
4. What does `void` mean?

[Example Solution]()


[Next Challenge](03_static_methods_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F02_writing_csharp_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F02_writing_csharp_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F02_writing_csharp_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F02_writing_csharp_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F02_writing_csharp_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
