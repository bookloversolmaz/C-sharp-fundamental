using System;

namespace CSharp.InstanceMethods; //namespace groups related classes together
class Program
{

    static void Main(string[] args)
    {
        Program myProgram = new Program(); //create an instance of program or object. myProgram can call instance methods like Hello().
        string printOnly = myProgram.Hello(); //calls hello with no arguments
        Console.WriteLine(printOnly); // prints hello only
        string name = myProgram.Hello("Dave"); //calls hello with argument defined as name
        Console.WriteLine(name); // prints name

    }
    string Hello()
    {
        return "Hello";
    }

    string Hello(string name)
    {
        return $"Hello, {name}";
    }
    
}
