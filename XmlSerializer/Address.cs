using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializerTest
{
	[Serializable]
	public class Address
	{
		// The XmlAttribute instructs the XmlSerializer to serialize the 
		// Name field as an XML attribute instead of an XML element (the 
		// default behavior).
		[XmlAttribute]
		public string Name;
		[XmlElement(IsNullable = true)]
		public string Line1;

		// Setting the IsNullable property to false instructs the 
		// XmlSerializer that the XML attribute will not appear if 
		// the City field is set to a null reference.
		[XmlElementAttribute(IsNullable = false)]
		public string City;
		public string State;
		public string Zip;
	}
}
