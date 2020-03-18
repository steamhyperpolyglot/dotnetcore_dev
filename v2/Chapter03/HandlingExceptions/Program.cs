﻿using System;
using static System.Console;

namespace HandlingExceptions
{
	class Program
	{
		static void Main ( string [] args )
		{
			WriteLine ( "Before parsing" );
			WriteLine ( "What is your age? " );
			string input = ReadLine ();
			try
			{
				int age = int.Parse ( input );
				WriteLine ( $"You are {age} years old." );
			}
			catch ( FormatException )
			{
				WriteLine("The age you entered is not a valid number format.");
			}
			catch (Exception ex)
			{
				WriteLine($"{ex.GetType ()} says {ex.Message}");
			}
			WriteLine("After parsing");
		}
	}
}