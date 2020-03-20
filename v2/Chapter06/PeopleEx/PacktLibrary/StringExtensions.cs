using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace PacktLibrary
{
	public class StringExtensions
	{
		public static bool IsValidEmail(string input)
		{
			// use simple regular expression to check
			// that the input string is a valid email.
			return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
		}
	}
}
