using System;
using System.IO;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace WorkWithText
{
    class Program
    {
        // define an array of Viper pilot call signs
        static string[] callsigns = new string[] { "Husker", "Starbuck",
            "Apollo", "Boomer", "Bulldog", "Athena", "Helo", "Racetrack" };

        static void WorkWithText() {
            // define a file to write to
            string textFile = Combine(CurrentDirectory, "streams.txt");

            // create a text file and return a helper writer
            StreamWriter text = File.CreateText(textFile);

            // enumerate the strings, writing each one
            // to the stream on a separate line
            foreach(string item in callsigns) {
                text.WriteLine(item);
            }
            text.Close();       // release resources

            // Output the contents of the file to the Console
            WriteLine($"{textFile} contains {new FileInfo(textFile).Length} bytes.");
            WriteLine(File.ReadAllText(textFile));
        }

        static void Main(string[] args)
        {
            WorkWithText();
        }
    }
}
