using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XmlSerializerTest
{
	class Program
	{
		static void Main(string[] args)
		{

			//Address address = new Address();
			//address.Name = "name1";
			//address.City = "city1";

			//XmlSerializer serializer = new XmlSerializer(typeof (Address));

			//StringBuilder builder = new StringBuilder();
			//StringWriter sw = new StringWriter(builder);

			//serializer.Serialize(sw, address);

			//string xml = builder.ToString();

			string xmlStr;
			using (FileStream file = new FileStream(@"D:\Temp\ProductOK.xml", FileMode.Open, FileAccess.Read))
			{
				using (StreamReader sr = new StreamReader(file))
				{
					xmlStr = sr.ReadToEnd();
				}
			}


			string pattern = @"<.*xsi:nil=""true"".*/>";

			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(xmlStr);

			foreach (Match match in matches)
			{
				string value = match.Value;
				Console.WriteLine(value);
			}



			string newXmlStr = regex.Replace(xmlStr, "");

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(newXmlStr);
			xmlDoc.LoadXml(newXmlStr);

			using (FileStream file = new FileStream(@"D:\Temp\ProductOK_new.xml", FileMode.Create, FileAccess.Write))
			{

				using (StreamWriter sw = new StreamWriter(file)) // use UTF8Encoding
				{
					sw.Write(xmlDoc.InnerXml);
				}
			}
		}
	}
}
