using System;
//using System.Collections.Generic;
//using System.Text;
using System.Text.RegularExpressions;
using System.Xml;



namespace UnicodeConverter
{
    class  Pinny5ToMyanmar3
    {
        public static string Pinny52Uni(string input)
        {
           
            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);


            #region call
           
            System.Data.DataSet ds = new System.Data.DataSet();
           // ds.ReadXml(@"XMLCollector\Pinny5ToMyanmar3.xml");
           // string src = @"Pinny5ToMyanmar3.xml";
            //ds.ReadXml(src);
            //XmlTextReader textReader = new XmlTextReader("C:\\Pinny5ToMyanmar3.xml");
            //ds.ReadXml(@"C:\Documents and Settings\ag\Desktop\UnitoUni\UniConversion\UniConversion\bin\Debug\Pinny5ToMyanmar3.xml");
            
            //ds.ReadXml("\\"+src);

            string xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\XmlMapFiles\\PinnyFontFamily.xml";            
            ds.ReadXml(xmlpath);
           
            System.Data.DataRowCollection drc = ds.Tables["fontTable"].Rows;
            foreach (System.Data.DataRow dr in drc)
            {
                if (unistr.Contains(dr[0].ToString()))
                {
                    unistr = unistr.Replace(dr[0].ToString(), dr[1].ToString());
                }
            }
            #endregion call


            # region reordering process

            unistr = Regex.Replace(unistr, "(?<R>\u103C)(?<Wa>\u103D)?(?<Ha>\u103E)?(?<U>\u102F)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?", "${con}${scon}${R}${Wa}${Ha}${U}"); //reordering ra
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1040)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F]))", "\u101D");//zero and wa
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<con>[က-အ])?(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032\u1036])?(?<DVs>[\u1037\u1038]){0,2}(?<M>[\u103B-\u103E]*)(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${E}${upper}${lower}${DVs}"); //reordering storage order
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<middle>[\u103B\u103C\u1031]){0,1}(?<kinzi>\u1004\u103A\u1039){1}", "${kinzi}${con}${middle}");//kinzi
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<Medial>[\u103B\u103C\u103D\u103E]){0,1}(?<anusvara>\u1036)(?<vowelU>[\u102F])", "${con}${Medial}${vowelU}${anusvara}");//taytaytin and ta chaung yin    
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<tone>[\u1037\u1038]){0,1}(?<asat>\u103A)", "${con}${asat}${tone}");//asat and tone
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<uvowel>[\u102F\u102E\u1032]){0,1}(?<lvowel>[\u102D\u1030]){0,1}", "${con}${lvowel}${uvowel}");// upper vowel and lower vowel
            unistr = Regex.Replace(unistr, "(?<ivU>ဥ)(?<vowelII>ီ)", "\u1026"); // u and nyakalay //               
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<middle>[\u1031\u102D]){0,1}(?<space>[\u0020\u00A0])?(?<space>[\u0020\u00A0])?(?<scon>\u1039[က-အ])?", "${con}${scon}${middle}"); // space with stack consonant
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<middle>[\u102F\u1030\u103D])?(?<upper>\u1032)?(?<space>[\u0020\u00A0])?(?<aukmyit>\u1037)", "${con}${middle}${upper}${aukmyit}");
            unistr = Regex.Replace(unistr, "(?<Nya>ဉ)(?<con>[က-အဿ])", "\u1025${con}");//
            unistr = Regex.Replace(unistr, "(?<Nya>ဉ)(?<II>[ီ])", "\u1026"); //U//
            unistr = Regex.Replace(unistr, "(?<stacker>\u1039)(?<uu>\u1026){1}", "\u1026"); //U//
            


            #endregion

            unistr = UnicodeConverter.correct.Correction1(unistr);
            return unistr;
            
        } // end of  Pinny5ToMyanmar3()
    }
}
