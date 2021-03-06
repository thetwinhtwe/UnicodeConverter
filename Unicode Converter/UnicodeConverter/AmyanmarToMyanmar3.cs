using System;
using System.Text.RegularExpressions;

namespace UnicodeConverter
{
    class AmyanmarToMyanmar3
    {
        public static string Amyanmar2Uni(string input)
        {
            // copy inputted string to unistr
            String unistr = "";
            unistr = input.Substring(0);
            #region call

            System.Data.DataSet ds = new System.Data.DataSet();
            string xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\XmlMapFiles\\Amyanmar.xml";
            ds.ReadXml(xmlpath);
            System.Data.DataRowCollection drc = ds.Tables["fontTable"].Rows;
            foreach (System.Data.DataRow dr in drc)
            {
                if (unistr.Contains(dr[0].ToString()))
                {
                    unistr = unistr.Replace(dr[0].ToString(), dr[1].ToString());
                    //Console.WriteLine("Change  from      "+dr[0].ToString()+"    to     "+dr[1].ToString());
                }
            }
            #endregion call

           // #region Kinzi
           // unistr = Regex.Replace(unistr, "ç", "င်္");
           // unistr = Regex.Replace(unistr, "C", "င်္ံ");
           // unistr = Regex.Replace(unistr, "÷", "င်္ိ"); 
           // unistr = Regex.Replace(unistr, "Ç", "င်္ီ");

           // #endregion

           // #region Consonants
           // unistr = Regex.Replace(unistr, "k", "က"); //System.Windows.Forms.MessageBox.Show("k");
           // unistr = Regex.Replace(unistr, "K", "ခ"); //System.Windows.Forms.MessageBox.Show("K");
           // unistr = Regex.Replace(unistr, "g", "ဂ"); //System.Windows.Forms.MessageBox.Show("g");
           // unistr = Regex.Replace(unistr, "G", "ဃ"); //System.Windows.Forms.MessageBox.Show("G");
           // unistr = Regex.Replace(unistr, "c", "င"); //System.Windows.Forms.MessageBox.Show("c");
           // unistr = Regex.Replace(unistr, "s", "စ"); //System.Windows.Forms.MessageBox.Show("s");
           // unistr = Regex.Replace(unistr, "S", "ဆ"); //System.Windows.Forms.MessageBox.Show("S");
           // unistr = Regex.Replace(unistr, "z", "ဇ"); //System.Windows.Forms.MessageBox.Show("z");
           // unistr = Regex.Replace(unistr, "Z", "ဈ"); //System.Windows.Forms.MessageBox.Show("Z");
           // unistr = Regex.Replace(unistr, "[Uˆ]", "ဉ"); //System.Windows.Forms.MessageBox.Show("U");
           // unistr = Regex.Replace(unistr, "[vV]", "ည"); //System.Windows.Forms.MessageBox.Show("v");
           // unistr = Regex.Replace(unistr, "[F!]", "ဋ"); //System.Windows.Forms.MessageBox.Show("F");
           // unistr = Regex.Replace(unistr, "[@™]", "ဌ"); //System.Windows.Forms.MessageBox.Show("@");
           // unistr = Regex.Replace(unistr, "#", "ဍ");// System.Windows.Forms.MessageBox.Show("#");
           // //unistr = Regex.Replace(unistr, "$", "ဎ"); //System.Windows.Forms.MessageBox.Show("$");
           // unistr = Regex.Replace(unistr, "\\*", "ဏ"); //System.Windows.Forms.MessageBox.Show("*");
           // unistr = Regex.Replace(unistr, "t", "တ"); //System.Windows.Forms.MessageBox.Show("t");
           // unistr = Regex.Replace(unistr, "T", "ထ"); //System.Windows.Forms.MessageBox.Show("T");
           // unistr = Regex.Replace(unistr, "d", "ဒ"); //System.Windows.Forms.MessageBox.Show("d");
           // unistr = Regex.Replace(unistr, "D", "ဓ"); //System.Windows.Forms.MessageBox.Show("D");
           // unistr = Regex.Replace(unistr, "[nN]", "န"); //System.Windows.Forms.MessageBox.Show("n");
           // unistr = Regex.Replace(unistr, "p", "ပ"); //System.Windows.Forms.MessageBox.Show("p");
           // unistr = Regex.Replace(unistr, "P", "ဖ"); //System.Windows.Forms.MessageBox.Show("P");
           // unistr = Regex.Replace(unistr, "b", "ဗ"); //System.Windows.Forms.MessageBox.Show("b");
           // unistr = Regex.Replace(unistr, "B", "ဘ"); //System.Windows.Forms.MessageBox.Show("B");
           // unistr = Regex.Replace(unistr, "m", "မ"); //System.Windows.Forms.MessageBox.Show("m");
           // unistr = Regex.Replace(unistr, "y", "ယ"); //System.Windows.Forms.MessageBox.Show("y");
           // unistr = Regex.Replace(unistr, "[rR]", "ရ"); //System.Windows.Forms.MessageBox.Show("r");
           // unistr = Regex.Replace(unistr, "l", "လ"); //System.Windows.Forms.MessageBox.Show("l");
           // unistr = Regex.Replace(unistr, "w", "ဝ"); //System.Windows.Forms.MessageBox.Show("w");
           // unistr = Regex.Replace(unistr, "q", "သ"); //System.Windows.Forms.MessageBox.Show("q");
           // unistr = Regex.Replace(unistr, "h", "ဟ"); //System.Windows.Forms.MessageBox.Show("h");
           // unistr = Regex.Replace(unistr, "L", "ဠ"); //System.Windows.Forms.MessageBox.Show("L");

           // #endregion

           // #region Stacked  Consonants
           // unistr = Regex.Replace(unistr, "¶", "\u1039" + 'က');
           // unistr = Regex.Replace(unistr, "ƒ", "\u1039" + 'ခ');
           // unistr = Regex.Replace(unistr, "©", "\u1039" + 'ဂ');
           // unistr = Regex.Replace(unistr, "Ì", "\u1039" + 'ဃ');
           // unistr = Regex.Replace(unistr, "ß", "\u1039" + 'စ');
           // unistr = Regex.Replace(unistr, "Í", "\u1039" + 'ဆ');
           // unistr = Regex.Replace(unistr, "«", "\u1039" + 'ဇ');
           // unistr = Regex.Replace(unistr, "Û", "\u1039" + 'ဈ');
           // unistr = Regex.Replace(unistr, "Ë", "\u1039" + 'ည');
           // unistr = Regex.Replace(unistr, "—", "\u1039" + 'ဋ');
           // unistr = Regex.Replace(unistr, "[î|]", "\u1039" + 'တ');
           // unistr = Regex.Replace(unistr, "Ê", "\u1039" + 'ထ');
           // unistr = Regex.Replace(unistr, "»", "\u1039" + 'ဒ');
           // unistr = Regex.Replace(unistr, "Î", "\u1039" + 'ဓ');
           // unistr = Regex.Replace(unistr, "~", "\u1039" + 'န');
           // unistr = Regex.Replace(unistr, "J", "\u1039" + 'ပ');
           // unistr = Regex.Replace(unistr, "Ä", "\u1039" + 'ဖ');
           // unistr = Regex.Replace(unistr, "`", "\u1039" + 'ဗ');
           // unistr = Regex.Replace(unistr, "±", "\u1039" + 'ဘ');
           // unistr = Regex.Replace(unistr, "µ", "\u1039" + 'မ');
           // unistr = Regex.Replace(unistr, "º", "\u1039" + 'ယ');
           // unistr = Regex.Replace(unistr, "¸", "\u1039" + 'ရ');
           // unistr = Regex.Replace(unistr, "–", "\u1039" + 'ဟ');
           // unistr = Regex.Replace(unistr, "¬", "\u1039" + 'လ');

           // #endregion

           // # region Medials
           // unistr = Regex.Replace(unistr, "¥", "ျ"); // ya
           // unistr = Regex.Replace(unistr, "Á", "ျွ"); // ya + wa
           // unistr = Regex.Replace(unistr, "Y", "ျှ"); // ya + ha
           // unistr = Regex.Replace(unistr, "„", "ျွှ"); // ya + wa + ha

           // unistr = Regex.Replace(unistr, "[Â“”Œœ®]", "ြ"); // ra
           // //unistr = Regex.Replace(unistr, "[\u2018\u2019]", "ြု"); // ra + vowel u

           // unistr = Regex.Replace(unistr, "X", "ွ"); // wa            
           // unistr = Regex.Replace(unistr, "W", "ွွှ"); // wa + ha

           // unistr = Regex.Replace(unistr, "[xHÙ]", "ှ"); // ha
           // unistr = Regex.Replace(unistr, "O", "ှု");// ha + ta chaung yin
           //// unistr = Regex.Replace(unistr, "Ø", "ှူ");// ha + na chaung yin

           // #endregion

           // # region  Independent Vowels
           // unistr = Regex.Replace(unistr, "A", "အ");
           // unistr = Regex.Replace(unistr, "I", "ဣ"); // I
           // unistr = Regex.Replace(unistr, "È", "ဤ"); // II
           // unistr = Regex.Replace(unistr, "[√U\u1009]", "ဥ"); // U
           // unistr = Regex.Replace(unistr, "É", "္ဦ"); // UU
           // unistr = Regex.Replace(unistr, "[√U]+'^'", "္ဦ"); // UU
           // unistr = Regex.Replace(unistr, "[ˆ]+'\\005C'", "ဉ်");
           // unistr = Regex.Replace(unistr, "E", "ဧ"); // E
           // unistr = Regex.Replace(unistr, "Âq", "ဩ"); // ASCII letters combined, O
           // unistr = Regex.Replace(unistr, "eÂqa", "ဪ"); // ASCII letters combined, AU

           // #endregion

           // # region Dependent Vowels

           // unistr = Regex.Replace(unistr, "å", "ါ"); // Tall AA
           // unistr = Regex.Replace(unistr, "Å", "ါ်"); // Tall AA + asat
           // unistr = Regex.Replace(unistr, "a", "ာ"); // AA
           // unistr = Regex.Replace(unistr, "i", "ိ"); // I
           // unistr = Regex.Replace(unistr, "\\^", "ီ"); // II
           // unistr = Regex.Replace(unistr, "[uo]", "ု"); // U
           // unistr = Regex.Replace(unistr, "[¨ø]", "ူ"); // UU

           // unistr = Regex.Replace(unistr, "e", "ေ"); // E
           // unistr = Regex.Replace(unistr, "´", "ဲ"); // AI
           // unistr = Regex.Replace(unistr, "M", "ံ"); // ANUSVARA
           // unistr = Regex.Replace(unistr, "˜", "ိံ");

           // # endregion

           // # region Asat

           // unistr = Regex.Replace(unistr, "\\u005C", "်");

           // # endregion

           // # region Tone Marks

           // unistr = Regex.Replace(unistr, "[¿Ï.>]", "့"); //Aukmyit
           // unistr = Regex.Replace(unistr, ";", "း");//Visarga

           // # endregion

           // # region Digits

           // unistr = Regex.Replace(unistr, "0", "၀");
           // unistr = Regex.Replace(unistr, "1", "၁");
           // unistr = Regex.Replace(unistr, "2", "၂");
           // unistr = Regex.Replace(unistr, "3", "၃");
           // unistr = Regex.Replace(unistr, "4", "၄");
           // unistr = Regex.Replace(unistr, "5", "၅");
           // unistr = Regex.Replace(unistr, "6", "၆");
           // unistr = Regex.Replace(unistr, "7", "၇");
           // unistr = Regex.Replace(unistr, "8", "၈");
           // unistr = Regex.Replace(unistr, "9", "၉");

           // # endregion

           // # region Punctuation

           // unistr = Regex.Replace(unistr, "\u0027", "၊");
           // unistr = Regex.Replace(unistr, "\u0022", "။");

           // # endregion

           // # region Various Signs

           // unistr = Regex.Replace(unistr, "Ò", "၌");
           // unistr = Regex.Replace(unistr, "j", "၍");
           // unistr = Regex.Replace(unistr, "&", "၎");
           // unistr = Regex.Replace(unistr, "f", "၏");

           // # endregion

           // # region Consonant Letter Great SA

           // unistr = Regex.Replace(unistr, "Q", "ဿ");

           // # endregion

           // # region combine characters

           // unistr = Regex.Replace(unistr, "‹", "ဏ္ဍ");
           // unistr = Regex.Replace(unistr, "›", "ဏ္ဎ");
           // unistr = Regex.Replace(unistr, "£", "ဍ္ဍ");
           // unistr = Regex.Replace(unistr, "¢", "ဍ္ဎ");
           // unistr = Regex.Replace(unistr, "¤", "ဏ္ဌ");
           // unistr = Regex.Replace(unistr, "•", "ဏ္ဏ");
           // unistr = Regex.Replace(unistr, "§", "ဏ္ဋ");
           // unistr = Regex.Replace(unistr, "™", "ဋ္ဌ");
           // unistr = Regex.Replace(unistr, "¡", "ဋ္ဋ");
           // unistr = Regex.Replace(unistr, "‘", "ဠှ");
           // unistr = Regex.Replace(unistr, "£", "ဍ္ဍ");
           
           // # endregion

           // # region General

           // unistr = Regex.Replace(unistr, "{", "“");
           // unistr = Regex.Replace(unistr, "}", "”");
           // unistr = Regex.Replace(unistr, "¼", "\u0020");
           // unistr = Regex.Replace(unistr, "\u00AF", "\u2018");
           // unistr = Regex.Replace(unistr, "\u02D8", "\u2019");

           // # endregion

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
         } // end of Ava2Uni()
    }
}
