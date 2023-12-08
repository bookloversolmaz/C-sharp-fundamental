# Instance Methods

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you will learn how to...

- Create instances of a class
- Define and call your own instance methods.

## Introduction

As you'd expect, C# also has instance methods and these are called on 
instances of a class. In this section, you'll learn how to define and call 
instance methods, which means you'll also learn how to create instances of a 
class.

### Instantiation

To create an instance of the `Program` class, you would do this:

```cs
new Program();
```

But you'll probably need to assign the instance to a variable. At this point, 
C#'s _strong typing_ pops up again. In addition to declaring the return and 
argument types of methods, we also need to declare what type of thing a 
variable will hold. Here are some examples:

```cs
string name = "Sita";
int age = 47;
```

> The type of `name` is `String` and the type of `age` is `Integer`.

When we're assigning our instance of `Program`, we'd do this:

```cs
Program myProgram = new Program();
```

> The type of `myProgram` is `Program`.

If your head is starting to spin, don't panic - that's normal :)

Let's see the full example now:

```cs
namespace CSharp.InstanceMethods;

class Program
{
    static void Main(string[] args)
    {
      // create an instance of Program and assign it to a variable
      Program myProgram = new Program();
    }
}
```

### Defining Instance Methods

If you leave out the `static` keyword, your method becomes an instance method 
and you ~can~ _must_ then call it on an instance of the class.

```cs
// a static method
static void MyMethod() {
  Console.WriteLine("a static method")
}

// an instance method
void MyMethod() {
  Console.WriteLine("an instance method")
}
```

### Method Overloading

Instance methods can be 'overloaded' in exactly same way was static methods.

```cs
// an instance method called MyMethod
void MyMethod() {
  Console.WriteLine("an instance method")
}

// a second method with the same name but different args
void MyMethod(string message) {
  Console.WriteLine(message)
}
```

## Demonstration

[Demonstration Video](https://youtu.be/HiYWtOU6v7M)

## Exercise

Turn the static you implemented at the end of the previous bite into instance methods and call them in the `Main` method.

[Example Solution]()


[Next Challenge](05_instance_fields_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F04_instance_methods_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F04_instance_methods_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F04_instance_methods_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F04_instance_methods_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F04_instance_methods_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
