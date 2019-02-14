using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
// to use XML 
using System.Xml.Linq;
using System.Xml;

namespace labs_09_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMost Basic XML element\n");
            var xm101 = new XElement("test", 1);// => test is the name of the field and 1 is the value of data. 
            Console.WriteLine(xm101);

            Console.WriteLine("\nNow add sub-element\n");
            var xm102 = new XElement("RootElement",
                new XElement("SubElement", 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100));
            Console.WriteLine(xm102);

            Console.WriteLine("\nNow add Attributes\n");
            var xm103 = new XElement("RootElement",
                new XElement("SubElement", 
                    new XAttribute ("Height", 500), 100),
                new XElement("SubElement", 100),
                new XElement("SubElement", 100));
            Console.WriteLine(xm103);

            Console.WriteLine("\nNow add Attributes\n");
            var xm104 = new XElement("RootElement",
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100));
            Console.WriteLine(xm104);

            Console.WriteLine("\nNow save to a doc\n");
            var xm105 = new XElement("RootElement",
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100),
                new XElement("SubElement", new XAttribute("Height", 500), 100));
            Console.WriteLine(xm105);
            // Xdocument which saves to file
            var doc06 = new XDocument(XElement.Parse(xm105.ToString()));
            doc06.Save("xm106.xml");


            //readXml.WriteTo();
            Console.WriteLine("\noutput the content\n");
            var doc7 = XDocument.Load("xm106.xml");
            Console.WriteLine(doc7);
        }
    }
}
