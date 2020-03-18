using System;

namespace NullableExample
{
	class Program
	{
		static void Main ( string [] args )
		{
			int ICannotBeNull = 4;
			int? ICouldBeNull = null;
			Console.WriteLine ( ICouldBeNull.GetValueOrDefault () );
			ICouldBeNull = 4;
			Console.WriteLine ( ICouldBeNull.GetValueOrDefault () );
		}
	}
}