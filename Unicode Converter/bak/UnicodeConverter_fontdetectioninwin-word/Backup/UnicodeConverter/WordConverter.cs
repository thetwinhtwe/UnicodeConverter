using System;
using System.Collections.Generic;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Xml;
      
namespace UnicodeConverter
{
    class WordConverter
    {
       //public static void Convert(Word.Application wordApp, UniConversion.Converter.ConvertOption option)
        //{
        //string srcTxt = wordApp.ActiveDocument.Content.Text;
        //string uniTxt = UniConversion.Converter.Convert(srcTxt, option);
        //wordApp.ActiveDocument.Content.Text = uniTxt;
        // set "Myanmar3"to default sript name
        //wordApp.ActiveDocument.Content.Font.Name = "Myanmar3";
        // set "Myanmar3"to Complex Script name
        //wordApp.ActiveDocument.Content.Font.NameBi = "Myanmar3";
      // }
        //**********************************************************
        public static void Convert(string openFilePath, UniConversion.Converter.ConvertOption    )
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
            XmlNode newnodetext;
            string uniTxt = "";
            UniConversion.Converter.ConvertOption fontobj = new UniConversion.Converter.ConvertOption();
            fontobj = UniConversion.Converter.ConvertOption.Amyanmar2Uni;
            string[] strarr = new string[7];
            for (int i = 0; i < 7; i++)
            {
                strarr[i] = fontobj.ToString().Substring(0, fontobj.ToString().LastIndexOf('2'));
                fontobj++;
            }
            foreach (XmlNode node in nodes)
            {
                XmlNode FirstNode = node.FirstChild;
                LastNode = node.LastChild;
                newnodetext = node.LastChild;
                string t2 = LastNode.InnerText;
                try
                {
                    tt = FirstNode.FirstChild.Attributes.GetNamedItem("w:ascii").Value;
               }
                catch(Exception ex) 
                {
                    tt = "Times New Roman";
                    Console.WriteLine(ex.Message );
                }
                for (int j = 0; j < strarr.Length; j++)
                {
                    try
                    {
                        if (tt.Contains(strarr[j]))
                        {
                            UniConversion.Converter.ConvertOption temp = (UniConversion.Converter.ConvertOption)j;
                            uniTxt = UniConversion.Converter.Convert(t2, temp);
                            break;
                            }
                        else
                        {
                            uniTxt = t2;
                         }
                      
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
               newnodetext.InnerText = uniTxt;
                try
                {
                    root.ReplaceChild(newnodetext, LastNode);//Update combined result to Old XML file 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            string tem = System.IO.Directory.GetCurrentDirectory();
            string  savename = tem + "\\finishxml.xml";
             doc.Save(savename);
            
            
        }
    }
}
