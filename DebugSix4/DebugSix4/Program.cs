// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using System.Collections.Generic;
using static System.Console;
class DebugSix04
{
    public static void Main()
    {
        const int QUIT = 999;
        List<int> numbers = new List<int>();
        double total = 0;
        int num = 0;
        Console.Write("Please enter a number or " +
           QUIT + " to quit...");
        try
        {
            num = Convert.ToInt32(ReadLine());
            numbers.Add(num);
            total += num;
        }
        catch (SystemException)
        {
            WriteLine("Error. Invalid number. Exiting program. Bye.");
            Environment.Exit(0);
        }
        while (num != QUIT)
        {
            Write("Please enter a number or " +
               QUIT + " to quit...");
            try
            {
                num = Convert.ToInt32(ReadLine());
                if (num != QUIT)
                {
                    numbers.Add(num);
                    total += num;
                }
            }
            catch (SystemException)
            {
                WriteLine("Error. Invalid number. Exiting program.");
                Environment.Exit(0);
            }

        }
        WriteLine("The numbers are:");
        foreach (int number in numbers)
            Console.Write("{0,6}", number);
        var average = total / numbers.Count;
        WriteLine();
        WriteLine("The average is {0}", average);
    }
}
