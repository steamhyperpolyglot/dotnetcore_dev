using System;
using static System.Console;

namespace CastingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 10;
            // double b = a;
            // WriteLine(b);

            // double c = 9.8;
            // int d = (int) c;
            // WriteLine(d);

            long e = 10;
            int f = (int) e;
            WriteLine($"e is {e} and f is {f}");
            e = long.MaxValue;
            f = (int) e;
            WriteLine($"e is {e} and f is {f}");
        }
    }
}
