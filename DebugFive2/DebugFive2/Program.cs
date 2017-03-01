using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugFive2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ITEM209 = "209";
            const string ITEM312 = "312";
            const string ITEM414 = "414";
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
            double price;
            Write("Please enter the stock number of the item you want ");
            var stockNum = Convert.ToInt32(ReadLine());
            while (stockNum != Convert.ToInt32(ITEM209) && stockNum != Convert.ToInt32(ITEM312) && stockNum != Convert.ToInt32(ITEM414))
            {
                WriteLine("Invalid stock number. Please enter again. ");
                stockNum = Convert.ToInt32(ReadLine());
            }
            if (stockNum == Convert.ToInt32(ITEM209))
                price = PRICE209;
            else
               if (stockNum == Convert.ToInt32(ITEM312))
                price = PRICE414;
            else
                price = PRICE312;
            WriteLine("The price for item # {0} is {1}", stockNum, price);
        }
    }
}
