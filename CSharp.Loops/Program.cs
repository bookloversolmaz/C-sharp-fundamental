namespace CSharp.Loops;
// for loop in fizzbuzz:
// class FizzBuzz {     
//     public void Play() {
//         for (int counter = 1; counter <= 100; counter ++) {
//             if (counter % 3 == 0 && counter  % 5 == 0) { // If loops run top to bottom, so 3 and 5 should be first as otherwise a number that meets both criteria will not reach this stage.
//                 Console.WriteLine("FizzBuzz");
//             } else if(counter % 3 == 0) {
//                 Console.WriteLine("Fizz");
//             } else if (counter  % 5 == 0) {
//                 Console.WriteLine("Buzz");
//             } else {
//                 Console.WriteLine(counter);
//             }
//         }
//     }
//     static void Main(string[] args)
//     {
//         FizzBuzz game = new FizzBuzz();
//         game.Play(); //Call the play method with the instance variable defined in game. Don't need writeline as that is already called in play
//     }
// }

// while loop for fizzbuzz
class FizzBuzz {     
    public void Play() {
        int counter = 0;
        while(counter <= 100) {
            if (counter % 3 == 0 && counter  % 5 == 0) { // If loops run top to bottom, so 3 and 5 should be first as otherwise a number that meets both criteria will not reach this stage.
                Console.WriteLine("FizzBuzz");
            } else if(counter % 3 == 0) {
                Console.WriteLine("Fizz");
            } else if (counter  % 5 == 0) {
                Console.WriteLine("Buzz");
            } else {
                Console.WriteLine(counter);
            }
            counter++;
        }
    }
    static void Main(string[] args)
    {
        FizzBuzz game = new FizzBuzz();
        game.Play(); //Call the play method with the instance variable defined in game. Don't need writeline as that is already called in play
    }
}