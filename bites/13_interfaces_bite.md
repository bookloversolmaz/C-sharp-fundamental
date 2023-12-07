# Interfaces

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you'll learn to recognise and explain interfaces in C#.

## Introduction

Calculators, ATMs and telephones (oldish landline telephones) all have number 
pads that feature the numbers 0 to 9. These number pads are _interfaces_ 
between the a user and the inner workings of each device.

If you wanted to design a new machine that also has a number pad, you could say 
in your designs that the machine should _implement_ (have) the `number pad` interface. 
Then, whoever builds it would have a really clear understanding of what's 
needed.

> To emphasise an important point: the inner workings of each device with the 
> `number pad` interface are different. Pressing the number 1 on a calculator 
> does not do the same thing as pressing the number 1 on an ATM.

**OK, let's go back to C#!**

C# interfaces are groups of methods without method bodies - like a number pad 
that has been disconnected from a calculator or telephone. Let's have a look at 
one:

```cs
// an interface called NumberPad
interface NumberPad {
  // some methods without method bodies
  internal void PressNumber(int number);
  internal void PressCancel();
}
```

We can use the interface to declare that another class should implement these 
two methods, like so:

```cs
// a class called Telephone that implements the NumberPad interface
public class Telephone : NumberPad {

  List<int> numberDialled;

  internal Telephone() {
    this.numberDialled = new List<int>();
  }

  // we've said the class implements the NumberPad interface
  // so now we have to define the two NumberPad methods

  // note that the method must be public
  public void PressNumber(int number) {
    this.numberDialled.Add(number);
  }

  // note that the method must be public
  public void PressCancel() {
    this.numberDialled = new List<int>();
  }
}
```

> If you declare that a class implements an interface and do not then define 
> all of the interface methods, the compiler will tell you off and it will not 
> compile your code - try it and see!

You'll probably not be creating many interfaces in the near future, beyond this bite, 
but you _will_ see them being used here and there.

## Demonstration

[Demonstration Video]()

## Exercise

Create a new Console Application called `CSharp.Diaries` then...

Define an interface called `GenericDiary` which has the following methods:
* `AddEntry`, which takes one `string` argument - a new diary entry - and
  doesn't return anything
* `RemoveEntry`, which takes one `int` argument - the index of the entry to be 
removed - and doesn't return anything
* `ReadEntry`, which takes one `int` argument - the index of the entry to be 
read - and returns that entry (as a `string`)

Next, define two classes, one called `TenDayDiary` and another called 
`InfiniteDiary`. Both of these classes should implement the `GenericDiary` 
interface but:

* `TenDayDiary` stores entries in a `string[10]`
* `InfiniteDiary` stores entries in an `List<string>`

[Example Solution]()

## Challenge

Create a new Console Application called `CSharp.Birds` then...

Define an interface called `BirdBehaviours` in its own file 
(called BirdBehaviours.cs). The `BirdBehaviours` interface should have three 
methods:

* `fly`
* `sing`
* `eat`

Then define three classes: `Penguin`, `Crow` and `Gull`. Each of these three 
classes should implement the `BirdBehaviours` interface. You can decide for 
yourself how each class implements each method in the `BirdBehaviours` 
interface :)


[Next Challenge](14_inheritance_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F13_interfaces_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F13_interfaces_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F13_interfaces_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F13_interfaces_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F13_interfaces_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
