using System.Collections.Generic;

namespace CSharp_Practice
{
	public class Customer
	{
		public int Id;
		public string Name;
		public List<Order> Orders;

		public Customer()
		{
			Orders = new List<Order>(); // If you have a class with a list. Make sure it is always initialized.
		}

		public Customer(int id)
			:this() // Initializes list by making sure the constructor without parameters is called with this one. Keep the usage of this to a minimum.
		{
			this.Id = id;
		}

		public Customer(int id, string name)
			:this(id) // Initializes id, by using contructor that takes id.
		{
			this.Name = name;
		}
	}
}
