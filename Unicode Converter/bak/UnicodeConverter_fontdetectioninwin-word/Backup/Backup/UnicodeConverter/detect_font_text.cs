using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
namespace UnicodeConverter
{
    class detect_font_text
    {
        public void DetectFontText(string openFilePath, string savefile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(openFilePath);
            XmlElement root = doc.DocumentElement;
            string tt = "";
            XmlNodeList nodes1 = doc.GetElementsByTagName("w:defaultFonts");
            try
            {
                tt = nodes1[0].Attributes.GetNamedItem("w:ascii").Value;
            }
            catch (Exception ex)
            {
                tt = "Calibri";
                Console.WriteLine(ex.Message);
            }

            XmlNodeList nodes = doc.GetElementsByTagName("w:r");//Getting Nodelist from input XML file. w:r is node tag name
            XmlNode LastNode;
             foreach (XmlNode node in nodes)
            {
                XmlNode FirstNode = node.FirstChild;
                LastNode = node.LastChild;
                string t2 = LastNode.InnerText;
                 try
                {
                    tt = FirstNode.FirstChild.Attributes.GetNamedItem("w:ascii").Value;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
         
        }

    }
}
