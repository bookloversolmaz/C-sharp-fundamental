# Instance Fields

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you will learn how to use instance fields in C#.

## Introduction

You might have noticed that there's something crucial missing from what we've 
covered so far - instance variables!

In C#, instance variables (properties that belong to a specific instance of 
a class) are called _instance fields_. Using instance fields requires you to 
learn two things:

1. How to declare instance fields
2. How to assign values to instance fields

### Declaring fields

The first step to making all of this work, is to declare some instance fields and their types. Let's do this with a `Post` class.

```cs
class Post {

  // this class has two fields
  // both hold strings

  // one is called `content`
  string content;

  // the other is called `author`
  string author;
}
```

### Assigning values to instance fields

Next, we need to assign values. We could declare some methods whose role is to assign values. They might look like this. Think back to how you did this in Python. You used a special method called `__init__`, right?

<br>
<details>
  <summary>Why did we use <code>__init__</code> for that?
  </summary>
  <br>
  <p>
    The special thing about <code>__init__</code> is that it's called automatically when you create a new instance of your class. This means your Python instance variables are assigned without any further method calls.
  </p>
</details>
<br>

The C# equivalent of `__init__` is a _constructor_ method. Constructor methods look a bit odd if you're not familiar with them because they have the same name as the class. Our `Post` constructor would look like this...

```cs
class Post {

  string content;
  string author;

  // constructor
  Post() {
    // stuff to do when creating a new instance
  }
}
```

In this case, we probably want the constructor method to take `content` and `author` arguments so we can assign values dynamically.

```cs
class Post {

  string content;
  string author;

  // constructor with two `string` arguments
  Post(string content, string author) {
    // stuff to do when creating a new instance
  }
}
```

Finally, we'd assign values to instance fields like this...

```cs
class Post {
  
  string content;
  string author;

  Post(string content, string author) {
    // assign content
    this.content = content;
    // assign author
    this.author = author;
  }
}
```

We can now create instances of `Post`, each with their own `content` and `author` by passing arguments at instantiation.

```cs
Post weather = new Post("The weather today is great", "Serena");
Post holiday = new Post("Just about to head off to the Solomon Islands!", "Kevwe");
```

## Demonstration

[Demonstration Video]()

## Exercise

Create a new Console Application then...

Define a class called Quiz. When instantiated, it should take two questions as 
arguments, like so:

```cs
new Quiz("what is the capital of Burkina Faso?", "What is the capital of Bhutan?");
```

There should be two instance methods:

* getQuestionOne -> returns the first question
* getQuestionTwo -> returns the second question

Inside the `Main` method of your `Program` class, create an instance of Quiz, call the two instance 
methods and print the return values.

[Example Solution]()

## Challenge

Create a class called `ProgrammingLanguage` which has three instance fields:

* `String name`
* `Integer yearOfCreation`
* `String creator`

In the `Main` method of your `Program` class, create three instances of the `ProgrammingLanguage` class 
and print the three instance fields of each one.

[Next Challenge](06_multi_class_applications_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F05_instance_fields_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F05_instance_fields_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F05_instance_fields_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F05_instance_fields_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F05_instance_fields_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
