using System;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Xml;
using System.Windows.Forms;

namespace UnicodeConverter
{
    class WordConverter
    {
        public static void Convert(Word.Application wordApp, UnicodeConverter.Converter.ConvertOption option)
        {
            Label lbl = new Label();
            lbl.Text = "Loading ....";
            string srcTxt = wordApp.ActiveDocument.Content.Text;

            string uniTxt = UnicodeConverter.Converter.Convert(srcTxt, option);
          
            wordApp.ActiveDocument.Content.Text = uniTxt;

            // set "Myanmar3"to default sript name
            wordApp.ActiveDocument.Content.Font.Name = "Myanmar3";

            // set "Myanmar3"to Complex Script name
            wordApp.ActiveDocument.Content.Font.NameBi = "Myanmar3";
     
        } // end of Convert()

        public static void Convert(String wordFilePath, UnicodeConverter.Converter.ConvertOption option, String saveFilePath)
        {            
            //UniConversion.Converter.ConvertOption.
            WordXML_Utilities uti = new WordXML_Utilities();
            String xmlFile = uti.ConvertToXML(wordFilePath);
            Logging.logger += "Converting XML :: " + "\n";

            //Logging.logger += "wordFilePath is : " + wordFilePath + "\n";
            //Console.WriteLine("wordFilePath is : " + wordFilePath);
           // Logging.logger += "saveFilePath is : " + saveFilePath + "\n";
            //Console.WriteLine("saveFilePath is : " + saveFilePath);
            //Logging.logger += "xmlFilePath is : " + xmlFile + "\n";
            //Console.WriteLine("xmlFilePath is : " + xmlFile);

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
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
                Logging.logger += "UnicodeConverter.Convert().[tt = nodes1[0].Attributes.GetNamedItem(w:ascii).Value] give Error:::: " + ex.Message + "\n";
            }

            XmlNodeList nodes = doc.GetElementsByTagName("w:r");//Getting Nodelist from input XML file. w:r is node tag name
            XmlNode LastNode;
            XmlNode newnodetext;
            string uniTxt = "";

            UnicodeConverter.Converter.ConvertOption fontobj = new UnicodeConverter.Converter.ConvertOption();
            fontobj = UnicodeConverter.Converter.ConvertOption.Academy2Uni;
            
            string[] strarr = new string[15];

            for (int i = 0; i < strarr.Length; i++)
            {
                // Adding fonts names into strarr array
                strarr[i] = fontobj.ToString().Substring(0, fontobj.ToString().LastIndexOf('2'));
                if (strarr[i] == "ATypeWriter")
                {
                    strarr[i] = "A_Type Writer";
                }
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
             //       tt = FirstNode.FirstChild.Attributes.GetNamedItem("w:val").Value;
             
                }
                catch (Exception ex)
                {
                    tt = "Times New Roman";
                    Logging.logger += "UnicodeConverter.Convert() [tt = FirstNode.FirstChild.Attributes.GetNamedItem(w:ascii).Value;] give Error:::: " + ex.Message + "\n";
                }

                for (int j = 0; j < strarr.Length; j++)
                {
                    try
                    {
                        // check fonts name in tt is equals to one of the names of strarr

                        //if (tt == "A_Type Writer")
                        //{
                        //    uniTxt = UnicodeConverter.Converter.Convert(t2, UnicodeConverter.Converter.ConvertOption.ATypeWriter2Uni);
                        //}
                        if (tt.Contains(strarr[j]))
                        {
                            if (tt == "I")
                            {
                                uniTxt = UnicodeConverter.Converter.Convert(t2, UnicodeConverter.Converter.ConvertOption.I2Uni);
                              
                            }
                            else if (tt == "A_Type Writer")
                            {
                                uniTxt = UnicodeConverter.Converter.Convert(t2, UnicodeConverter.Converter.ConvertOption.ATypeWriter2Uni);
                            }
                            else if(tt =="Gandamar Letter 1" || tt=="Gadamar-Letter 1")
                            {
                                uniTxt = UnicodeConverter.Converter.Convert(t2, UnicodeConverter.Converter.ConvertOption.Gandamar2Uni);
                            }
                            else if (tt.Substring(0, 6).Equals("Metrix") || tt.Substring(1, 6).Equals("Metrix"))
                            {
                                uniTxt = UnicodeConverter.Converter.Convert(t2, UnicodeConverter.Converter.ConvertOption.Metrix2Uni);
                            }
                            else if (tt.Substring(0, 3).Equals("Win") || tt.Substring(1, 3).Equals("Win"))
                            {
                                uniTxt = UnicodeConverter.Converter.Convert(t2, UnicodeConverter.Converter.ConvertOption.Win2Uni);

                            }
                            else if (tt.Substring(0, 2).Equals("CE"))
                            {
                                uniTxt = UnicodeConverter.Converter.Convert(t2, UnicodeConverter.Converter.ConvertOption.CE2Uni);
                                //uniTxt = UniConversion.Converter.Convert(t2, UniConversion.Converter.ConvertOption.Win2Uni);
                            }
                            else if (tt.Contains("Myanmar"))
                            {
                                if (tt.Contains("M-Myanmar"))
                                {
                                    uniTxt = UnicodeConverter.Converter.Convert(t2, UnicodeConverter.Converter.ConvertOption.MMyanmar2Uni);
                                }
                                else
                                {
                                    uniTxt = UnicodeConverter.Converter.Convert(t2, UnicodeConverter.Converter.ConvertOption.Myanmar12Uni);
                                }
                            }
                            else
                            {
                                UnicodeConverter.Converter.ConvertOption temp = (UnicodeConverter.Converter.ConvertOption)j;
                                //Console.WriteLine("tt font name: " + tt + " con option : " + temp);  //
                                uniTxt = UnicodeConverter.Converter.Convert(t2, temp);
                            }
                            break;
                        }
                        else
                        {
                            uniTxt = t2;
                        }

                    }
                    catch (Exception ex)
                    {
                        Logging.logger += "UnicodeConverter.Convert() [if (tt.Contains(strarr[j]))] give Error:::: " + ex.Message + "\n";
                    }
                }

                newnodetext.InnerText = uniTxt;
                try
                {
                    root.ReplaceChild(newnodetext, LastNode); //Update combined result to Old XML file 
                }
                catch (Exception ex)
                {
                    Logging.logger += "UnicodeConverter.Convert() [ root.ReplaceChild(newnodetext, LastNode)] give Error:::: " + ex.Message + "\n";
                }
            }

            //string tem = System.IO.Directory.GetCurrentDirectory();
            string tem = saveFilePath.Substring(0, saveFilePath.LastIndexOf('\\'));
            string savename = tem + "\\finishxml.xml";
            doc.Save(savename);
         
            uti.SaveToDoc(savename, saveFilePath);

        }

    }
}
