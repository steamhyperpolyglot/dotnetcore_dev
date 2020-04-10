using System;
using System.Linq;
using static System.Console;

namespace LinqWithObjects
{
	class Program
	{
		static void LinqWithArrayOfStrings()
		{
			var names = new string [] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };
			//var query = names.Where ( new Func <string, bool> (NameLongerThanFour) );
			//var query = names.Where ( NameLongerThanFour );
			// using lambda expression
			var query = names.Where ( name => name.Length > 4 )
				.OrderBy ( name => name.Length ).ThenBy ( name => name );
			
			foreach ( string item in query )
			{
				WriteLine ( item );
			}
		}

		static bool NameLongerThanFour ( string name )
		{
			return name.Length > 4;
		}
		
		static void Main ( string [] args )
		{
			LinqWithArrayOfStrings ();
		}
	}
}