# Strings

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, we will learn some of the ways in which you can modify or 
combine `string`s within C#.

## Introduction

In this section, you'll learn how to manipulate `string`s in C#. We'll cover:

* Concatenation: joining two `string`s together, one after the other
* Interpolation: inserting values into the middle of `string`s

### Concatenation

To join two strings together in C#, you use the `+` symbol. For example:

```cs
"Hello, " + "world";
// => "Hello, world"
```

You can also do this using strings that are assigned to variables:

```cs
string question = "Person 1: what is the world's oldest (currently spoken) language?";
string answer = "Person 2: Hindi";
// Note we're also concatenating a space to separate the question from the answer
String questionAndAnswer = question + " " + answer;
```

And you can concatenate using arguments:

```cs
public string Appreciate(string name) {
  return "Thank you, " + name;
}
```

### Interpolation

Interpolation is also fairly straightforward. Here's an example...

```cs
string name = "eddie";
Console.WriteLine($"Hello, {name}");
```

As you can see, you achieve interpolation by adding a `$` before the start of your `string` and by using `{}` to contain whatever it is that you want to interpolate.

There is actually a _lot_ more to C# `string` interpolation but this is more than sufficient for now.

## Demonstration

[Demonstration Video](https://youtu.be/-Ot3pWdDinU)

## Exercise

Add a new method to your `Order` class called `FriendlyTotal` that returns the 
order total as part of a friendly message, using `string` interpolation. For example:

```cs
order.FriendlyTotal();
// => "Thanks! The total value of your order is £100."
```

[Example Solution]()

## Challenge

Define a class called `StoryBuilder` that has one `string` instance field 
called `plot` and two methods:

* AddPlotline -> takes one `string` argument and concatenates it onto `plot`
* GetPlot -> returns `plot`

Use both methods inside the `Main` of your `Program` class to build and then print a `plot`.

[Next Challenge](09_ifs_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F08_strings_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F08_strings_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F08_strings_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F08_strings_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F08_strings_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
