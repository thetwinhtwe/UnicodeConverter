using System;
using System.Text.RegularExpressions;

namespace UnicodeConverter
{
    class correct
    {
        public static string Correction1(string input)
        {

            #region declaration
            string[] C = { "က", "ခ", "ဂ", "ဃ", "င", "စ", "ဆ", "ဇ", "ဈ", "ဉ", "ည", "ဋ", "ဌ", "ဍ", "ဎ", "ဏ", "တ", "ထ", "ဒ", "ဓ", "န", "ပ", "ဖ", "ဗ", "ဘ", "မ", "ယ", "ရ", "လ", "ဝ", "သ", "ဟ", "ဠ", "အ" };
            string[] M = { "\u103B", "\u103C", "\u103D", "\u103E" };
            string[] V = { "\u102B", "\u102C", "\u102D", "\u102E", "\u102F", "\u1030", "\u1031", "\u1032", "\u1036" };
            string[] IV = { "ဣ", "ဤ", "ဥ", "ဦ", "ဧ", "ဩ", "ဪ", "၎" };
            string[] T = { "\u1037", "\u1038", "\u103A", "\u1039" };
            string[] D = { "၀", "၁", "၂", "၃", "၄", "၅", "၆", "၇", "၈", "၉" };
            string unistr = null;
            #endregion

            unistr = input;

            string pattern = "\u102D+|\u102E+|\u103D+|\u103E+|\u1032+|\u1037+|\u1036+|\u103A+";
            unistr = Regex.Replace(unistr, pattern, new MatchEvaluator(childdeldul));

            unistr = Regex.Replace(unistr, C[5] + M[0], C[8]);
            unistr = Regex.Replace(unistr, C[30] + M[1], IV[5]);
            unistr = Regex.Replace(unistr, C[30] + M[1] + V[6] + V[1] + T[2], IV[6]);
            unistr = Regex.Replace(unistr, IV[5] + V[6] + V[1] + T[2], IV[6]);
            unistr = Regex.Replace(unistr, IV[2] + V[3], IV[3]);
            unistr = Regex.Replace(unistr, IV[2] + T[3], C[9] + T[3]);
            unistr = Regex.Replace(unistr, IV[2] + T[2], C[9] + T[2]);
            unistr = Regex.Replace(unistr, IV[2] + V[1], C[9] + V[1]);
            unistr = Regex.Replace(unistr, D[4] + C[4] + T[2] + T[1], IV[7] + C[4] + T[2] + T[1]);
            unistr = Regex.Replace(unistr, T[0] + T[2], T[2] + T[0]);
            unistr = Regex.Replace(unistr, T[1] + T[2], T[2] + T[1]);

            #region Medial reordering

            unistr = Regex.Replace(unistr, M[3] + M[0], M[0] + M[3]);
            unistr = Regex.Replace(unistr, M[3] + M[1], M[1] + M[3]);
            unistr = Regex.Replace(unistr, M[3] + M[2], M[2] + M[3]);
            unistr = Regex.Replace(unistr, M[2] + M[0], M[0] + M[2]);
            unistr = Regex.Replace(unistr, M[2] + M[1], M[1] + M[2]);
            unistr = Regex.Replace(unistr, M[3] + M[2] + M[1] + "|" + M[3] + M[1] + M[2] + "|" + M[2] + M[3] + M[1] + "|" + M[2] + M[1] + M[3] + "|" + M[1] + M[3] + M[2], M[1] + M[2] + M[3]);
            unistr = Regex.Replace(unistr, M[3] + M[2] + M[0] + "|" + M[3] + M[0] + M[2] + "|" + M[2] + M[3] + M[0] + "|" + M[2] + M[0] + M[3] + "|" + M[0] + M[3] + M[2], M[0] + M[2] + M[3]);

            #endregion

            # region Vowel reordering

            unistr = Regex.Replace(unistr, V[8] + V[4], V[4] + V[8]);
            unistr = Regex.Replace(unistr, V[4] + V[2], V[2] + V[4]);
            unistr = Regex.Replace(unistr, V[8] + V[2], V[2] + V[8]);
            unistr = Regex.Replace(unistr, T[0] + V[4], V[4] + T[0]);
            unistr = Regex.Replace(unistr, T[0] + V[7], V[7] + T[0]);
            unistr = Regex.Replace(unistr, T[0] + V[8], V[8] + T[0]);

            #endregion

            # region Contracted words
            unistr = Regex.Replace(unistr, C[26] + V[6] + V[1] + C[0] + M[0] + T[2] + V[1], C[26] + V[6] + V[1] + C[0] + T[2] + M[0] + V[1]);
            unistr = Regex.Replace(unistr, C[20] + V[4] + T[2], C[20] + T[2] + V[4]);
            #endregion

            # region two times typing
            unistr = Regex.Replace(unistr, "\u103A\u103A", "\u103A");
            #endregion

            #region Recognition of digit as consonant
            unistr = Regex.Replace(unistr, D[0] + T[2], C[29] + T[2]);
            unistr = Regex.Replace(unistr, D[7] + T[2], C[27] + T[2]);
            unistr = Regex.Replace(unistr, D[8] + T[2], C[2] + T[2]);

            unistr = Regex.Replace(unistr, D[0] + T[3], C[29] + T[3]);
            unistr = Regex.Replace(unistr, D[7] + T[3], C[27] + T[3]);
            unistr = Regex.Replace(unistr, D[8] + T[3], C[2] + T[3]);

            unistr = Regex.Replace(unistr, D[0] + "(?<vowel>[" + V[0] + "-" + V[8] + "])", C[29] + "${vowel}");
            unistr = Regex.Replace(unistr, D[7] + "(?<vowel>[" + V[0] + "-" + V[8] + "])", C[27] + "${vowel}");
            unistr = Regex.Replace(unistr, D[8] + "(?<vowel>[" + V[0] + "-" + V[8] + "])", C[2] + "${vowel}");

            unistr = Regex.Replace(unistr, D[0] + "(?<medial>[" + M[0] + "-" + M[3] + "])", C[29] + "${medial}");
            unistr = Regex.Replace(unistr, D[7] + "(?<medial>[" + M[0] + "-" + M[3] + "])", C[27] + "${medial}");
            unistr = Regex.Replace(unistr, D[8] + "(?<medial>[" + M[0] + "-" + M[3] + "])", C[2] + "${medial}");

            unistr = Regex.Replace(unistr, D[0] + "(?<finale>([\u1000-\u1031][\u1039-\u103A]))", C[29] + "${finale}");
            unistr = Regex.Replace(unistr, D[7] + "(?<finale>([\u1000-\u1031][\u1039-\u103A]))", C[27] + "${finale}");
            unistr = Regex.Replace(unistr, D[8] + "(?<finale>([\u1000-\u1031][\u1039-\u103A]))", C[2] + "${finale}");
            #endregion

            #region reordering
            unistr = Regex.Replace(unistr, "(?<upper>[\u102D\u102E\u1036\u1032])(?<M>[\u103B-\u103E]+)", "${M}${upper}"); //reordering storage order
            unistr = Regex.Replace(unistr, "(?<DVs>[\u1036\u1037\u1038]+)(?<lower>[\u102F\u1030])", "${lower}${DVs}"); //reordering storage order
            unistr = unistr.Replace("့်", "့်");
            #endregion

            return unistr;
        }

        public static string childdeldul(Match m)
        {
            string x = m.Value;

            if (x.Length > 1)
            {
                x = x.Remove(1);
            }
            //else x = x;
            return x;
        }
    }
}