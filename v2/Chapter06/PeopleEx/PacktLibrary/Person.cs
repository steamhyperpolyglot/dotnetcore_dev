﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace PacktLibrary
{
	public partial class Person : object, IComparable<Person>
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

		public void TimeTravel(DateTime when)
		{
			if (when <= DateOfBirth)
			{
				throw new PersonException("If you travel back in time to a date " + 
					"earlier than your own birth then the universe will explode!");
			}
			else {
				WriteLine($"Welcome to {when:yyyy}!");
			}
		}

		// override methods
		public override string ToString()
		{
			return $"{Name} is a {base.ToString()}";
		}

		// methods to "multiply"
		public static Person Procreate ( Person p1, Person p2 )
		{
			var baby = new Person
			{
				Name = $"Baby of {p1.Name} and {p2.Name}"
			};

			p1.Children.Add ( baby );
			p2.Children.Add ( baby );
			return baby;
		}

		public static Person operator * ( Person p1, Person p2 )
		{
			return Procreate ( p1, p2 );
		}

		public Person ProcreateWith ( Person partner )
		{
			return Procreate ( this, partner );
		}
		
		// method with a local function
		public static int Factorial ( int number )
		{
			if ( number < 0 )
			{
				throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
			}

			return localFactorial ( number );

			int localFactorial ( int localNumber )
			{
				if ( localNumber < 1 ) return 1;
				return localNumber * localFactorial ( localNumber - 1 );
			}
		}
		
		// event
		public event EventHandler Shout;
		
		// field
		public int AngerLevel;
		
		// method
		public void Poke()
		{
			AngerLevel++;
			if ( AngerLevel >= 3 )
			{
				// if something is listening...
				if ( Shout != null )
				{
					// ... then raise the event
					Shout(this, EventArgs.Empty);
				}
			}
		}

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}