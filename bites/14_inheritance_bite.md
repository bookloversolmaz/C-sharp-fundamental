# Inheritance

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, learn to share code through inheritance

## Introduction

Imagine you're working on a social media application and you have two different types of post - `TextPost` and `VideoPost`. Both can be liked and both can be 'popular' if it has more than 100 likes.

The code for whether or not something is popular could look like this...

```cs
public bool isPopular() {  
  return this.likes > 100;
}
```

You _could_ put it in both `TextPost` and `VideoPost` classes but if you need to change something about how it works (perhaps you decide to implement a more nuanced definition of 'popular') you'll have to make that change in two places - it would be much better if you could just make the change in one place, for both classes. Inheritance allows you to do just that.

### A Parent Class

Inheritance involves _parent_ and _child_ classes. The shared behaviour is defined in the parent and then inherited by the children. You'll see how inheritance is implemented shortly. First, let's imagine a parent class for the case above.

```cs
class Post {
  public int likes;

  public bool isPopular() {
    return this.likes > 100;
  }
}
```

For now, it doesn't need anything else.

### Child Classes

Now we can take a look at what inheritance looks like, in the child classes. Here's `TextPost`...

```cs
class TextPost : Post {
  public string content;

  public TextPost(string content, int likes) {
    this.content = content;
    this.likes = likes;
  }
}
```

And `VideoPost`...

```cs
class VideoPost : Post {

  public string title;
  public string filepath;

  public VideoPost(string title, string filepath, int likes) {
    this.title = title;
    this.filepath = filepath;
    this.likes = likes;
  }
}
```

As you may have noticed, inheritance is achieved by doing `<ClassName> : Post` in the class definition. Using inheritance means that the child classes, `TextPost` and `VideoPost`, both gain the `isPopular` method and the `likes` field from `Post`, the parent class.

In the `Main` method of `Program.cs` we can now do this...

```cs
// create a TextPost
TextPost text = new TextPost("Hello, World!", 50);

// create a VideoPost
VideoPost video = new VideoPost("The 'Hello, World' Dance", "/videos/dance.mp4", 101);

// call the inherited method
Console.WriteLine(text.isPopular()); // => false
Console.WriteLine(video.isPopular()); // => true
```

Now, if you wanted to add new a new method to both `TextPost` and `VideoPost`, you could just add it to the `Post` class, like so...

```cs
class Post {
  public int likes;
  public bool isPopular() {
    return this.likes > 100;
  }

  // a new method which increments 'likes'
  public void likeIt() {
    this.likes++;
  }
}
```

## Demonstration

[Demonstration Video]()

## Exercises

- Reflect on both interfaces and inheritance. When would you use one or the other?
- Define a parent class called `Animal` and two child classes called `Cat` and `Dog`
- Give `Animal` some methods which the child classes will inherit
- Play with these classes in `Program.Main` and check that everything works

[Example Solution]()


[Next Challenge](15_polymorphism_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F14_inheritance_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F14_inheritance_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F14_inheritance_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F14_inheritance_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F14_inheritance_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
