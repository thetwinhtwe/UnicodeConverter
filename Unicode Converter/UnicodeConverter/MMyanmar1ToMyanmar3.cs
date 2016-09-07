using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UnicodeConverter
{
    class MMyanmar1ToMyanmar3
    {
        public static string MMyanmar2Uni(string input)
        {

            string ascstr = input;
            #region call

            System.Data.DataSet ds = new System.Data.DataSet();
            string xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\XmlMapFiles\\MMyanmarFontFamily.xml";
            ds.ReadXml(xmlpath);
            System.Data.DataRowCollection drc = ds.Tables["fontTable"].Rows;
            foreach (System.Data.DataRow dr in drc)
            {
                if (ascstr.Contains(dr[0].ToString()))
                {
                    ascstr = ascstr.Replace(dr[0].ToString(), dr[1].ToString());
                }
            }
            #endregion call

            //------------------------------------- Replacements And Rearrangements According To Unicode 5.1----------------------------------------//
         
            #region reordering kinzi in ascii side
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])F", "F${E}${R}${con}"); //reordering kinzi
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])Ø", "F${E}${R}${con}d"); //reordering kinzi lgt
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])Ð", "F${E}${R}${con}D"); //reordering kinzi lgtsk
            ascstr = Regex.Replace(ascstr, "(?<E>a)?(?<R>j)?(?<con>[uc*CipqZnñÍÚ#X!¡Pwx\\'\\\"eE½yzAbr,&v0o[Vt|ó])ø", "F${E}${R}${con}H"); //reordering kinzi ttt 
            #endregion

            String unistr = null;
            unistr = ascstr;

     
            #region Reordering Ra
            unistr = Regex.Replace(unistr, "(?<R>\u103C)(?<Wa>\u103D)?(?<Ha>\u103E)?(?<U>\u102F)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?", "${con}${scon}${R}${Wa}${Ha}${U}"); //reordering ra          
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1040)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F]))", "\u101D");//zero and wa
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1047)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))", "\u101B");//seven and ra
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032\u1036])?(?<DVs>[\u1037\u1038]){0,2}(?<M>[\u103B-\u103E]*)(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${E}${upper}${lower}${DVs}"); //reordering storage order
            #endregion

            unistr = UnicodeConverter.correct.Correction1(unistr);
            return unistr;
        }
    
    }
}
