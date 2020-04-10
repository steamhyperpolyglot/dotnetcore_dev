using Microsoft.EntityFrameworkCore;

namespace LinqWithEFCore
{
	// this manages the connection to the database
	public class Northwind : DbContext
	{
		// these properties map to tables in the database
		public DbSet<Category> Categories { get; set; }

		public DbSet <Product> Products { get; set; }

		protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
		{
			optionsBuilder.UseSqlServer ( @"Data Source=LAPTOP-E19S17S4; Initial Catalog=Northwind; "
			                              + "User Id=sa; Password=pa55w0rd" );
		}
	}
}