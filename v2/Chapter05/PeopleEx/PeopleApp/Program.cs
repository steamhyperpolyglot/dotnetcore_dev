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
			var p1 = new Person ();
			p1.Name = "Bob Smith";
			p1.DateOfBirth = new System.DateTime ( 1965, 12, 22 );
			p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
			                WondersOfTheAncientWorld.TempleOfArtemisAtEphesus;
			//WriteLine ( $"{p1.Name} was born on {p1.DateOfBirth: dddd, d MMMM yyyy}" );
			WriteLine ( $"{p1.Name}'s favourite wonder is {p1.BucketList}" );
			WriteLine ( $"{p1.Name} is a {Person.Species}." );
			//WriteLine($"{p1.Name} was born on {p1.HomePlanet}");
			p1.WriteToConsole ();
			WriteLine ( p1.GetOrigin () );
			WriteLine ( p1.SayHello () );
			WriteLine ( p1.SayHello ( "Emily" ) );
			WriteLine ( p1.OptionalParameters ( "Jump!", 98.5 ) );

			p1.Children.Add ( new Person {Name = "Alfred"} );
			p1.Children.Add ( new Person {Name = "Zoe"} );
			WriteLine ( $"{p1.Name} has {p1.Children.Count} children:" );
			// for ( int child = 0; child < p1.Children.Count; child++ )
			// {
			//     WriteLine($"  {p1.Children[child].Name}");
			// }
			foreach ( var child in p1.Children )
			{
				WriteLine ( $"  {child.Name}" );
			}

			BankAccount.InterestRate = 0.012M;
			var ba1 = new BankAccount ();
			ba1.AccountName = "Mrs. Jones";
			ba1.Balance = 2400;
			WriteLine ( $"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate:C} interest." );
			var ba2 = new BankAccount ();
			ba2.AccountName = "Ms. Gerrier";
			ba2.Balance = 98;
			WriteLine ( $"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest." );

			var p3 = new Person ();
			WriteLine ( $"{p3.Name} was instantiated at {p3.Instantiated:h:mm:ss tt zz} on {p3.Instantiated:D}" );

			var p4 = new Person ( "Aziz" );
			WriteLine ( $"{p4.Name} was instantiated at {p4.Instantiated:h:mm:ss tt} on {p4.Instantiated:D}" );

			// Tuples
			WriteLine ( "\nUsing Tuples..." );
			Tuple <string, int> fruit4 = p1.GetFruitCS4 ();
			WriteLine ( $"There are {fruit4.Item1} {fruit4.Item2}." );

			// (string, int) fruit7 = p1.GetFruitCS7 ();
			// WriteLine($"{fruit7.Name}, {fruit7.Number} there are.");
			var fruitNamed = p1.GetNamedFruit ();
			WriteLine ( $"Are there {fruitNamed.Number} {fruitNamed.Name}?" );

			// Tuple name inference
			WriteLine ( "\nUsing Tuple name inferencing..." );
			var thing1 = ( "Neville", 4 );
			WriteLine ( $"{thing1.Item1} has {thing1.Item2} children." );
			var thing2 = ( p1.Name, p1.Children.Count );
			WriteLine ( $"{thing2.Name} has {thing2.Count} children." );

			// Deconstructing a Tuple for its individual values.
			WriteLine ( "\nDeconstructing a tuple..." );
			( string fruitName, int fruitNumber ) = p1.GetFruitCS7 ();
			WriteLine ( $"Deconstructed: {fruitName}, {fruitNumber}" );

			// Passing parameters into functions
			int a = 10;
			int b = 20;
			int c = 30;
			WriteLine ( $"Before: a = {a}, b = {b}, c = {c}" );
			p1.PassingParameters ( a, ref b, out c );
			WriteLine ( $"After: a = {a}, b = {b}, c = {c}" );
			int d = 10;
			int e = 20;
			WriteLine ( $"Before: d = {d}, e = {e}, f doesn't exist yet!" );
			p1.PassingParameters ( d, ref e, out int f );
			WriteLine ( $"After: d = {d}, e = {e}, f = {f}" );

			var sam = new Person
			{
				Name = "Sam",
				DateOfBirth = new DateTime ( 1972, 1, 27 )
			};
			WriteLine ( sam.Origin );
			WriteLine ( sam.Greeting );
			WriteLine ( sam.Age );
			sam.FavouriteIceCream = "Chocolate Fudge";
			WriteLine ( $"Sam's favourite ice-cream flavor is {sam.FavouriteIceCream}." );
			sam.FavouritePrimaryColor = "Red";
			WriteLine ( $"Sam's favourite primary color is {sam.FavouritePrimaryColor}." );

			sam.Children.Add ( new Person {Name = "Charlie"} );
			sam.Children.Add ( new Person {Name = "Ella"} );
			WriteLine ( $"Sam's first child is {sam.Children [ 0 ].Name}" );
			WriteLine ( $"Sam's second child is {sam.Children [ 1 ].Name}" );
			WriteLine ( $"Sam's first child is {sam [ 0 ].Name}" );
			WriteLine ( $"Sam's second child is {sam [ 1 ].Name}" );
		}
	}
}