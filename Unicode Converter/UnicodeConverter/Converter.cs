using System;
using System.Text;

namespace UnicodeConverter
{
    public class Converter
    {
        public enum ConvertOption
        {
            Academy2Uni,
            Amyanmar2Uni,
            ATypeWriter2Uni,
            Ava2Uni,
            Ayar2Uni,
            CE2Uni,
            Gandamar2Uni,
            I2Uni,
            Metrix2Uni,
            MMyanmar2Uni,
            Myanmar12Uni,
            MyaZedi2Uni,
            Pinny52Uni,
            Win2Uni,
            Zawgyi2Uni,
            OTHER
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="srcTxt">non-Unicode fonts input</param>
        /// <param name="option">input font name define</param>
        /// <returns>text that Unicode normative</returns>
        public static string Convert(string srcTxt, ConvertOption option)
        {
            //string zz = System.IO.Directory.GetCurrentDirectory();
            string uniTxt = "";
            switch (option)
            {
                case ConvertOption.Academy2Uni: uniTxt = AcademytoMyanmar3.Academy2Uni(srcTxt); break;
                case ConvertOption.Amyanmar2Uni: uniTxt = AmyanmarToMyanmar3.Amyanmar2Uni(srcTxt); break;
                case ConvertOption.ATypeWriter2Uni: uniTxt = ATypeWriterToMyanmar3.AType2Uni(srcTxt); break;
                case ConvertOption.Ava2Uni: uniTxt = AvaToMyanmar3.Ava2Uni(srcTxt); break;
                case ConvertOption.Ayar2Uni: uniTxt = AyarToMyanmar3.Ayar2Uni(srcTxt); break;
                case ConvertOption.CE2Uni: uniTxt = CEtoMyanmar3.CE2Uni(srcTxt); break;
                case ConvertOption.Gandamar2Uni: uniTxt = GandamarToMyanmar3.Gadamar2Uni(srcTxt); break;
                case ConvertOption.I2Uni: uniTxt = IToMyanmar3.I2Uni(srcTxt); break;
                case ConvertOption.Metrix2Uni: uniTxt = MetrixToMyanmar3.Metrix2Uni(srcTxt); break;
                case ConvertOption.MMyanmar2Uni: uniTxt = MMyanmar1ToMyanmar3.MMyanmar2Uni(srcTxt); break;
                case ConvertOption.Myanmar12Uni: uniTxt = Myanmar1ToMyanmar3.mm1ToUni(srcTxt); break;
                case ConvertOption.MyaZedi2Uni: uniTxt = MyazediToMyanmar3.MyazediToUni(srcTxt); break;
                case ConvertOption.Pinny52Uni: uniTxt = Pinny5ToMyanmar3.Pinny52Uni(srcTxt); break;
                case ConvertOption.Win2Uni: uniTxt = WinToMyanmar3.WIn2Uni(srcTxt); break;
                case ConvertOption.Zawgyi2Uni: uniTxt = ZawgyiToMyanmar3.Zawgyi2Uni(srcTxt); break;
            
            }
            return uniTxt;

        } // end of Convert()

       
        internal static void Convert()
        {
            throw new NotImplementedException();
        }
    }
}