using System;
using System.IO;
using static System.Console;

namespace SwitchWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Research_and_Development\dotnetcore_dev\v2\Chapter03\SwitchWriteFile";
            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            switch(s) {
                case FileStream writeableFile when s.CanWrite:
                    WriteLine("The stream is to a file that I can write to.");
                    break;
                case FileStream readOnlyFile:
                    WriteLine("The stream is to a read-only file.");
                    break;
                case MemoryStream memoryStream:
                    WriteLine("The stream is to a memory address.");
                    break;
                default:
                    WriteLine("The stream is some other type.");
                    break;
                case null:
                    WriteLine("The stream is null.");
                    break;
            }
        }
    }
}
