using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CSPractice
{   
    //C:\Users\SeungBum\Desktop
    internal class ForeachXml
    {
        
        public void foreachXml()
        {
            //Read the XML file.

            XmlDocument doc = new XmlDocument();
            doc.Load("c:\\test.xml");

            XmlNode node = doc.DocumentElement.SelectSingleNode("grid");

            foreach (var coordinate in node)
            {
                Console.WriteLine(coordinate);
                //this.coordinates[this.counter][0] = coordinate.Attribute("time").Value;
                //this.coordinates[this.counter][1] = coordinate.Element("initial").Value;
                //this.coordinates[this.counter][2] = coordinate.Element("final").Value;
                //this.counter++;
            };
        }



    }
}
