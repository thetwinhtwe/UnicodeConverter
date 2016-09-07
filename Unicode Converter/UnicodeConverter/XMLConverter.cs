using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Xml;

namespace UnicodeConverter
{
    class XMLConverter
    {
        public static void Convert(string desFile, UnicodeConverter.Converter.ConvertOption convertOption)
        {
            TextConverter.Convert(desFile, convertOption);
            //DataSet ds = readXML(desFile);            
            //int tableCount = ds.Tables.Count;
            //System.Windows.Forms.MessageBox.Show("no of table = " +tableCount);
            //for (int i = 0; i < tableCount; i++)
            //{
            //    DataTable dt = new DataTable();
            //    dt = ds.Tables[i];
            //    for (int x = 0; x < dt.Rows.Count; x++)
            //    {
            //        for (int y = 0; y < dt.Columns.Count; y++)
            //        {
            //            string xmlTxt = dt.Rows[x][y].ToString();
            //            string desTxt = UniConversion.Converter.Convert(xmlTxt, convertOption);
            //            dt.Rows[x][y] = desTxt;
            //        }
            //    }
            //    dt.EndInit();
            //}
            
            //ds.AcceptChanges();
            //ds.WriteXml(desFile);
            //openXmlFile(desFile);
        }


        public static void ConvertSimpleXml(string srcFile, string desFile, UnicodeConverter.Converter.ConvertOption convertOption)
        {
            StringBuilder StrBil = new StringBuilder();

            XmlTextReader reader = new XmlTextReader(srcFile);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {

                    case XmlNodeType.Element: // The node is an element.
                        StrBil.Append("<" + reader.Name);
                        while (reader.MoveToNextAttribute()) // Read the attributes.
                        {
                            StrBil.Append(" " + reader.Name + "=\"" + reader.Value + "\"");
                        }
                        StrBil.Append(">");
                        break;

                    case XmlNodeType.Text:
                      //  StrBil.Append(UnicodeConverter.Converter.Convert(reader.Value, convertOption));
                        StrBil.Append(UnicodeConverter.Converter.Convert(reader.Value, convertOption));
                        break;
                    case XmlNodeType.EndElement:
                        StrBil.Append("</" + reader.Name + ">" + "\r\n");
                        break;
                    case XmlNodeType.Comment:
                        StrBil.Append("<!--" + reader.Value + "-->");
                        break;
                    case XmlNodeType.XmlDeclaration:
                        StrBil.Append("<?" + reader.Name);
                        while (reader.MoveToNextAttribute()) // Read the attributes.
                        {
                            StrBil.Append(" " + reader.Name + "=\"" + reader.Value + "\"");
                        }
                        StrBil.Append("?>");
                        break;
                    case XmlNodeType.Document: break;

                    case XmlNodeType.DocumentType:
                        StrBil.Append("<!DOCTYPE" + reader.Name + "[" + reader.Value + "]");
                        break;
                    case XmlNodeType.EntityReference:
                        StrBil.Append(reader.Name);
                        break;
                    case XmlNodeType.CDATA:
                        StrBil.Append("<![CDATA[" + UnicodeConverter.Converter.Convert(reader.Value, convertOption) + "]]>");
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        StrBil.Append("<?" + reader.Name + " " + reader.Value + "?>");
                        break;

                }

            }
            reader.Close();

            StreamWriter sw = new StreamWriter(desFile);
            sw.Write(StrBil);
            sw.Close();
        }



        public static DataSet readXML(string fileName)
        {            
            DataSet ds = new DataSet();            
            FileStream fs = new FileStream(fileName, FileMode.Open);            
            ds.ReadXml(fs);
            fs.Close();
            return ds;
        }

        public static void openXmlFile(string fileName)
        {
            System.Diagnostics.Process openingTxtFile = new System.Diagnostics.Process();
            openingTxtFile.StartInfo.FileName = fileName;
            openingTxtFile.Start();
        }
    }
}