using System;
using System.Collections.Generic;
using static System.Console;

namespace PacktLibrary
{
	public partial class Person : object
	{
		// fields
		public string Name;
		public DateTime DateOfBirth;
		public WondersOfTheAncientWorld BucketList;

		public const string Species = "Homo Sapien";

		// read-only fields
		public readonly string HomePlanet = "Earth";
		public readonly DateTime Instantiated;

		public List <Person> Children = new List <Person> ();

		// constructors
		public Person()
		{
			// set default values for fields
			// including read-only fields
			Name = "Unknown";
			Instantiated = DateTime.Now;
		}

		public Person ( string initialName )
		{
			Name = initialName;
			Instantiated = DateTime.Now;
		}

		// methods
		public void WriteToConsole()
		{
			WriteLine ( $"{Name} was born on {DateOfBirth:D}" );
		}

		public string GetOrigin()
		{
			return $"{Name} was born on {HomePlanet}.";
		}

		public Tuple <string, int> GetFruitCS4()
		{
			return Tuple.Create ( "Apples", 5 );
		}

		// the new C# 7 syntax and new System.ValueTuple type
		public (string, int) GetFruitCS7()
		{
			return ( "Apples", 5 );
		}

		public (string Name, int Number) GetNamedFruit()
		{
			return ( Name: "Apples", Number: 5 );
		}

		public string SayHello()
		{
			return $"{Name} says 'Hello!'";
		}

		public string SayHello ( string name )
		{
			return $"{Name} says 'Hello {name}!'";
		}
		
		// Optional parameters
		public string OptionalParameters ( string command = "Run!", double number = 0.0, bool active = true )
		{
			return $"command is {command}, number is {number}, active is {active}";
		}
		
		// Passing parameters in 3 different ways
		public void PassingParameters ( int x, ref int y, out int z )
		{
			z = 99;

			x++;
			y++;
			z++;
		}
	}
}