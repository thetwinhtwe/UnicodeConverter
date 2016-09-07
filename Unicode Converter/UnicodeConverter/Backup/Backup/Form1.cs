using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UnicodeConverter
{
    public partial class Form1 : Form
    {
        TextBoxShow tbs;
        string srcFile;
        string desFile;
        bool officeFlag = false;
        Font myanmar3 = new Font("Myanmar3", 10, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(515, 506);
            fontCB.Enabled = false; 
            tbs = new TextBoxShow(this, 0.1f);
            string[] strarr = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory()+"\\XmlMapFiles");
            for (int i = 0; i < strarr.Length;i++)
            {
                //if (i == 6)
                //{
                //    fontCB.Items.Add("Myanmar1ToMyanmar3");
                //}
                //else
                //{
                    string filetype = strarr[i].Substring(strarr[i].LastIndexOf('.'));
                    string tempstr = strarr[i].Substring(strarr[i].LastIndexOf('\\')+1);
                    string filename = tempstr.Substring(0,tempstr.LastIndexOf('.'));
                   
                    
                        fontCB.Items.Add(filename);
                   
                    cmbFontOption.Items.Add(filename);
                //}
            }
           

        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            
            toggleControl();

            if (srcFile == null)
            {
                MessageBox.Show("Please Select a File that you want Convert..!");
            }
            else if (desFile == null)
            {
                MessageBox.Show("Please make a File that you want Save..!");
            }
            else if (fontCB.Enabled && fontCB.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select a File Type that you want Convert..!");
            }
            else
            {
                UnicodeConverter.Converter.ConvertOption option;
                switch (fontCB.SelectedIndex)
                {
                    case 0: option = UnicodeConverter.Converter.ConvertOption.Academy2Uni; break;
                    case 1: option = UnicodeConverter.Converter.ConvertOption.Amyanmar2Uni; break;
                    case 2: option = UnicodeConverter.Converter.ConvertOption.ATypeWriter2Uni; break;
                    case 3: option = UnicodeConverter.Converter.ConvertOption.Ava2Uni; break;
                    case 4: option = UnicodeConverter.Converter.ConvertOption.Ayar2Uni; break;
                    case 5: option = UnicodeConverter.Converter.ConvertOption.CE2Uni; break;
                    case 6: option = UnicodeConverter.Converter.ConvertOption.I2Uni; break;
                    case 7: option = UnicodeConverter.Converter.ConvertOption.MMyanmar2Uni; break;
                    case 8: option = UnicodeConverter.Converter.ConvertOption.Myanmar12Uni; break;
                    case 9: option = UnicodeConverter.Converter.ConvertOption.MyaZedi2Uni; break;
                    case 10: option = UnicodeConverter.Converter.ConvertOption.Pinny52Uni; break;
                    case 11: option = UnicodeConverter.Converter.ConvertOption.Win2Uni; break;
                    default: option = UnicodeConverter.Converter.ConvertOption.Zawgyi2Uni; break;
                }
                if (Conversion.Convert(srcFile, desFile, option))
                {
                    
                    LblStatus.Text = "Converted Successfully!";
                    txtSrcFile.Text = "";
                    txtSave.Text = "";
                    fontCB.SelectedIndex = -1;
                    string temp = desFile.Substring(0, desFile.LastIndexOf('\\')) + "\\TempXml.xml";
                    string finish = desFile.Substring(0, desFile.LastIndexOf('\\')) + "\\finishxml.xml";
                    File.Delete(temp);
                    File.Delete(finish);
                  
                }
            }
            toggleControl();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            LblStatus.Text = "";
            string cc = System.IO.Directory.GetCurrentDirectory();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string dd = System.IO.Directory.GetCurrentDirectory();
                txtSrcFile.Text = openFileDialog1.FileName;
                srcFile = txtSrcFile.Text;
                string fileType = srcFile.Substring(srcFile.LastIndexOf('.'));
                string fileName = srcFile.Substring(0, srcFile.LastIndexOf('.'));
                desFile = fileName + "_uni" + fileType;
                if (File.Exists(desFile))
                {
                    File.Delete(desFile);
                }
                File.Copy(srcFile, desFile);
                txtSave.Text = desFile;
                if (fileType.Equals(".doc") || fileType.Equals(".xls") || fileType.Equals(".docx") || fileType.Equals(".xlsx"))
                {
                    fontCB.Enabled = false;
                    officeFlag = true;
                }
                else
                {
                    fontCB.Enabled = true;
                }
            }
            System.IO.Directory.SetCurrentDirectory(cc);//******
            //string[] arr=System.IO.Directory.GetFiles(cc);
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
                    case ".xlsx": this.saveFileDialog1.Filter = "Micorsoft Excel 2007(*.xlsx)|*.xlsx";
                        break;
                    case ".xml": this.saveFileDialog1.Filter = "XML File(*.xml)|*.xml";
                        break;
                    case ".doc": this.saveFileDialog1.Filter = "Micorsoft Word 2003(*.doc)|*.doc";
                        break;
                    case ".docx": this.saveFileDialog1.Filter = "Micorsoft Word 2007(*.docx)|*.docx";
                        break;
                    case ".txt": this.saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
                        break;
                    case ".sql": this.saveFileDialog1.Filter = "SQL File(*.sql)|*.sql";
                        break;
                }

                this.saveFileDialog1.FileName = desFile;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtSave.Text = saveFileDialog1.FileName;
                    desFile = txtSave.Text;
                    System.IO.File.Copy(srcFile, desFile);
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

        private void toggleControl()
        {
            txtSrcFile.Enabled = !txtSrcFile.Enabled;
            btnBrowse.Enabled = !btnBrowse.Enabled;
            txtSave.Enabled = !txtSave.Enabled;
            btnSave.Enabled = !btnSave.Enabled;
            Console.WriteLine("docFlag:::" + officeFlag);
            if (!officeFlag)
            {
                fontCB.Enabled = !fontCB.Enabled;
            }
            else
            {
                officeFlag = false;
            }
            convertBtn.Enabled = !convertBtn.Enabled;
            closeBtn.Enabled = !closeBtn.Enabled;
        }

        private void clearScreen()
        {
            txtSrcFile.Text = "";
            txtSrcFile.Enabled = true;
            btnBrowse.Enabled = true;
            txtSave.Text = "";
            txtSave.Enabled = true;
            btnSave.Enabled = true;
            fontCB.Enabled = true;
            convertBtn.Enabled = true;
            closeBtn.Enabled = true;
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = System.IO.Directory.GetCurrentDirectory() + "\\Myanmar Unicode Converter(User Manual).pdf";
            System.Diagnostics.Process.Start(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == ">>")
            {
                button1.Text = "<<";
            }
            else button1.Text = ">>";
            tbs.SlideDirection = SlideDialog.SlideDialog.SLIDE_DIRECTION.RIGHT;
            tbs.Slide();
           
        }
        bool flag = true;
        private void btnLanguage_Click(object sender, EventArgs e)
        {
           //UnicodeConverter.TextBoxShow tbs = new UnicodeConverter.TextBoxShow();
            System.Data.DataSet ds = new System.Data.DataSet();
            string xmlpath = System.IO.Directory.GetCurrentDirectory() + "\\language.xml";
            ds.ReadXml(xmlpath);
            System.Data.DataRowCollection drc = ds.Tables["languageTable"].Rows;
          
            if (flag)
            {
                btnLanguage.BackgroundImage = UnicodeConverter.Properties.Resources.uk_flag;
                flag = false;
                foreach (System.Data.DataRow dr in drc)
                {
                    if (fileToolStripMenuItem.Text==dr[0].ToString())
                    {
                        fileToolStripMenuItem.Font = myanmar3;
                        fileToolStripMenuItem.Text = fileToolStripMenuItem.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (exitToolStripMenuItem.Text == dr[0].ToString())
                    {
                        exitToolStripMenuItem.Font = myanmar3;
                        exitToolStripMenuItem.Text = exitToolStripMenuItem.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (supportedToolStripMenuItem.Text == dr[0].ToString())
                    {
                        supportedToolStripMenuItem.Font = myanmar3;
                        supportedToolStripMenuItem.Text = supportedToolStripMenuItem.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (fontListToolStripMenuItem.Text == dr[0].ToString())
                    {
                        fontListToolStripMenuItem.Font = myanmar3;
                        fontListToolStripMenuItem.Text = fontListToolStripMenuItem.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (userManualToolStripMenuItem.Text == dr[0].ToString())
                    {
                        userManualToolStripMenuItem.Font = myanmar3;
                        userManualToolStripMenuItem.Text = userManualToolStripMenuItem.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (groupBox1.Text == dr[0].ToString())
                    {
                        groupBox1.Font = myanmar3;
                        groupBox1.Text = groupBox1.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (label3.Text == dr[0].ToString())
                    {
                        label3.Font = myanmar3;
                        label3.Text = label3.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (label1.Text == dr[0].ToString())
                    {
                        label1.Font = myanmar3;
                        label1.Text = label1.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (label5.Text == dr[0].ToString())
                    {
                        label5.Font = myanmar3;
                        label5.Text = label5.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (btnBrowse.Text == dr[0].ToString())
                    {
                        btnBrowse.Font = myanmar3;
                        btnBrowse.Text = btnBrowse.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (btnSave.Text == dr[0].ToString())
                    {
                        btnSave.Font = myanmar3;
                        btnSave.Text = btnSave.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (convertBtn.Text == dr[0].ToString())
                    {
                        convertBtn.Font = myanmar3;
                        convertBtn.Text = convertBtn.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (closeBtn.Text == dr[0].ToString())
                    {
                        closeBtn.Font = myanmar3;
                        closeBtn.Text = closeBtn.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (lblLanguage.Text == dr[0].ToString())
                    {
                        lblLanguage.Font = myanmar3;
                        lblLanguage.Text = lblLanguage.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (label2.Text == dr[0].ToString())
                    {
                        label2.Font = myanmar3;
                        label2.Text =label2.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (label1.Text == dr[0].ToString())
                    {
                        label1.Font = myanmar3;
                        label1.Text = label1.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (label6.Text == dr[0].ToString())
                    {
                        label6.Font = myanmar3;
                        label6.Text = label6.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (cmbFontOption.Text == dr[0].ToString())
                    {
                        cmbFontOption.Font = myanmar3;
                        cmbFontOption.Text = cmbFontOption.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (btnConvert.Text == dr[0].ToString())
                    {
                        btnConvert.Font = myanmar3;
                        btnConvert.Text = btnConvert.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    if (button2.Text == dr[0].ToString())
                    {
                        button2.Font = myanmar3;
                        button2.Text = button2.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    }
                    //if (tbs.label2.Text == dr[0].ToString())
                    //{
                    //    tbs.label2.Font = myanmar3;
                    //    tbs.label2.Text = tbs.label2.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    //}
                    //if (tbs.label1.Text == dr[0].ToString())
                    //{
                    //    tbs.label1.Font = myanmar3;
                    //    tbs.label1.Text = tbs.label1.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    //}
                    //if (tbs.cmbFontOption.Text == dr[0].ToString())
                    //{
                    //    tbs.cmbFontOption.Font = myanmar3;
                    //    tbs.cmbFontOption.Text = tbs.cmbFontOption.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    //}
                    //if (tbs.btnConvert.Text == dr[0].ToString())
                    //{
                    //    tbs.btnConvert.Font = myanmar3;
                    //    tbs.btnConvert.Text = tbs.btnConvert.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    //}
                    //if (tbs.button1.Text == dr[0].ToString())
                    //{
                    //    tbs.button1.Font = myanmar3;
                    //    tbs.button1.Text = tbs.button1.Text.Replace(dr[0].ToString(), dr[1].ToString());
                    //}
                }
            }
            else
            {
                btnLanguage.BackgroundImage = UnicodeConverter.Properties.Resources.myflag;
                flag = true;
                foreach (System.Data.DataRow dr in drc)
                {
                    if (fileToolStripMenuItem.Text == dr[1].ToString())
                    {
                        fileToolStripMenuItem.Text = fileToolStripMenuItem.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (exitToolStripMenuItem.Text == dr[1].ToString())
                    {
                        exitToolStripMenuItem.Text = exitToolStripMenuItem.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (supportedToolStripMenuItem.Text == dr[1].ToString())
                    {
                        supportedToolStripMenuItem.Text = supportedToolStripMenuItem.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (fontListToolStripMenuItem.Text == dr[1].ToString())
                    {
                        fontListToolStripMenuItem.Text = fontListToolStripMenuItem.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (userManualToolStripMenuItem.Text == dr[1].ToString())
                    {
                        userManualToolStripMenuItem.Text = userManualToolStripMenuItem.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (groupBox1.Text == dr[1].ToString())
                    {
                        groupBox1.Text = groupBox1.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (label3.Text == dr[1].ToString())
                    {
                        label3.Text = label3.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (label1.Text == dr[1].ToString())
                    {
                        label1.Text = label1.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (label5.Text == dr[1].ToString())
                    {
                        label5.Text = label5.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (btnBrowse.Text == dr[1].ToString())
                    {
                        btnBrowse.Text = btnBrowse.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (btnSave.Text == dr[1].ToString())
                    {
                        btnSave.Text = btnSave.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (convertBtn.Text == dr[1].ToString())
                    {
                        convertBtn.Text = convertBtn.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (closeBtn.Text == dr[1].ToString())
                    {
                        closeBtn.Text = closeBtn.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (lblLanguage.Text == dr[1].ToString())
                    {
                        lblLanguage.Text = lblLanguage.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (label2.Text == dr[1].ToString())
                    {
                        label2.Text = label2.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (label1.Text == dr[1].ToString())
                    {
                        label1.Text = label1.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (label6.Text == dr[1].ToString())
                    {
                        label6.Text = label6.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (cmbFontOption.Text == dr[1].ToString())
                    {
                        cmbFontOption.Text = cmbFontOption.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (btnConvert.Text == dr[1].ToString())
                    {
                        btnConvert.Text = btnConvert.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    if (button2.Text == dr[1].ToString())
                    {
                        button2.Text = button2.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    }
                    //if (tbs.label2.Text == dr[1].ToString())
                    //{
                    //    tbs.label2.Text = tbs.label2.Text.Replace(dr[1].ToString(), dr[0].ToString());
                       
                    //}
                    //if (tbs.label1.Text == dr[1].ToString())
                    //{
                    //    tbs.label1.Text = tbs.label1.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    //}
                    //if (tbs.cmbFontOption.Text == dr[1].ToString())
                    //{
                    //    tbs.cmbFontOption.Text = tbs.cmbFontOption.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    //}
                    //if (tbs.btnConvert.Text == dr[1].ToString())
                    //{
                    //    tbs.btnConvert.Text = tbs.btnConvert.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    //}
                    //if (tbs.button1.Text == dr[1].ToString())
                    //{
                    //    tbs.button1.Text = tbs.button1.Text.Replace(dr[1].ToString(), dr[0].ToString());

                    //}
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestForm tf = new TestForm();
            tf.Show();
            //tf.ShowDialog();

        }

        private void btnLanguage_MouseHover(object sender, EventArgs e)
        {
            lblLanguage.Visible = true;
        }

        private void btnLanguage_MouseLeave(object sender, EventArgs e)
        {
            lblLanguage.Visible = false;
        }

        private void btnSlideTest_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            if (btnSlideTest.Text == ">>")
            {
                btnSlideTest.Text = "<<";
                this.Size= new System.Drawing.Size(1015, 506);
             
            }
            else
            {
                btnSlideTest.Text = ">>";
                this.Size = new System.Drawing.Size(515, 506);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtToConvert.Text == "" || txtToConvert.Text == " ")
            {
                MessageBox.Show("Please Insert Texts to Convert!");
            }
            else if (cmbFontOption.SelectedItem == null)
            {
                MessageBox.Show("Please Select Font Option!");

            }
            else
            {

                #region Checking Font Option
                UnicodeConverter.Converter.ConvertOption fontoption;
                switch (cmbFontOption.SelectedIndex)
                {
                    case 0: fontoption = UnicodeConverter.Converter.ConvertOption.Academy2Uni; break;
                    case 1: fontoption = UnicodeConverter.Converter.ConvertOption.Amyanmar2Uni; break;
                    case 2: fontoption = UnicodeConverter.Converter.ConvertOption.ATypeWriter2Uni; break;
                    case 3: fontoption = UnicodeConverter.Converter.ConvertOption.Ava2Uni; break;
                    case 4: fontoption = UnicodeConverter.Converter.ConvertOption.Ayar2Uni; break;
                    case 5: fontoption = UnicodeConverter.Converter.ConvertOption.CE2Uni; break;
                    case 6: fontoption = UnicodeConverter.Converter.ConvertOption.I2Uni; break;
                    case 7: fontoption = UnicodeConverter.Converter.ConvertOption.Metrix2Uni; break;
                    case 8: fontoption = UnicodeConverter.Converter.ConvertOption.MMyanmar2Uni; break;
                    case 9: fontoption = UnicodeConverter.Converter.ConvertOption.Myanmar12Uni; break;
                    case 10: fontoption = UnicodeConverter.Converter.ConvertOption.MyaZedi2Uni; break;
                    case 11: fontoption = UnicodeConverter.Converter.ConvertOption.Pinny52Uni; break;
                    case 12: fontoption = UnicodeConverter.Converter.ConvertOption.Win2Uni; break;
                    default: fontoption = UnicodeConverter.Converter.ConvertOption.Zawgyi2Uni; break;
                }
                #endregion
                string convertedOutput = UnicodeConverter.Converter.Convert(txtToConvert.Text, fontoption);
                txtConverted.Font = myanmar3;
                txtConverted.Text = convertedOutput;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtToConvert.Text = "";
        }

                
    }
}