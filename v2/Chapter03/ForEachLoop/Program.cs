using System;
using System.Collections;
using static System.Console;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Adam", "Barry", "Charlie" };
            /* foreach(string name in names) {
                WriteLine($"{name} has {name.Length} characters.");
            } */
            
            // Now we use an Enumerator
            IEnumerator e = names.GetEnumerator();
            while (e.MoveNext()) {
                string name = (string) e.Current;   // Current is read-only!
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
