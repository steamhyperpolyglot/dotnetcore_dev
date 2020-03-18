using System;
using static System.Console;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 0;
            while (x < 10) {
                WriteLine(x);
                x++;
            } */

            string password = string.Empty;
            do {
                Write("Enter your password: ");
                password = ReadLine();
            } while (password != "secret");
        }
    }
}
