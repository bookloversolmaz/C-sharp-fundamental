# Polymorphism

_**This is a Makers Bite.** Bites are designed to train specific skills or
tools. They contain an intro, a demonstration video, some exercises with an
example solution video, and a challenge without a solution video for you to test
your learning. [Read more about how to use Makers
Bites.](https://github.com/makersacademy/course/blob/main/labels/bites.md)_

In this bite, you'll learn to write flexible code using polymorphism.

## Introduction

In the previous bite, we saw how inheritance can be used to share code between classes using inheritance. We'll use that example again here.

Imagine that you now want to build a `Feed` class which can hold instances of both `TextPost` and `VideoPost` in a `List<T> posts` field. What type should `T` be?

If we used `List<TextPost>` we could only put instances of `TextPost` in it. If we used `List<VideoPost>`, we could only put instances of `VideoPost` in it. What's the solution?

Well, since both `VideoPost` and `TextPost` inherit from `Post` they are of type `VideoPost` / `TextPost` _and_, also, of type `Post`. So the solution would be to use `List<Post>`.

This is _polymorphism_. Taken literally, and translated from Greek, it means "many shapes".  I.e. `TextPost` and `VideoPost` have "many shapes" because they are also types of `Post`.

Polymorphism might not be something you _consciously_ use a lot in the near future, but it will crop up quite a bit. You will see one example next week when building controllers in ASP.NET. Make a note so that you remember to pay attention to the return types of controller methods!

> NOTE: Polymorphism can also be achieved using interfaces. Take a look back at the interfaces bite - through implementing the `NumberPad` interface, `Telephone`s are also `NumberPad`s.

## Demonstration

[Demonstration Video]()

## Exercise

[Example Solution]()

## Challenge



[Next Challenge](16_tdd_bite.md)

<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F15_polymorphism_bite.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F15_polymorphism_bite.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F15_polymorphism_bite.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F15_polymorphism_bite.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy%2Fcsharp-fundamentals&prefill_File=bites%2F15_polymorphism_bite.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
