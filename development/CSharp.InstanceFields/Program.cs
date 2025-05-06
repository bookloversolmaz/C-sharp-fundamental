namespace CSharp.InstanceFields;

using System;
class Quiz {
// This class has two fields both hold strings
string questionOne;
string questionTwo;
// constructor
  public Quiz(string questionOne, string questionTwo) {
    this.questionOne = questionOne;
    this.questionTwo  = questionTwo ;
  }
}

class ProgrammingLanguage {
string name;
int yearOfCreation;
string creator;
  public ProgrammingLanguage (string name, int yearOfCreation, string creator) {
    this.name = name;
    this.yearOfCreation = yearOfCreation;
    this.creator = creator;
  }
}

class Program {
    static void Main(string[] args) {
        Quiz capital = new Quiz("What is the capital of Burkina Faso?", "What is the capital of Bhutan?");
        ProgrammingLanguage csharp = new ProgrammingLanguage("C#", 2000, "Hejlsberg et al");
        Console.WriteLine(capital);
        Console.WriteLine(csharp);
    }
}