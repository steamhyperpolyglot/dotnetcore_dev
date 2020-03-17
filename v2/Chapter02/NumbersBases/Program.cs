using System;

namespace NumbersBases
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b0001_1110_1000_0100_1000_0000;   // 2 million
            int hexadecimalNotation = 0x001E_8480;                  // 2 million
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
        }
    }
}
