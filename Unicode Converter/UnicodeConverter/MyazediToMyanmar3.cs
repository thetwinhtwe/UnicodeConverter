using System;
//using System.Collections.Generic;
//using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace  UnicodeConverter
{
    class MyazediToMyanmar3
    {
        public static string MyazediToUni(string input)
        {
            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);

            //------------------------------------- Replacements And Rearrangements According To Unicode 5.1----------------------------------------//
            #region call

            System.Data.DataSet ds = new System.Data.DataSet();
            string xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\XmlMapFiles\\MyaZeDi.xml";
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
            //#region declaration
            //String tallAA = "ါ";
            //String vi = "ိ"; //lone gyi tin
            //String u = "ု";
            //String uu = "ူ";
            //String ans = "ံ";
            //String db = "့";
            //String virama = "္";
            //String asat = "်";
            //String ya = "ျ";
            //String ra = "ြ";
            //String wa = "ွ";
            //String ha = "ှ";
            //#endregion

            //#region Kinzi
            //unistr = Regex.Replace(unistr, "\u1086", "င်္");
            //#endregion

            //#region consonants
            //unistr = Regex.Replace(unistr, "\u108F", "ဉ");
            //unistr = Regex.Replace(unistr, "\u108C", "ည");
            //unistr = Regex.Replace(unistr, "\u108E", "န");
            //unistr = Regex.Replace(unistr, "\u109F", "ရ");
            //#endregion

            //# region Medial Groups
            //unistr = Regex.Replace(unistr, "[\u1033\u1090\u1091\u1092\u1093]", "\u1034");//Medial ra
            //unistr = Regex.Replace(unistr, "[\u1094\u1095]", "\u103C\u103D");// ra wa
            //unistr = Regex.Replace(unistr, "\u1096", "\u103B\u103E");// ya ha
            //unistr = Regex.Replace(unistr, "\u1097", "\u103B\u103D");// ya wa
            //unistr = Regex.Replace(unistr, "\u1098", "\u103B\u103D\u103E");// ya wa ha      
            //unistr = Regex.Replace(unistr, ha + ya, ya + ha);
            //unistr = Regex.Replace(unistr, "\u1094", "\u103C\u103D");
            //unistr = Regex.Replace(unistr, "\u107F", "\u103D\u103E");// ya wa
            //unistr = Regex.Replace(unistr, "[\u1080\u105F]", ha);// medial ha
            //unistr = Regex.Replace(unistr, "\u107E", wa);//medial wa
            //unistr = Regex.Replace(unistr, "\u1034", ra);//Medial ra
            //unistr = Regex.Replace(unistr, "\u1035", ya);//Medial ya     
            //#endregion

            //#region Independent vowel
            //unistr = Regex.Replace(unistr, "\u1025\u1039", "ဉ်");
            //#endregion

            //#region Dependent Vowels
            //unistr = Regex.Replace(unistr, "\u105D", tallAA);
            //unistr = Regex.Replace(unistr, "\u1084", vi + ans);//lgt ttt
            //unistr = Regex.Replace(unistr, "\u1082", u);
            //unistr = Regex.Replace(unistr, "\u1083", uu);
            //unistr = Regex.Replace(unistr, "\u1081", ha + u);//ha  u            
            //#endregion

            //#region Consonant Letter Great SA
            //unistr = Regex.Replace(unistr, "\u108D", "ဿ");
            //#endregion

            //#region Asat Converting
            //unistr = Regex.Replace(unistr, "\u105E", tallAA + asat);
            //unistr = Regex.Replace(unistr, "\u1039", "\u103A");//asat
            //#endregion

            //// Coz Myazedi use "Virama (u1039)" as "Asat (u103A)" , Stacked consonants should be converted after Asat Converting
            //#region Stacked Consonants
            //unistr = Regex.Replace(unistr, "\u1078", 'ဏ' + virama + 'ဍ');
            //unistr = Regex.Replace(unistr, "\u1089", 'ဋ' + virama + 'ဌ');
            //unistr = Regex.Replace(unistr, "[\u1060\u107A]", virama + 'က');
            //unistr = Regex.Replace(unistr, "\u1061", virama + 'ခ');
            //unistr = Regex.Replace(unistr, "\u1062", virama + 'ဂ');
            //unistr = Regex.Replace(unistr, "[\u1063\u107B]", virama + 'ဃ');
            //unistr = Regex.Replace(unistr, "\u1064", virama + 'စ');
            //unistr = Regex.Replace(unistr, "[\u1065\u107D]", virama + 'ဆ');
            //unistr = Regex.Replace(unistr, "\u1066", virama + 'ဇ');
            //unistr = Regex.Replace(unistr, "\u1099", virama + 'ဈ');

            //unistr = Regex.Replace(unistr, "\u108A", 'ဋ' + virama + 'ဋ');//asat
            //unistr = Regex.Replace(unistr, "\u1076", virama + 'ဋ');

            //unistr = Regex.Replace(unistr, "\u1075", virama + 'ဌ');

            //unistr = Regex.Replace(unistr, "\u108B", 'ဍ' + virama + 'ဍ');
            //unistr = Regex.Replace(unistr, "\u1079", 'ဎ' + virama + 'ဍ');//ဍ္ဎ

            //unistr = Regex.Replace(unistr, "[\u1067\u109C]", virama + 'ဏ');
            //unistr = Regex.Replace(unistr, "[\u1068\u1069]", virama + 'တ');
            //unistr = Regex.Replace(unistr, "[\u106A\u106B]", virama + 'ထ');
            //unistr = Regex.Replace(unistr, "\u106C", virama + 'ဒ');
            //unistr = Regex.Replace(unistr, "\u106D", virama + 'ဓ');
            //unistr = Regex.Replace(unistr, "\u106E", virama + 'န');

            //unistr = Regex.Replace(unistr, "\u106F", virama + 'ပ');
            //unistr = Regex.Replace(unistr, "\u1070", virama + 'ဖ');
            //unistr = Regex.Replace(unistr, "\u1071", virama + 'ဗ');
            //unistr = Regex.Replace(unistr, "[\u1072\u109D]", virama + 'ဘ');
            //unistr = Regex.Replace(unistr, "\u1073", virama + 'မ');
            //unistr = Regex.Replace(unistr, "[\u1074\u109E]", virama + 'လ');
            //unistr = Regex.Replace(unistr, "\u1076", virama + '\u100B');
            //unistr = Regex.Replace(unistr, "\u1075", virama + '\u100C');
            //#endregion

            //#region Tone Marks
            //unistr = Regex.Replace(unistr, "[\u109A\u109B]", db);//aukmyint              
            //#endregion

            //#region Various Signs
            //unistr = Regex.Replace(unistr, "\u104E", "၎င်း");
            //#endregion

            #region Reordering
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<R>\u103C)?(?<con>[က-အ])\u1086\u200D?", "\u1086${E}${R}${con}"); //reordering kinzi
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<R>\u103C)?(?<con>[က-အ])\u1087", "\u1086${E}${R}${con}\u102D"); //reordering kinzi lgt
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<R>\u103C)?(?<con>[က-အ])\u1088", "\u1086${E}${R}${con}\u102E"); //reordering kinzi lgtsk
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<R>\u103C)?(?<con>[က-အ])\u1085", "\u1086${E}${R}${con}\u1036"); //reordering kinzi ttt            
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<Ya>\u103B)?\u1088", "\u1086${con}${Ya}\u102E");
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<Ya>\u103B)?\u1087", "\u1086${con}${Ya}\u102D");
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<Ya>\u103B)?\u1085", "\u1086${con}${Ya}\u1036");

            unistr = Regex.Replace(unistr, "(\u1000\u103A\u102F\u102F)", "(\u1000\u103A\u102F)");
            unistr = Regex.Replace(unistr, "(?<R>\u103C)(?<con>[က-အ])(?<scon>\u1039[က-အ])?", "${con}${scon}${R}");

            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1040)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))", "\u101D"); //zero and wa
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1047)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))", "\u101B");//seven and ra
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032])?(?<DVs>[\u1036\u1037\u1038]{0,2})(?<M>[\u103B-\u103E]*)(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${E}${upper}${lower}${DVs}"); //reordering storage order
            //edit
            unistr = Regex.Replace(unistr, "(?<R>\u103C)(?<Wa>\u103D)(?<con>[က-အ])", "${con}${R}${Wa}");// Ra+Wa
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])\u103A(?<medial>[\u103B\u103D\u103E]){1}", "${con}${medial}\u103A");// Ya,Wa,Ha and asat
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<con>[က-အ])(?<R>\u103C)\u103D", "${con}${R}\u103D${E}"); // E and Ra and Lower

            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<upper>[\u102D\u102E\u1032])(?<scon>\u1039[က-အ])", "${con}${scon}${upper}");
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<Ya>\u103B)(?<kinzi>င်္)", "${kinzi}${con}${Ya}");
            #endregion

            unistr = UnicodeConverter.correct.Correction1(unistr);
            return unistr;
        }
    }
}
