using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace UnicodeConverter
{
    public partial class TextBoxShow : SlideDialog.SlideDialog
    {
        UnicodeConverter.Converter.ConvertOption fontoption;
        Font myanmar3 = new Font("Myanmar3", 13, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
       public TextBoxShow(Form poOwner, float pfStep) : base(poOwner, pfStep)
		{
			// Cet appel est requis par le Concepteur Windows Form.
            InitializeComponent();
            string[] strarr = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\XmlMapFiles");
           // cmbFontOption.Items.Add("Select Font Option");
            for (int i = 0; i < strarr.Length; i++)
            {
                string filetype = strarr[i].Substring(strarr[i].LastIndexOf('.'));
                string tempstr = strarr[i].Substring(strarr[i].LastIndexOf('\\') + 1);
                string filename = tempstr.Substring(0, tempstr.LastIndexOf('.'));
                //if (filetype == ".xml")
                //{
                    
                    cmbFontOption.Items.Add(filename);
                //}
            }
           // FontFamily[] ff = FontFamily.Families;
           // object[] fontNames = new object[ff.Length];
          
            //for (int i = 0; i < ff.Length; i++)
            //{
            //    //fontNames[i] = ff[i].Name;
               #region Checking Font Name
                
            //      if(ff[i].Name=="I")
            //    {
            //          cmbFontName.Items.Add(ff[i].Name);
            //       // fontNames[i] = ff[i].Name;
            //    }
            //      else if (ff[i].Name.Substring(0, 3) == "Aca")
            //    {
            //        cmbFontName.Items.Add(ff[i].Name);
            //    }
            //    else if (ff[i].Name == "Amyanmar")
            //    {
            //        cmbFontName.Items.Add(ff[i].Name);
            //    }
            //    else if(ff[i].Name=="Avaforever")
            //    {
            //        cmbFontName.Items.Add(ff[i].Name);
            //    }
            //    else if (ff[i].Name.Substring(0, 2) == "CE")
            //    {
            //        cmbFontName.Items.Add(ff[i].Name);
            //    }
               
            //    else if(ff[i].Name.Substring(0,3)=="M-M")
            //    {
            //        cmbFontName.Items.Add(ff[i].Name);
            //    }
            //    else if(ff[i].Name=="Myanmar1")
            //    {
            //        cmbFontName.Items.Add(ff[i].Name);
            //    }
            //    else if(ff[i].Name=="MyaZedi")
            //    {
            //        cmbFontName.Items.Add(ff[i].Name);
            //    }
            //    else if(ff[i].Name.Substring(0,3)=="Pin")
            //    {
            //        cmbFontName.Items.Add(ff[i].Name);
            //    }
            //    else if(ff[i].Name.Substring(0,3)=="Win")
            //    {
            //        if(ff[i].Name.Substring(0,4)!="Wing")
            //            cmbFontName.Items.Add(ff[i].Name);
            //    }
            //    else if(ff[i].Name.Substring(0,3)=="Zaw")
            //    {
            //        cmbFontName.Items.Add(ff[i].Name);
            //    }
               #endregion
            //}
            //cmbFontName.Items.AddRange(fontNames);
            //cmbFontName.SelectedItem = "Zawgyi-One";
         
            //Font selectedFont = new Font(new FontFamily(cmbFontName.SelectedItem.ToString()), 12f);
            //txtToConvert.Font = selectedFont;
            //try
            //{
            //    if (!(txtToConvert.Font == null))
            //    {
            //        System.Drawing.Font currentFont = txtToConvert.Font;

            //        if (cmbFontSize.SelectedIndex > -1)
            //            txtToConvert.Font = new System.Drawing.Font(currentFont.FontFamily, Int32.Parse(cmbFontSize.Items[cmbFontSize.SelectedIndex].ToString()), currentFont.Style);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), "Error");
            //}
			// TODO : ajoutez les initialisations après l'appel à InitializeComponent
		}

    
     
       private void btnConvert_Click(object sender, EventArgs e)
       {
           if (txtToConvert.Text == "" || txtToConvert.Text == " ")
           {
               MessageBox.Show("Please Insert Texts to Convert!");
           }
           else if(cmbFontOption.SelectedItem==null)
           {
               MessageBox.Show("Please Select Font Option!");
            
           }
           else
           {
               #region Checking Font Option
               switch (cmbFontOption.SelectedIndex)
               {
                   case 0: fontoption = UnicodeConverter.Converter.ConvertOption.Academy2Uni; break;
                   case 1: fontoption = UnicodeConverter.Converter.ConvertOption.Amyanmar2Uni; break;
                   case 2: fontoption = UnicodeConverter.Converter.ConvertOption.ATypeWriter2Uni; break;
                   case 3: fontoption = UnicodeConverter.Converter.ConvertOption.Ava2Uni; break;
                   case 4: fontoption = UnicodeConverter.Converter.ConvertOption.Ayar2Uni; break;
                   case 5: fontoption = UnicodeConverter.Converter.ConvertOption.CE2Uni; break;
                   case 6: fontoption = UnicodeConverter.Converter.ConvertOption.Gandamar2Uni; break;
                   case 7: fontoption = UnicodeConverter.Converter.ConvertOption.I2Uni; break;
                   case 8: fontoption = UnicodeConverter.Converter.ConvertOption.Metrix2Uni; break;
                   case 9: fontoption = UnicodeConverter.Converter.ConvertOption.MMyanmar2Uni; break;
                   case 10: fontoption = UnicodeConverter.Converter.ConvertOption.Myanmar12Uni; break;
                   case 11: fontoption = UnicodeConverter.Converter.ConvertOption.MyaZedi2Uni; break;
                   case 12: fontoption = UnicodeConverter.Converter.ConvertOption.Pinny52Uni; break;
                   case 13: fontoption = UnicodeConverter.Converter.ConvertOption.Win2Uni; break;
                   default: fontoption = UnicodeConverter.Converter.ConvertOption.Zawgyi2Uni; break;
               }
               #endregion
              
              // string convertedOutput = UnicodeConverter.Converter.Convert(txtToConvert.Text, fontoption);
               string convertedOutput = UnicodeConverter.Converter.Convert(txtToConvert.Text, fontoption);
               txtConverted.Font = myanmar3;
               txtConverted.Text = convertedOutput;
           }
       }

      

       private void button1_Click(object sender, EventArgs e)
       {
            txtToConvert.Text = "";
       }
    }
}
