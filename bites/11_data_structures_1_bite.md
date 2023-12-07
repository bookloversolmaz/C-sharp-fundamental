# Data Structures 1: Arrays and Lists

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you will learn how to store multiple data items within a single 
variable in C#, by using arrays and lists.

## Introduction

There are lots of different data structures in C#, but they're not all going 
to be useful in the immediate future. Here, you'll learn about creating arrays and lists.

> For this section, create a new Console Application class called `CSharp.Sandbox` so that you can write some 
> experimental code in the `Main` method of your `Prorgram` class.
> 
> ```cs
> 
> class Sandbox {
>     [...]
> }
> ```

## Lists

C# lists are a bit like Python lists
- You can use them to store basically anything (even other lists)
- Their length can change after instantiation
- They are indexed from 0

But there is one key difference
- C# lists are, of course, typed!

Creating a list of `string`s looks like this.

```cs
List<string> contentsOfMyPocket = new List<string>();
```

To add things, you can use the `Add` method.

```cs
contentsOfMyPocket.Add("keys");
contentsOfMyPocket.Add("phone");
contentsOfMyPocket.Add("fluff");
```

And to access elements of your list, you can use the index.

```cs
contentsOfMyPocket[0]
contentsOfMyPocket[1]
contentsOfMyPocket[2]
```

If you want to remove something from a list, you can use the `Remove` method.

```cs
contentsOfMyPocket.Remove("keys");
```

So there are two methods to remember here:

* `Add` to add items
* `Remove` to remove items

Finally, it's useful to know how to iterate through a list. There are a 
few options, but for now we'll go with one of the simplest iterators to 
understand (it'll look very familiar to you if you've worked with Python). 

If you already have a List of `contentsOfMyPocket`, you could do this:

```cs
foreach(string item in contentsOfMyPocket) {
  Console.WriteLine(item);
}
```

Note the typing crops up again! Within the for loop, we use the variable `item`
to hold each item as we iterate through the `List`. When declaring `item` we
have to state what type of thing it will hold - in this case, by typing `string
item`.

## Arrays

c# arrays are a lot like `List`s but there is a crucial difference - 
arrays are of a fixed length. So, when you create a new empty array, you need 
to state how many things it needs to hold. For example:

```cs
string[] plantsIHaveKilled = new string[100];
```

The `string[100]` bit means that we want an empty array that will eventually 
hold Strings and that it should have 100 empty slots. If you end up killing 
more than 100 plants, you'll need to create a new array with larger capacity 
and copy everything over.

> Dev: Oh C#, why must you make everything so complicated??
>
> C#: Hi - C# here! When you ask me to create a `string[]` I'll allocate 
> just enough memory for that data structure and no more. If you need your 
> array to hold 10 strings, that's fine, but I'm not going to give you 11 
> strings worth of memory as that would be a waste. If, however, you're 
> genuinely unsure how many things your array will need to hold, I will gladly 
> create a List for you, but you should be aware that it will take up a 
> lot more memory than, for example, a `string[5]`. So bear that in mind, 
> particularly if you care about performance.
>
> Dev: Thanks, C#, you're a bit fussy but I kind of like you.

One nice thing about arrays is that you can create and manipulate them in a 
more concise manner.

```cs
// create an array of four Strings
string[] famousCats = { "Larry", "Palmerston", "Geronimo", "Cat Stevens" };

// get the first item
famousCats[0];
// => "Larry"

// change the first item
famousCats[0] = "Grumpy Cat";

// remove the first item by replacing it will `null`
famousCats[0] = null;
```

What if you wanted to create an empty array and add things later? You can do that too.

```cs
// create an empty string array with 4 slots
string[] famousCatsSeenToday = string[4];

// add an item
famousCatsSeenToday[0] = "Puss in Boots"
```

As with lists, you can iterate through arrays using `foreach`

```cs
foreach(string cat in famousCats) {
  Console.WriteLine(cat);
}
```

You'll see both arrays and `List`s used in the wild. At some point, 
you'll probably make the wrong choice - it happens to us all - then you'll get 
feedback and learn from the mistake :)

## Demonstration

[Demonstration Video]()

## Exercise

Define a class called `ReadingList` that has an instance field called `unread` 
that holds an array of `string`s. Also, define a method called `Add` which takes 
one argument (a book title) and adds it to the first empty slot in your 
`unread` array. NOTE: We're using arrays here, not `List`s. This will 
make the task of adding items a bit more complex!

Test out your new class in the `Main` method of `Program`.

[Example Solution]()

## Challenge

Define a class called `Queue` which has an instance field called `people` that 
holds a List of Strings. Each item in the `people` List will be the 
name of a person in a queue. The class should have three methods.

* `Add` - which adds people to the end of the `people` List
* `Next` - which gets and removes the first person in the `people` List
* `State` - which prints a list of all the `people` who are currently queuing

Test out your new class in the `Main` method of `Program`.

[Next Challenge](12_data_structures_2_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F11_data_structures_1_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F11_data_structures_1_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F11_data_structures_1_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F11_data_structures_1_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F11_data_structures_1_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
