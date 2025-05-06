namespace CSharp.IfStatement;
// class FizzBuzz {     
//     internal int numberInput;

//     internal FizzBuzz(int numberInput) {
//         this.numberInput = numberInput;
//     }
//     public void Play() {
//         if (numberInput % 3 == 0 && numberInput % 5 == 0) { // If loops run top to bottom, so 3 and 5 should be first as otherwise a number that meets both criteria will not reach this stage.
//             Console.WriteLine("FizzBuzz");
//         } else if(numberInput % 3 == 0) {
//             Console.WriteLine("Fizz");
//         } else if (numberInput % 5 == 0) {
//             Console.WriteLine("Buzz");
//         } else {
//             Console.WriteLine(numberInput);
//         }
//     }
//     static void Main(string[] args)
//     {
//         FizzBuzz game = new FizzBuzz(20); // Create instance of class called game, an object
//         game.Play(); //Call the play method with the instance variable defined in game. Don't need writeline as that is already called in play
//     }
// }
class LeapYear {
    internal int year;
    internal LeapYear(int year) {
        this.year = year;
    }
    public bool CheckYear() {
        if (year % 4 == 0 && year % 100 != 0) {
            return true;
        } else if (year % 100 == 0 && year % 400 != 0) {
            return false;
        } else if (year % 400 == 0) {
            return true;
        } else {
            return false;
        }
    }
    static void Main(string[] args) {
        LeapYear isLeapYear = new LeapYear(2009);
        bool result = isLeapYear.CheckYear();
        Console.WriteLine(result);
    }
}