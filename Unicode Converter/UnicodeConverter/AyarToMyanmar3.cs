using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UnicodeConverter
{
    class AyarToMyanmar3
    {

        public static string Ayar2Uni(string input)
        {
            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);

            String virama = "္";
           

            # region Reordering
            unistr = Regex.Replace(unistr, "\u1039", virama);
            unistr = Regex.Replace(unistr, "(?<R>\u103C)(?<con>[က-အ])(?<scon>\u1039[က-အ])?", "${con}${scon}${R}"); //reordering ra       
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1040)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))", "\u101D");//zero and wa
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1047)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))", "\u101B");//seven and ra
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032])?(?<DVs>[\u1036\u1037\u1038]{0,2})(?<M>[\u103B-\u103E]*)(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${E}${upper}${lower}${DVs}"); //reordering storage order
            unistr = Regex.Replace(unistr, "(?<=(?<MC>[\u1001\u1002\u1004\u1012\u1013\u1015\u101D])(?<E>\u1031)?)(?<AA>\u102C)", "\u102B");
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032\u1036])?(?<DVs>[\u1037\u1038]){0,2}(?<M>[\u103B-\u103E]*)" +
                "(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${upper}${lower}${DVs}"); //reordering storage order

            #endregion

            unistr = UnicodeConverter.correct.Correction1(unistr);
            return unistr;

        }
    
    }
}
