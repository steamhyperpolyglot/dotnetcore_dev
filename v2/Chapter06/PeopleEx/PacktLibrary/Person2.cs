namespace PacktLibrary
{
	public partial class Person
	{
		public string Origin
		{
			get { return $"{Name} was born on {HomePlanet}"; }
		}

		// two properties defined using C# 6+ lambda expression syntax
		public string Greeting => $"{Name} says 'Hello!'";

		public int Age => ( int ) ( System.DateTime.Today.Subtract ( DateOfBirth ).TotalDays / 365.25 );

		public string FavouriteIceCream { get; set; }

		private string favouritePrimaryColor;

		public string FavouritePrimaryColor
		{
			get { return favouritePrimaryColor; }
			set
			{
				switch ( value.ToLower () )
				{
					case "red":
					case "green":
					case "blue":
						favouritePrimaryColor = value;
						break;
					default:
						throw new System.ArgumentException ( $"{value} is not a primary color. " +
						                                     "Choose from: red, green, blue" );
				}
			}
		}

		public Person this [ int index ]
		{
			get => Children [ index ];
			set => Children [ index ] = value;
		}

		
	}
}