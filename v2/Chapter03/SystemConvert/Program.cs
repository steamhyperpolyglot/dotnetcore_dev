using System;
using static System.Console;
using static System.Convert;

namespace SystemConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            // double g = 9.8;
            // int h = ToInt32(g);
            // WriteLine($"g is {g} and h is {h}");

            // Rounding up/down numbers
            double i = 9.49;
            double j = 9.5;
            double k = 10.49;
            double l = 10.5;
            WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
            WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
            WriteLine($"k is {k}, ToInt(k) is {ToInt32(k)}");
            WriteLine($"l is {l}, ToInt(l) is {ToInt32(l)}");
            WriteLine();

            // Converting to string
            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());
        }
    }
}
