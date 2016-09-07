using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace UnicodeConverter
{
    class XMLConverter
    {
        public static void Convert(string desFile, UniConversion.Converter.ConvertOption convertOption)
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