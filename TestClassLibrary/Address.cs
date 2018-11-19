using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
	public class Address
	{
		public bool IsDefault { get; set; }
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public string AddressLine3 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		public string Telephone { get; set; }
		public int Sequence { get; set; }
		public int Category { get; set; }
		public string CategoryDesc { get; set; }
		public string ContactName { get; set; }
		public string ContactPhone { get; set; }
		public bool Deactivate { get; set; }
		public bool Blockship { get; set; }
		//public Country Country { get; set; }
		public string CategoryCode { get; set; }
		//public AddressType AddressType { get; set; }
		public bool CanContact { get; set; }
	}
}
