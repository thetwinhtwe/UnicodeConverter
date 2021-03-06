using System;
//using System.Collections.Generic;
//using System.Text;
using System.Text.RegularExpressions;

namespace UnicodeConverter
{
    class  IToMyanmar3
    {
        public static string  I2Uni(string input)
        {
            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);

            #region call

            System.Data.DataSet ds = new System.Data.DataSet();
            string xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\XmlMapFiles\\I.xml";
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

            //#region Kinzi

            //unistr = Regex.Replace(unistr, "\u0043", "င်္");
            //unistr = Regex.Replace(unistr, "\u201A", "င်္");
            ////unistr = Regex.Replace(unistr, "C", "င်္ံ");
            //unistr = Regex.Replace(unistr, "\u20AC", "င်္ီ");

            //#endregion

            //#region Consonants 

            //unistr = Regex.Replace(unistr, "k", "က");
            //unistr = Regex.Replace(unistr, "K", "ခ");
            //unistr = Regex.Replace(unistr, "g", "ဂ");
            //unistr = Regex.Replace(unistr, "G", "ဃ");
            //unistr = Regex.Replace(unistr, "c", "င");
            //unistr = Regex.Replace(unistr, "s", "စ");
            //unistr = Regex.Replace(unistr, "S", "ဆ");
            //unistr = Regex.Replace(unistr, "z", "ဇ");
            //unistr = Regex.Replace(unistr, "Z", "ဈ");
            //unistr = Regex.Replace(unistr, "\u00BC", "ဉ");
            //unistr = Regex.Replace(unistr, "\u00BE", "ဉ");
            //unistr = Regex.Replace(unistr, "[vV]", "ည");
            //unistr = Regex.Replace(unistr, "\u0021", "ဋ");
            //unistr = Regex.Replace(unistr, "\u00A1", "ဋ");
            //unistr = Regex.Replace(unistr, "@", "ဌ");
            //unistr = Regex.Replace(unistr, "\u2026", "ဍ");
            ////unistr = Regex.Replace(unistr, "\u0024", "ဎ");
            //unistr = Regex.Replace(unistr, "%", "ဏ");
            //unistr = Regex.Replace(unistr, "t", "တ");
            //unistr = Regex.Replace(unistr, "T", "ထ");
            //unistr = Regex.Replace(unistr, "d", "ဒ");
            //unistr = Regex.Replace(unistr, "D", "ဓ");
            //unistr = Regex.Replace(unistr, "[nN]", "န");
            //unistr = Regex.Replace(unistr, "p", "ပ");
            //unistr = Regex.Replace(unistr, "P", "ဖ");
            //unistr = Regex.Replace(unistr, "b", "ဗ");
            //unistr = Regex.Replace(unistr, "B", "ဘ");
            //unistr = Regex.Replace(unistr, "m", "မ");
            //unistr = Regex.Replace(unistr, "y", "ယ");
            //unistr = Regex.Replace(unistr, "[rR]", "ရ");
            //unistr = Regex.Replace(unistr, "l", "လ");
            //unistr = Regex.Replace(unistr, "w", "ဝ");
            //unistr = Regex.Replace(unistr, "q", "သ");
            //unistr = Regex.Replace(unistr, "h", "ဟ");
            //unistr = Regex.Replace(unistr, "L", "ဠ");
         

            //#endregion

            //#region Stacked  Consonants
            //unistr = Regex.Replace(unistr, "\u00DC", "\u1039" + 'က');
            //unistr = Regex.Replace(unistr, "\u00DD", "\u1039" + 'ခ');
            //unistr = Regex.Replace(unistr, "\u00DE", "\u1039" + 'ဂ');
            //unistr = Regex.Replace(unistr, "\u00DF", "\u1039" + 'ဃ');
            //unistr = Regex.Replace(unistr, "\u00E0", "\u1039" + 'စ');
            //unistr = Regex.Replace(unistr, "[\u00E1\u2219]", "\u1039" + 'ဆ');
            //unistr = Regex.Replace(unistr, "\u00E2", "\u1039" + 'ဇ');
            //unistr = Regex.Replace(unistr, "\u00E3", "\u1039" + 'ဈ');
            //unistr = Regex.Replace(unistr, "\u00E4", "\u1039" + 'ဋ');
            //unistr = Regex.Replace(unistr, "\u00E5", "\u1039" + 'ဌ');
            //unistr = Regex.Replace(unistr, "\u00E6", "\u1039" + 'ဍ');
            //unistr = Regex.Replace(unistr, "\u00E7", "\u1039" + 'ဎ');
            //unistr = Regex.Replace(unistr, "\u00E8", "\u1039" + 'ဏ');
            //unistr = Regex.Replace(unistr, "\u00E9", "\u1039" + 'တ');
            //unistr = Regex.Replace(unistr, "\u00EA", "\u1039" + 'ထ');
            //unistr = Regex.Replace(unistr, "\u00EB", "\u1039" + 'ဒ');
            //unistr = Regex.Replace(unistr, "\u00EC", "\u1039" + 'ဓ');
            //unistr = Regex.Replace(unistr, "\u00ED", "\u1039" + 'န');
            //unistr = Regex.Replace(unistr, "\u00EE", "\u1039" + 'ပ');
            //unistr = Regex.Replace(unistr, "\u00EF", "\u1039" + 'ဖ');
            //unistr = Regex.Replace(unistr, "\u00F0", "\u1039" + 'ဗ');
            //unistr = Regex.Replace(unistr, "\u00F1", "\u1039" + 'ဘ');
            //unistr = Regex.Replace(unistr, "\u00F2", "\u1039" + 'မ');
            //unistr = Regex.Replace(unistr, "\u00F3", "\u1039" + 'လ');

            //#endregion


            //# region Medials
            //unistr = Regex.Replace(unistr, "Y", "ျ"); // ya
            //unistr = Regex.Replace(unistr, "\u00CF", "ျွ"); // ya + wa
            //unistr = Regex.Replace(unistr, "\u00CE", "ျှ"); // ya + ha
            //unistr = Regex.Replace(unistr, "\u00D0", "ျွှ"); // ya + wa + ha

            //unistr = Regex.Replace(unistr, "[\u0046\u0051\u00D4\u00D5\u00D8\u00D9]", "ြ"); // ra
            //unistr = Regex.Replace(unistr, "[\u00D6\u00D7\u00DA\u00DB\u2044\u2215\u25CA]", "ြု"); // ra + vowel u

            //unistr = Regex.Replace(unistr, "[\u007C\u00F4]", "ွ"); // wa            
            //unistr = Regex.Replace(unistr, "W", "ွှ"); // wa + ha

            //unistr = Regex.Replace(unistr, "[:HÑ]", "ှ"); // ha
            //unistr = Regex.Replace(unistr, "\u00D2", "ှု");// ha + ta chaung yin
            //unistr = Regex.Replace(unistr, "\u00D3", "ှူ");// ha + na chaung yin

            //#endregion

            //# region  Independent Vowels
            //unistr = Regex.Replace(unistr, "A", "အ");
            //unistr = Regex.Replace(unistr, "\u00C4", "ဣ"); // I
            //unistr = Regex.Replace(unistr, "\u0049", "ဤ"); // II
            //unistr = Regex.Replace(unistr, "U", "ဥ"); // U
            //unistr = Regex.Replace(unistr, "Ë", "ဦ"); // UU
            //unistr = Regex.Replace(unistr, "\u2126", "ဦ"); // UU
            //unistr = Regex.Replace(unistr, "\u03A9", "ဦ"); // UU
            //unistr = Regex.Replace(unistr, "U+'^'", "ဦ"); // UU
            ////unistr = Regex.Replace(unistr, "[U√šˆ◊]+'\\005C'", "ဉ်");
            //unistr = Regex.Replace(unistr, "U+'\\005C'", "ဉ်");
            //unistr = Regex.Replace(unistr, "E", "ဧ"); // E
            //unistr = Regex.Replace(unistr, "Qq", "ဩ"); // ASCII letters combined, O
            //unistr = Regex.Replace(unistr, "eÔqa+'\'", "ဪ"); // ASCII letters combined, AU

            //#endregion

            //# region Dependent Vowels

            //unistr = Regex.Replace(unistr, "x", "ါ"); // Tall AA
            //unistr = Regex.Replace(unistr, "X", "ါ်"); // Tall AA + asat
            //unistr = Regex.Replace(unistr, "a", "ာ"); // AA
            //unistr = Regex.Replace(unistr, "i", "ိ"); // I
            //unistr = Regex.Replace(unistr, "\\^", "ီ"); // II
            //unistr = Regex.Replace(unistr, "[uo]", "ု"); // U
            //unistr = Regex.Replace(unistr, "[JO]", "ူ"); // UU

            //unistr = Regex.Replace(unistr, "e", "ေ"); // E
            //unistr = Regex.Replace(unistr, "#", "ဲ"); // AI
            //unistr = Regex.Replace(unistr, "M", "ံ"); // ANUSVARA
            //unistr = Regex.Replace(unistr, "\u00B8\u220F", "ိံ");

            //# endregion

            //# region Asat

            //unistr = Regex.Replace(unistr, "\\u005C", "်");

            //# endregion

            //# region Tone Marks

            //unistr = Regex.Replace(unistr, "[\u003E\u017D]", "့"); // Aukmyit
            //unistr = Regex.Replace(unistr, "\u003B", "း");//Visarga

            //# endregion

            //# region Digits

            //unistr = Regex.Replace(unistr, "0", "၀");
            //unistr = Regex.Replace(unistr, "1", "၁");
            //unistr = Regex.Replace(unistr, "2", "၂");
            //unistr = Regex.Replace(unistr, "3", "၃");
            //unistr = Regex.Replace(unistr, "4", "၄");
            //unistr = Regex.Replace(unistr, "5", "၅");
            //unistr = Regex.Replace(unistr, "6", "၆");
            //unistr = Regex.Replace(unistr, "7", "၇");
            //unistr = Regex.Replace(unistr, "8", "၈");
            //unistr = Regex.Replace(unistr, "9", "၉");

            //# endregion

            //# region Punctuation

            //unistr = Regex.Replace(unistr, "\u0027", "၊");
            //unistr = Regex.Replace(unistr, "\u0022", "။");

            //# endregion

            //# region Various Signs

            //unistr = Regex.Replace(unistr, "`", "၌");
            //unistr = Regex.Replace(unistr, "j", "၍");
            //unistr = Regex.Replace(unistr, "&", "၎");
            //unistr = Regex.Replace(unistr, "f", "၏");

            //# endregion

            //# region Consonant Letter Great SA

            //unistr = Regex.Replace(unistr, "\u203A", "ဿ");

            //# endregion

            

            //# region combine characters

            //unistr = Regex.Replace(unistr, "\u0160", "ဍ္ဍ");
            //unistr = Regex.Replace(unistr, "\u201E", "ဍ္ဎ");
            //unistr = Regex.Replace(unistr, "\u2030", "ဋ္ဌ");
            //unistr = Regex.Replace(unistr, "\u02DC", "ဋ္ဋ");



            //# endregion

            //# region General

            //unistr = Regex.Replace(unistr, "{", "“");
            //unistr = Regex.Replace(unistr, "}", "”");
            //unistr = Regex.Replace(unistr, "[\u003C\u003F]", "'");  
            //unistr = Regex.Replace(unistr, "\u00F5", ">");
            //unistr = Regex.Replace(unistr, "\u00F6", "<");
            //unistr = Regex.Replace(unistr, "\u00C7", "/");
            ////unistr = Regex.Replace(unistr, "\u0028", "(");
            ////unistr = Regex.Replace(unistr, "\u0029", ")");
            ////unistr = Regex.Replace(unistr, "\u005B", "[");
            ////unistr = Regex.Replace(unistr, "\u005D", "]");
            ////unistr = Regex.Replace(unistr, "¼", "\u0020");
            ////unistr = Regex.Replace(unistr, "?", "’");
            ////unistr = Regex.Replace(unistr, "{", "“");
            ////unistr = Regex.Replace(unistr, "}", "”");
            ////unistr = Regex.Replace(unistr, "\u00AF", "\u2018");
            ////unistr = Regex.Replace(unistr, "\u02D8", "\u2019");

            //# endregion

           
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
            
        } // end of I2Uni()
    }
}
