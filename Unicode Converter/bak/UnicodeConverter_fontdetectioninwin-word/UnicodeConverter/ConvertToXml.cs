using System;
using System.Collections.Generic;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace UnicodeConverter
{
    class ConvertToXml
    {
        Object missing = System.Reflection.Missing.Value;
        public void ConvertToXML(string filename)
        {
            Word.Application wordApp = new Word.Application();

            // For reasons of performace and to avoid the user
            // messing things up :
            wordApp.Visible = false;
            wordApp.ScreenUpdating = true;

            // Word needs a lot of parameters that are optional in VB
            // but need to be passed in C#
            Object xmlFormat = Word.WdSaveFormat.wdFormatXML;
            Object f = filename;
            string tem = System.IO.Directory.GetCurrentDirectory();
            Object savename = tem + "\\TempXml";
            Word.Document doc = wordApp.Documents.Add(ref f, ref missing, ref missing, ref  missing);
            // Here comes the actual saving part
            doc.SaveAs(
            ref savename,
            ref xmlFormat,
            ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing,
            ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing,
            ref missing);

            doc.Close(ref missing, ref missing, ref missing);


        }

        public void SaveToDoc(string filename,string savefilename)
        {
            Word.Application wordApp = new Word.Application();

            // For reasons of performace and to avoid the user
            // messing things up :
            wordApp.Visible = false;
            wordApp.ScreenUpdating = true;

            // Word needs a lot of parameters that are optional in VB
            // but need to be passed in C#
            Object docFormat = Word.WdSaveFormat.wdFormatDocument;
            Object f =filename;
            Object savename =savefilename;
            Word.Document doc = wordApp.Documents.Add(ref f, ref missing, ref missing, ref  missing);
            doc.Content.Font.Name = "Myanmar3";
            // Here comes the actual saving part
            doc.SaveAs(
            ref savename,
            ref docFormat,
            ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing,
            ref missing, ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing,
            ref missing);

            doc.Close(ref missing, ref missing, ref missing);


        }
       
    }
}
