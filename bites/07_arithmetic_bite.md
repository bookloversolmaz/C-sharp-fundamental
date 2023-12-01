# Arithmetic

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you will learn to do some maths with C#!

## Introduction

> If you hate maths, fear not - we're going to do pretty simple stuff here :)

C# makes things simple, as the common operators are exactly what you would 
probably expect them to be.

```cs
// addition
1 + 1
// subtraction
10 - 1
// multiplication
10 * 10
// division
10 / 10
// modulo
10 % 2
```

## Demonstration

[Demonstration Video](https://youtu.be/EjupOib4_gs)

## Exercise

Create a new Console Application, then...

Define a class called `Order` which has one instance `int` field called 
`total` and three instance methods:

* `AddAmount` -> takes one `int` and adds it to the `total`
* `ApplyDiscount` -> takes one `int` and subtracts it from the `total`
* `GetTotal` -> returns the `total`

Use all these methods in the `Main` of your `Program` class to build an order and print the total.

[Example Solution]()

## Challenge

Define a class called `Discounter` which has one `int` field called 
`discount` and one instance method:

* `ApplyTo` -> takes an `int`, subtracts the `discount` and returns the 
new value

For example:

```cs
Discounter discounter = new Discounter(20);
discounter.ApplyTo(100)
// returns 80
discounter.ApplyTo(200)
// returns 180
```

Inside the `Main` method of your `Program` class, create an instance of `Discounter` use the `ApplyTo` 
method and print the return values.

If you want to get even more advanced, try changing the behaviour of your
Discounter so that it applies a _percentage_ discount instead of a fixed 
amount. For example...

```cs
Discounter discounter = new Discounter(30);

// discount 30%
discounter.ApplyTo(100)
// returns 70

// discount 30%
discounter.ApplyTo(200)
// returns 140
```

[Next Challenge](08_strings_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F07_arithmetic_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F07_arithmetic_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F07_arithmetic_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F07_arithmetic_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F07_arithmetic_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
