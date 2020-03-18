using System;
using static System.Console;

namespace CheckingForOverflow
{
	class Program
	{
		static void Main ( string [] args )
		{
			try
			{
				int x = int.MaxValue - 1;
				WriteLine ( x );
				x++;
				WriteLine ( x );
				x++;
				WriteLine ( x );
				x++;
				WriteLine ( x );
			}
			catch ( OverflowException )
			{
				WriteLine("The code overflowed but I caught the exception.");
			}
			
		}
	}
}