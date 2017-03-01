// Finds whether a book dealer carries a requested book
using System;
using static System.Console;
class DebugSix03
{
    static void Main()
    {
        String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
        Write("What book are you looking for? ");
        var entryString = Console.ReadLine();
        var x = Array.BinarySearch(books, entryString);
        WriteLine(x < 0 ? "{0} not found" : "Yes, we carry {0}", entryString);
    }
}
