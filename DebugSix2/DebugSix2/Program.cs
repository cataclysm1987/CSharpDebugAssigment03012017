// Program averages four numbers
using static System.Console;
class DebugSix02
{
    static void Main()
    {
        int[] numbers = { 12, 15, 22, 88 };
        double total = 0;
        Write("\nThe numbers are...");
        foreach (int t in numbers)
            Write("{0, 6}", t);
        WriteLine();
        foreach (int t in numbers)
        {
            total += t;
        }
        var average = total / numbers.Length;
        WriteLine("The average is {0}", average);
    }
}