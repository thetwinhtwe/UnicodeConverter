using System;
//using System.Collections.Generic;
//using System.Text;
using System.Text.RegularExpressions;

namespace UnicodeConverter
{
    class ZawgyiToMyanmar3
    {
        
        public static string Zawgyi2Uni(string input)
        {
            input = input.Replace("ူ်", "်ဴ");
            input = input.Replace("ု်", "်ဳ");
            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);

            #region call

            System.Data.DataSet ds = new System.Data.DataSet();
            string xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\XmlMapFiles\\Zawgyi.xml";
            ds.ReadXml(xmlpath);
            System.Data.DataRowCollection drc = ds.Tables["fontTable"].Rows;

            foreach (System.Data.DataRow dr in drc)
            {
                unistr = unistr.Replace(dr[0].ToString(), dr[1].ToString());
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
            //String zero = "၀";
            //#endregion                       

            //#region consonants
            //unistr = Regex.Replace(unistr, "\u106A", "ဉ");
            //unistr = Regex.Replace(unistr, "\u106B", "ည");
            //unistr = Regex.Replace(unistr, "\u1090", "ရ");
            //unistr = Regex.Replace(unistr, "\u1040", zero);

            //unistr = Regex.Replace(unistr, "\u108F", "န");
            //unistr = Regex.Replace(unistr, "\u1012", "ဒ");
            //unistr = Regex.Replace(unistr, "\u1013", "ဓ");
            //#endregion
                       
            //#region medials
            //unistr = Regex.Replace(unistr, "[\u103D\u1087]", ha);// ha
            //unistr = Regex.Replace(unistr, "\u103C", wa);//wa
            //unistr = Regex.Replace(unistr, "[\u103B\u107E\u107F\u1080\u1081\u1082\u1083\u1084]", ra);//ya yint(ra)
            //unistr = Regex.Replace(unistr, "[\u103A\u107D]", ya);//ya                

            //unistr = Regex.Replace(unistr, ha + ya, ya + ha);//reorder            

            //unistr = Regex.Replace(unistr, "\u108A", wa + ha);//wa ha   
            //#endregion

            //# region Dependent vowels
            //unistr = Regex.Replace(unistr, "\u105A", tallAA + asat);
            //unistr = Regex.Replace(unistr, "\u108E", vi + ans);//lgt ttt
            //unistr = Regex.Replace(unistr, "\u1033", u);
            //unistr = Regex.Replace(unistr, "\u1034", uu);
            //unistr = Regex.Replace(unistr, "\u1088", ha + u);//ha  u
            //unistr = Regex.Replace(unistr, "\u1089", ha + uu);//ha  uu
            //#endregion

            //#region Asat
            //unistr = Regex.Replace(unistr, "\u1039", "\u103A");
            //#endregion

           

            //#region kinzi
            //unistr = Regex.Replace(unistr, "\u1064", "င်္");
            //#endregion

            //#region stacked consonants
            //unistr = Regex.Replace(unistr, "\u1060", virama + 'က');
            //unistr = Regex.Replace(unistr, "\u1061", virama + 'ခ');
            //unistr = Regex.Replace(unistr, "\u1062", virama + 'ဂ');
            //unistr = Regex.Replace(unistr, "\u1063", virama + 'ဃ');
            //unistr = Regex.Replace(unistr, "\u1065", virama + 'စ');
            //unistr = Regex.Replace(unistr, "[\u1066\u1067]", virama + 'ဆ');
            //unistr = Regex.Replace(unistr, "\u1068", virama + 'ဇ');
            //unistr = Regex.Replace(unistr, "\u1069", virama + 'ဈ');
            //unistr = Regex.Replace(unistr, "\u106C", virama + 'ဋ');
            //unistr = Regex.Replace(unistr, "\u1070", virama + 'ဏ');
            //unistr = Regex.Replace(unistr, "[\u1071\u1072]", virama + 'တ');
            //unistr = Regex.Replace(unistr, "[\u1073\u1074]", virama + 'ထ');
            //unistr = Regex.Replace(unistr, "\u1075", virama + 'ဒ');
            //unistr = Regex.Replace(unistr, "\u1076", virama + 'ဓ');
            //unistr = Regex.Replace(unistr, "\u1077", virama + 'န');
            //unistr = Regex.Replace(unistr, "\u1078", virama + 'ပ');
            //unistr = Regex.Replace(unistr, "\u1079", virama + 'ဖ');
            //unistr = Regex.Replace(unistr, "\u107A", virama + 'ဗ');
            //unistr = Regex.Replace(unistr, "\u107B", virama + 'ဘ');
            //unistr = Regex.Replace(unistr, "\u107C", virama + 'မ');
            //unistr = Regex.Replace(unistr, "\u1085", virama + 'လ');
            //unistr = Regex.Replace(unistr, "\u106D", virama + 'ဌ');

            //unistr = Regex.Replace(unistr, "\u1091", 'ဏ' + virama + 'ဍ');
            //unistr = Regex.Replace(unistr, "\u1092", 'ဋ' + virama + 'ဌ');
            //unistr = Regex.Replace(unistr, "\u1097", 'ဋ' + virama + 'ဋ');
            //unistr = Regex.Replace(unistr, "\u106F", 'ဎ' + virama + 'ဍ');
            //unistr = Regex.Replace(unistr, "\u106E", 'ဍ' + virama + 'ဍ');
            //#endregion

            //#region Tone Mark
            //unistr = Regex.Replace(unistr, "[\u1094\u1095]", db);//aukmyint         
            //#endregion

            //#region Various Sign
            //unistr = Regex.Replace(unistr, "\u104E", "၎င်း");
            //#endregion

            //#region Consonant Letter Great SA
            //unistr = Regex.Replace(unistr, "\u1086", "ဿ");
            //#endregion
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<R>\u103C)?(?<con>[က-အ])င်္", "င်္${E}${R}${con}"); //reordering kinzi
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<R>\u103C)?(?<con>[က-အ])\u1064", "\u1064${E}${R}${con}"); //reordering kinzi
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<R>\u103C)?(?<con>[က-အ])\u108B", "\u1064${E}${R}${con}\u102D"); //reordering kinzi lgt
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<R>\u103C)?(?<con>[က-အ])\u108C", "\u1064${E}${R}${con}\u102E"); //reordering kinzi lgtsk
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<R>\u103C)?(?<con>[က-အ])\u108D", "\u1064${E}${R}${con}\u1036"); //reordering kinzi ttt   

            # region Reordering
                     
            unistr = Regex.Replace(unistr, "(?<R>\u103C)(?<con>[က-အ])(?<scon>\u1039[က-အ])?", "${con}${scon}${R}"); //reordering ra       
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1040)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))", "\u101D");//zero and wa
            //unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1047)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))", "\u101B");//seven and ra
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032])?(?<DVs>[\u1036\u1037\u1038]{0,2})(?<M>[\u103B-\u103E]*)(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${E}${upper}${lower}${DVs}"); //reordering storage order
            #endregion

            unistr = UnicodeConverter.correct.Correction1(unistr);             
            return unistr;
    

        }
    }
}
