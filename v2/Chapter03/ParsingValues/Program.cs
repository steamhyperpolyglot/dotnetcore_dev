using System;
using static System.Console;

namespace ParsingValues
{
	class Program
	{
		static void Main ( string [] args )
		{
			int age = int.Parse("27");
			DateTime birthday = DateTime.Parse("15 September 1982");
			WriteLine($"I was born {age} years old.");
			WriteLine($"My birthday is {birthday}.");
			WriteLine($"My birthday is {birthday:D}.");

			Write ( "How many eggs are there? " );
			int count;
			string input = ReadLine ();
			if ( int.TryParse ( input, out count ) )
			{
				WriteLine($"There are {count} eggs.");
			}
			else
			{
				WriteLine("I could not parse the input.");
			}
		}
	}
}
