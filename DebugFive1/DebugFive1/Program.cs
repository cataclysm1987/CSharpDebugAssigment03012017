using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugFive1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PASS1 = "home";
            const string PASS2 = "lady";
            const string PASS3 = "mouse";

            Write("Please enter your password ");
            var password = ReadLine();
            for (int i = 0; i <= 10; ++i)
            {
                if (i == 10)
                {
                    WriteLine("You failed to enter a valid password. Exiting program.");
                    Environment.Exit(0);
                }
                if (password != PASS1 && password != PASS2 && password != PASS3)
                {
                    WriteLine("Invalid password. Please enter again. ");
                    password = ReadLine();
                }
                else
                {
                    WriteLine("Valid password");
                    break;
                }
                
            }
            
            
        }
    }
}
