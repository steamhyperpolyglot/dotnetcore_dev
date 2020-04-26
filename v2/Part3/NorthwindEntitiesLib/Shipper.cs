using System.Collections.Generic;

namespace NorthwindEntitiesLib
{
	public class Shipper
	{
		public int ShipperID { get; set; }
		public string shipperName { get; set; }
		public string Phone { get; set; }
		public ICollection<Order> Orders { get; set; }
	}
}