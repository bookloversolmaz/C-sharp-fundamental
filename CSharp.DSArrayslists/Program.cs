namespace CSharp.DSArrayslists;
using System;
// class ReadingList {
// internal string[] unread; // Declared an array of strings
//     internal ReadingList(string[] unread){
//         this.unread = unread;
//     }
//     public string[] Add(string bookTitle) {
//         // Takes string book title and adds to the first empty slot in unread array
//         // Use for each loop to iterate through array, using the fixed length of the array to limit the for loop
//         // find the empty slot whereby slot = ""
//         // counter equals starting point, so 0; counter is limited by length of array, iterate to final slot
//         int counter = 0;
//         for (counter = 0; counter < unread.Length; counter ++) {
//             // checked if slot is empty
//             if (unread[counter] == "") {
//                 // Add string into empty slot
//                 unread[counter] = bookTitle;
//                 // exit loop after adding book
//                 break;
//             }

//         }
//         return unread;
//     }
//     static void Main(string[] args)
//     {
//         // Unlike strings, the instance field here is a variable, not the value itself. Pass in the value rather than initialising a variable
//         // Create instance of class
//         ReadingList NewReadingList = new ReadingList(new string[5] { "", "Harry Potter", "", "Lord of the Rings", "" });
//         string[] newBook = NewReadingList.Add("book1"); //create instance field
//         // Unlike strings, arrays can't be printed directly.
//         // Printing newbook only will print the type name
//         // Use join to iterate over array and concatenate strings with a comma in between and return a single string
//         Console.WriteLine(string.Join(", ", newBook));
//     }

// }

class Queue {


}
