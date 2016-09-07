using System;
//using System.Collections.Generic;
//using System.Text;
using System.Text.RegularExpressions;
using System.Text;

namespace  UnicodeConverter
{
    class AcademytoMyanmar3
    {
        public static string Academy2Uni(string input)
        {
            String unistr = "";
            unistr = input.Substring(0);

            #region call

            System.Data.DataSet ds = new System.Data.DataSet();
            string xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\XmlMapFiles\\AcademyFontFamily.xml";
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
            #region comment
            #region Kinzi
            //     unistr = Regex.Replace(unistr, "F", "င်္");
       //     unistr = Regex.Replace(unistr, "à", "င်္ံ");
       //     unistr = Regex.Replace(unistr, "À", "င်္ီ");
           #endregion 
            
           #region Consonants

       //     unistr = Regex.Replace(unistr, "u", "က");
       //     unistr = Regex.Replace(unistr, "c", "ခ");
       //     unistr = Regex.Replace(unistr, "}", "ဂ");
       //     unistr = Regex.Replace(unistr, "C", "ဃ");
       //     unistr = Regex.Replace(unistr, "i", "င");
       //     unistr = Regex.Replace(unistr, "p", "စ");
       //     unistr = Regex.Replace(unistr, "q", "ဆ");
       //     unistr = Regex.Replace(unistr, "Z", "ဇ");
       //     unistr = Regex.Replace(unistr, "ç", "ဈ");
       //     unistr = Regex.Replace(unistr, "Ù", "ဉ ");
       //     unistr = Regex.Replace(unistr, "[nò]", "ည");
       //     unistr = Regex.Replace(unistr, "[\u00F5\u02C9\u00AF]", "ဋ");
       //     unistr = Regex.Replace(unistr, "\u0058", "ဌ");
       //     unistr = Regex.Replace(unistr, "ø", "ဍ");
       //     unistr = Regex.Replace(unistr, "Í", "ဎ");
       //     unistr = Regex.Replace(unistr, "E", "ဏ");
       //     unistr = Regex.Replace(unistr, "\u0077", "တ");
       //     unistr = Regex.Replace(unistr, "\u0078", "ထ");
       //     unistr = Regex.Replace(unistr, "['°]", "ဒ");
       //     unistr = Regex.Replace(unistr, "\u0022", "ဓ");
       //     unistr = Regex.Replace(unistr, "[\u0065ó]", "န");
       //     unistr = Regex.Replace(unistr, "\u0079", "ပ");
       //     unistr = Regex.Replace(unistr, "z", "ဖ");
       //     unistr = Regex.Replace(unistr, "\u0041", "ဗ");
       //     unistr = Regex.Replace(unistr, "b", "ဘ");
       //     unistr = Regex.Replace(unistr, "\u0072", "မ");
       //     unistr = Regex.Replace(unistr, "\u003C", "ယ");
       //     unistr = Regex.Replace(unistr, "[\\\\]", "ရ");
       //     unistr = Regex.Replace(unistr, "[|]", "ရ");
       //     unistr = Regex.Replace(unistr, "\u0076", "လ");
       //     unistr = Regex.Replace(unistr, "\u0026", "ဝ");
       //     unistr = Regex.Replace(unistr, "\u006F", "သ");
       //     unistr = Regex.Replace(unistr, "[[]", "ဟ");
       //     unistr = Regex.Replace(unistr, " V ", "ဠ");


            #endregion 

            #region Stacked Consonant

       //     unistr = Regex.Replace(unistr, "Q", "\u1039" + 'ခ');
       //     unistr = Regex.Replace(unistr, "P", "\u1039" + 'စ');
       //     unistr = Regex.Replace(unistr, "é", "\u1039" + 'ဆ');
       //     unistr = Regex.Replace(unistr, "ß", "\u1039" + 'ဇ');
       //     unistr = Regex.Replace(unistr, "W", "\u1039" + 'တ');
       //     unistr = Regex.Replace(unistr, "M", "\u1039" + 'ထ');
       //     unistr = Regex.Replace(unistr, "N", "\u1039" + 'ဒ');
       //     unistr = Regex.Replace(unistr, "Ý", "\u1039" + 'ဓ');
       //     unistr = Regex.Replace(unistr, "í", "\u1039" + 'ပ');
       //     unistr = Regex.Replace(unistr, "ÿ", "\u1039" + 'ဖ');
       //     unistr = Regex.Replace(unistr, "[Ô•]", "\u1039" + 'ဗ');
       //     unistr = Regex.Replace(unistr, "B", "\u1039" + 'ဘ');
       //     unistr = Regex.Replace(unistr, "R", "\u1039" + 'မ');
       //     unistr = Regex.Replace(unistr, "ì", "\u1039" + 'လ');

           #endregion

           #region Medial

       //     unistr = Regex.Replace(unistr, "\u0073", "ျ");
       //     unistr = Regex.Replace(unistr, "\u00A1", "ျွ");
       //     unistr = Regex.Replace(unistr, "¡", "ျွ");
       //     unistr = Regex.Replace(unistr, "\u00FB", "ျှ");
       //     unistr = Regex.Replace(unistr, "[\u005D\u006A]", "ြ");
       //     unistr = Regex.Replace(unistr, "[\u00DAÚ]", "ြု");
       //     unistr = Regex.Replace(unistr, "G", "ွ");
       //     unistr = Regex.Replace(unistr, "Ï", "ွွှ");
       //     unistr = Regex.Replace(unistr, "[SÛ]", "ှ");
       //     unistr = Regex.Replace(unistr, "ë", "ွှှု");
       //     unistr = Regex.Replace(unistr, "ä", "ှူ");


        #endregion

            #region Indepandent Vowel

       //     unistr = Regex.Replace(unistr, "\u0074", "အ");
       //     unistr = Regex.Replace(unistr, "\u00C3", "ဣ");
       //     unistr = Regex.Replace(unistr, "T", "ဤ");
       //     unistr = Regex.Replace(unistr, "O", "ဥ");
       //     unistr = Regex.Replace(unistr, "{", "ဧ");

            #endregion

            #region Depandent Vowel
       //     unistr = Regex.Replace(unistr, "g", "ါ");
       //     unistr = Regex.Replace(unistr, ";", "ါ်");
       //     unistr = Regex.Replace(unistr, "m", "ာ");
       //     unistr = Regex.Replace(unistr, "d", "ိ");
       //     unistr = Regex.Replace(unistr, "D", "ီ");
       //     unistr = Regex.Replace(unistr, "k", "ု");
       //     unistr = Regex.Replace(unistr, "K", "ု");
       //     unistr = Regex.Replace(unistr, "l", "ူ");
       //     unistr = Regex.Replace(unistr, "L", "ူ");
       //     unistr = Regex.Replace(unistr, "a", "ေ");
       //     unistr = Regex.Replace(unistr, "J", "ဲ");
       //     unistr = Regex.Replace(unistr, "H", "ံ");
            #endregion



            # region Asat

       //     unistr = Regex.Replace(unistr, "f", "်");

            # endregion

            # region Tone Marks

       //     unistr = Regex.Replace(unistr, "[\u0068\u00D0\u00F0]", "့"); // Aukmyit
       //     unistr = Regex.Replace(unistr, ":", "း");//Visarga

           # endregion

            # region Digits

       //     unistr = Regex.Replace(unistr, "0", "၀");
       //     unistr = Regex.Replace(unistr, "1", "၁");
       //     unistr = Regex.Replace(unistr, "2", "၂");
       //     unistr = Regex.Replace(unistr, "3", "၃");
       //     unistr = Regex.Replace(unistr, "4", "၄");
       //     unistr = Regex.Replace(unistr, "5", "၅");
       //     unistr = Regex.Replace(unistr, "6", "၆");
       //     unistr = Regex.Replace(unistr, "7", "၇");
       //     unistr = Regex.Replace(unistr, "8", "၈");
       //     unistr = Regex.Replace(unistr, "9", "၉");

           # endregion

            # region Punctuation

       //     unistr = Regex.Replace(unistr, "[\u003F]", "၊");
       //     unistr = Regex.Replace(unistr, "\u0060", "။");

            # endregion

            # region Various Signs

       //     unistr = Regex.Replace(unistr, "Y", "၌");
       //     unistr = Regex.Replace(unistr, "I", "၍");
       //     unistr = Regex.Replace(unistr, "&", "၎");
       //     unistr = Regex.Replace(unistr, ">", "၏");

            # endregion

            # region Consonant Letter Great SA

       //     unistr = Regex.Replace(unistr, "\u00F9", "ဿ");

            # endregion

            # region combine characters

       //     unistr = Regex.Replace(unistr, "Ö", "ဏ္ဍ");
       //     unistr = Regex.Replace(unistr, "›", "ဏ္ဎ");
       //     unistr = Regex.Replace(unistr, "Ø", "ဍ္ဍ");
       //     unistr = Regex.Replace(unistr, "×", "ဍ္ဎ");
       //     unistr = Regex.Replace(unistr, "É", "ဏ္ဌ");
       //     unistr = Regex.Replace(unistr, " Ó", "ဏ္ဏ");
       //     unistr = Regex.Replace(unistr, "Å", "ဏ္ဋ");
       //     unistr = Regex.Replace(unistr, "\u00F7", "ဋ္ဌ");
       //     unistr = Regex.Replace(unistr, "Õ", "ဋ္ဋ");

       # endregion

          # region General
       //     unistr = Regex.Replace(unistr, "\u00DC", "“");
       //     unistr = Regex.Replace(unistr, "\u00C1", "”");
       //     unistr = Regex.Replace(unistr, "¼", "\u00BC");
           
  
           # endregion
#endregion
            # region reordering process

            unistr = Regex.Replace(unistr, "(?<R>\u103C)(?<Wa>\u103D)?(?<Ha>\u103E)?(?<U>\u102F)?(?<con>[က-အ])(?<scon>\u1039[က-အ])?", "${con}${scon}${R}${Wa}${Ha}${U}"); //reordering ra
            unistr = Regex.Replace(unistr, "(?<=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F\u0020]))(?<z>\u1040)|(?<z>\u1040)(?=(?<Mm>[\u1000-\u101C\u101E-\u102A\u102C\u102E-\u103F\u104C-\u109F]))", "\u101D");//zero and wa
            unistr = Regex.Replace(unistr, "(?<E>\u1031)?(?<con>[က-အ])?(?<scon>\u1039[က-အ])?(?<upper>[\u102D\u102E\u1032\u1036])?(?<DVs>[\u1037\u1038]){0,2}(?<M>[\u103B-\u103E]*)(?<lower>[\u102F\u1030])?(?<upper>[\u102D\u102E\u1032])?", "${con}${scon}${M}${E}${upper}${lower}${DVs}"); //reordering storage order
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<middle>[\u103B\u103C\u1031]){0,1}(?<kinzi>\u1004\u103A\u1039){1}", "${kinzi}${con}${middle}");//kinzi
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<Medial>[\u103B\u103C\u103D\u103E]){0,1}(?<anusvara>\u1036)(?<vowelU>[\u102F])", "${con}${Medial}${vowelU}${anusvara}");//taytaytin and ta chaung yin    
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<tone>[\u1037\u1038]){0,1}(?<asat>\u103A)", "${con}${asat}${tone}");//asat and tone
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<uvowel>[\u102F\u102E\u1032]){0,1}(?<lvowel>[\u102D\u1030]){0,1}", "${con}${lvowel}${uvowel}");// upper vowel and lower vowel
            unistr = Regex.Replace(unistr, "(?<ivU>ဥ)(?<vowelII>ီ)", "\u1026"); // u and nyakalay                
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<middle>[\u1031\u102D]){0,1}(?<space>[\u0020\u00A0])?(?<space>[\u0020\u00A0])?(?<scon>\u1039[က-အ])?", "${con}${scon}${middle}"); // space with stack consonant
            unistr = Regex.Replace(unistr, "(?<con>[က-အ])(?<middle>[\u102F\u1030\u103D])?(?<upper>\u1032)?(?<space>[\u0020\u00A0])?(?<aukmyit>\u1037)", "${con}${middle}${upper}${aukmyit}");
            unistr = Regex.Replace(unistr, "(?<Nya>ဉ)(?<con>[က-အဿ])", "\u1025${con}");
            unistr = Regex.Replace(unistr, "(?<Nya>ဉ)(?<II>[ီ])", "\u1026"); //U
            unistr = Regex.Replace(unistr, "(?<stacker>\u1039)(?<uu>\u1026){1}", "\u1026"); //U

            #endregion

            unistr = UnicodeConverter.correct.Correction1(unistr);
            return unistr;
      

        }
    }
}
