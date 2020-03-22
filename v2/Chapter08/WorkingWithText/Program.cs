using System;
using System.Text.RegularExpressions;
using System.Reflection;
using static System.Console;

namespace WorkingWithText
{
	class Program
	{
		static void Main ( string [] args )
		{
			string city = "London";
			WriteLine ( $"{city} is {city.Length} characters long." );
			WriteLine($"First char is {city[0]} and third is {city[2]}.");
			
			// Splitting a string into an array.
			WriteLine("\nSplitting a string into an array...");
			string cities = "Paris,Berlin,Madrid,New York";
			string [] citiesArray = cities.Split ( ',' );
			foreach ( string item in citiesArray )
			{
				WriteLine(item);
			}
			
			// Getting a part of a string
			WriteLine("\nUsing Substring() to get a part of a string...");
			string fullname = "Alan Jones";
			int indexOfTheSpace = fullname.IndexOf ( ' ' );
			string firstname = fullname.Substring ( 0, indexOfTheSpace );
			string lastname = fullname.Substring ( indexOfTheSpace + 1 );
			WriteLine($"{lastname}, {firstname}");
			
			// Checking a string for content
			WriteLine("\nChecking a string for contents...");
			string company = "Microsoft";
			bool startsWithM = company.StartsWith ( "M" );
			bool containsN = company.Contains ( "N" );
			WriteLine($"Starts with M: {startsWithM}, contains an N:{containsN}");
			
			// String formatting by positioning
			WriteLine("\nFormatting string by positioning...");
			string fruit = "Apples";
			decimal price = 0.39M;
			DateTime when = DateTime.Today;
			
			WriteLine($"{fruit} cost {price:C} on {when:dddd}s.");
			WriteLine(string.Format ( "{0} cost {1:C} on {2:dddd}s.", fruit, price, when ));

			Write ( "Enter your age: " );
			string input = ReadLine ();
			var ageChecker = new Regex (@"^\d+$");
			if ( ageChecker.IsMatch ( input ) )
			{
				WriteLine("Thank you!");
			}
			else
			{
				WriteLine($"This is not a valid age: {input}");
			}
		}
	}
}