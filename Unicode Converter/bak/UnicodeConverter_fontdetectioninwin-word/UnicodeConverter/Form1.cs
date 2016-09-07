using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using UnicodeConverter;
namespace UnicodeConverter
{
    public partial class Form1 : Form
    {
        string srcFile;
        string desFile;
        ConvertToXml obj = new ConvertToXml();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (srcFile == null)
            {
                MessageBox.Show("Please Select a File that you want Convert..!");
            }
            else if (desFile == null)
            {
                MessageBox.Show("Please make a File that you want Save..!");
            }
            else if (fontCB.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a File Type that you want Convert..!");
            }
            else
            {
                UniConversion.Converter.ConvertOption option;
                switch (fontCB.SelectedIndex)
                {
                    case 0: option = UniConversion.Converter.ConvertOption.Amyanmar2Uni; break;
                    case 1: option = UniConversion.Converter.ConvertOption.Ava2Uni; break;
                    case 2: option = UniConversion.Converter.ConvertOption.CE2Uni; break;
                    case 3: option = UniConversion.Converter.ConvertOption.Myanmar12Uni; break;
                    case 4: option = UniConversion.Converter.ConvertOption.MyaZedi2Uni; break;
                    case 5: option = UniConversion.Converter.ConvertOption.Win2Uni; break;
                    default: option = UniConversion.Converter.ConvertOption.Zawgyi2Uni; break;
                }
                if (Conversion.Convert(srcFile, desFile, option))
                {
                    //obj.ConvertToDoc("finishxml.xml");
                    LblStatus.Text = "Converted Successfully!";
                    txtSrcFile.Text = "";
                    txtSave.Text = "";
                    fontCB.SelectedIndex = -1;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            LblStatus.Text = "";
           if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                obj.ConvertToXML(openFileDialog1.FileName);

                txtSrcFile.Text = openFileDialog1.FileName;
                srcFile = txtSrcFile.Text;
                string fileType = srcFile.Substring(srcFile.LastIndexOf('.'));
                string fileName = srcFile.Substring(0, srcFile.LastIndexOf('.'));
                desFile = fileName + "_uni" + fileType;
                if (File.Exists(desFile))
                {
                    File.Delete(desFile);
                }
                //File.Copy(srcFile, desFile);
               // txtSave.Text = desFile;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (srcFile != null)
            {
                string fileType = srcFile.Substring(srcFile.LastIndexOf('.'));

                switch (fileType)
                {
                    case ".xls": this.saveFileDialog1.Filter = "Micorsoft Excel 2003(*.xls)|*.xls";
                        break;
                    case ".xml": this.saveFileDialog1.Filter = "XML File(*.xml)|*.xml";
                        break;
                    case ".doc": this.saveFileDialog1.Filter = "Micorsoft Word 2003(*.doc)|*.doc";
                        break;
                    case ".txt": this.saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
                        break;
                }

                this.saveFileDialog1.FileName = desFile;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtSave.Text = saveFileDialog1.FileName;
                    string tem = System.IO.Directory.GetCurrentDirectory();
                    string openfilename = tem + "\\finishxml.xml";
                    obj.SaveToDoc(openfilename, saveFileDialog1.FileName);
                    LblStatus.Text = "Save Successfully!";
                    desFile = txtSave.Text;
                    //System.IO.File.Copy(srcFile, desFile);
                }
            }
            else
                MessageBox.Show("Please Select a File that you want Convert..!");
        }
        
        private void fontListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUniConverter about = new AboutUniConverter();
            about.Show();
        }

        private void fontCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}