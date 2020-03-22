using System;
using System.Numerics;
using static System.Console;

namespace WorkingWithNumbers
{
	class Program
	{
		static void Main ( string [] args )
		{
			var largestLong = ulong.MaxValue;
			WriteLine ($"{largestLong,40:N0}");

			var atomsInTheUniverse = BigInteger.Parse ( "123456789012345678901234567890" );
			WriteLine($"{atomsInTheUniverse,40:N0}");
		}
	}
}