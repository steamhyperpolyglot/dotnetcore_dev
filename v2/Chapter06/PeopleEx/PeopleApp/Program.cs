using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using PacktLibrary;
using static System.Console;

namespace PeopleApp
{
	class Program
	{
		static void Main ( string [] args )
		{
			Person [] people =
			{
				new Person { Name = "Simon" },
				new Person { Name = "Jenny" },
				new Person { Name = "Adam" },
				new Person { Name = "Richard" }
			}; 
			
			WriteLine("Initial list of people:");
			foreach ( var person in people )
			{
				WriteLine($"{person.Name}");
			}
			
			/* WriteLine("Use Person's IComparable implementation to sort:");
			Array.Sort ( people );

			foreach ( var person in people )
			{
				WriteLine($"{person.Name}");
			} */
			WriteLine("Use PersonComparer's IComparer implementation to sort:");
			Array.Sort(people, new PersonComparer());
			foreach(var person in people)
			{
				WriteLine($"{person.Name}");
			}

			// var t = new Thing();
			// t.Data = 42;
			// WriteLine($"Thing: {t.Process("42")}");

			var gt = new GenericThing<int>();
			gt.Data = 42;
			WriteLine($"GenericThing: {gt.Process("42")}");

			string number1 = "4";
			WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");

			byte number2 = 3;
			WriteLine($"{number2} squared is {Squarer.Square<byte>(number2)}");

			// Using structures.
			WriteLine("\nWorking with structures...");

			var dv1 = new DisplacementVector(3, 5);
			var dv2 = new DisplacementVector(-2, 7);
			var dv3 = dv1 + dv2;
			WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");
		}

		// private static void HarryOnShout ( object? sender, EventArgs e )
		// {
		// 	Person p = ( Person ) sender;
		// 	WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
		// }


	}
}