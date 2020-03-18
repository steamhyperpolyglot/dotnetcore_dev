using System;
using static System.Console;
using static System.Convert;

namespace BinaryObjToString
{
    class Program
    {
        static void Main(string[] args)
        {
            // allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            // populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            WriteLine("Binary Object as bytes:");
            for (int index = 0; index < binaryObject.Length; index++) {
                Write($"{binaryObject[index]:X} ");
            }
            WriteLine();

            // convert to Base64 string
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}");
        }
    }
}
