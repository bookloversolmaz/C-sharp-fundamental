# Manipulating types in C#

This practical intends to train the following learning objectives:
  * Recognise which types are needed in a C# program.
  * Implement typing information on variables and methods in a C# program.

## Introduction

In the following examples, *types* are missing in some places.

To complete the exercise, fix each example in turn so that the program will compile and execute.

## Getting Started

1. Create a new command line project `dotnet new console --name TypingPractical`
2. Delete all the code you find in `Program.cs`
3. Replace it with the code in Example 1
4. **Focusing only on typing**, fix the code
5. Do the same for example 2 and 3

## Example 1

```csharp
using System;

namespace TypingPractical
{
  public class Program
  {
    public static void Main(string[] args)
    {
      name = "Anna";
      greeting = "Hello";

      message = greeting + " " + name;

      Console.WriteLine(message);
    }
  }
}
```

## Example 2

```csharp
using System.Collections;

namespace TypingPractical
{

  public class Program
  {
    public static void Main(string[] args)
    {
      ArrayList names = new ArrayList();

      names.Add("Kyle");
      names.Add("Sophie");
      names.Add("Graeme");

      string nameToFind = "Lisa";

      Program program = new Program();
      result = program.IsInArray(names, nameToFind);

      if (result)
      {
        Console.WriteLine("The name is in the array. Yay!");
      }
      else
      {
        Console.WriteLine("The name couldn't be found in the array — sorry...");
      }
    }

    public IsInArray(ArrayList names, string nameToFind)
    {
      foreach(String name in names)
      {
        if (name == nameToFind)
        {
          return true;
        }
      }

      return false;
    } 
  }
}
```

## Example 3

```csharp
using System;

public class Program
{
  public static void Main(string[] args)
  {
    int minimum = -100;
    maximum = 100;
    rand = new Random();
    randomNum = minimum + rand.Next((maximum - minimum) + 1);

    Program program = new Program();
    sign = program.GetNumberSign(randomNum);

    Console.WriteLine("The sign of the number {0:d} is: {1:s}", randomNum, sign);
  }

  public GetNumberSign(int number)
  {
    if (number < 0)
    {
      return "negative";
    }
    else if (number > 0)
    {
      return "positive";
    } else
    {
      return "zero";
    }
  }
}
```


<!-- BEGIN GENERATED SECTION DO NOT EDIT -->

---

**How was this resource?**  
[😫](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=practicals/typing/README.md&prefill_Sentiment=😫) [😕](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=practicals/typing/README.md&prefill_Sentiment=😕) [😐](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=practicals/typing/README.md&prefill_Sentiment=😐) [🙂](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=practicals/typing/README.md&prefill_Sentiment=🙂) [😀](https://airtable.com/shrUJ3t7KLMqVRFKR?prefill_Repository=makersacademy/csharp-apprenticeship-module&prefill_File=practicals/typing/README.md&prefill_Sentiment=😀)  
Click an emoji to tell us.

<!-- END GENERATED SECTION DO NOT EDIT -->
