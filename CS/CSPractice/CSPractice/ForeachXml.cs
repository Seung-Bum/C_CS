using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CSPractice
{   
    internal class ForeachXml
    {

        public void foreachXml()
        {
            //Read the XML file.
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("C:\\test.xml");

                XmlNode node = doc.SelectSingleNode("grid");

                Console.WriteLine(node.InnerXml); // 최상위 노드

                foreach (XmlNode coordinate in node)
                {
                    Console.WriteLine(coordinate.LocalName); // coordinate => LocalName은 Attribute의 이름
                    Console.WriteLine(coordinate.Attributes[0].Value); // 78 => Value는 Attribute의 값

                    foreach (XmlNode coordinateNode in coordinate)
                    {
                        Console.WriteLine(coordinateNode.LocalName);
                        Console.WriteLine(coordinateNode.InnerText);
                    }
                };


            }
            catch (XmlException e)
            {
                throw;
            }


        }
    }
}



/*
 * test.xml
 * 
<? xml version = "1.0" encoding = "UTF-8" ?>
< grid >
    < coordinate time = "78" >
        < initial > 540:672 </ initial >
        < final > 540:672 </ final >
    </ coordinate >
</ grid >
*/