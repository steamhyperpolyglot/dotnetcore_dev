using Microsoft.EntityFrameworkCore;

namespace WorkingWithEFCore.Models
{
	public class Northwind : DbContext
	{
		// these properties map to tables in the database
		public DbSet <Category> Categories { get; set; }
		public DbSet <Product> Products { get; set; }

		protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
		{
			optionsBuilder.UseSqlServer ( @"Data Source=LAPTOP-E19S17S4; Initial Catalog=Northwind; "
			                              + "User Id=sa; Password=pa55w0rd" );
		}

		protected override void OnModelCreating ( ModelBuilder modelBuilder )
		{
			modelBuilder.Entity <Category> ()
				.Property ( category => category.CategoryName )
				.IsRequired ()
				.HasMaxLength ( 40 );
			
			// global filter to remove discontinued products
			modelBuilder.Entity <Product> ().HasQueryFilter ( p => !p.Discontinued );
		}
	}
}