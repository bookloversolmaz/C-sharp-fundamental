namespace __CSharp.StaticMethods;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine(Hello("Solmaz"));
        Console.WriteLine(changeOfPlan("ballroom dancing"));
    }
    static string Hello()
    {
        return "Hello";
    }
    static string Hello(string name)
    {
        return $"Hello, {name}";
    }
    static string changeOfPlan() 
    {
        return "Let's go out instead!";
    }
    static string changeOfPlan(string dancing)
    {
        return $"let's go out {dancing} instead!";
    }
    
}
