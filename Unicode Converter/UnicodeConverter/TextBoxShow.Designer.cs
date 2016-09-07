namespace UnicodeConverter
{
    partial class TextBoxShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtToConvert = new System.Windows.Forms.TextBox();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFontOption = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtToConvert
            // 
            this.txtToConvert.Font = new System.Drawing.Font("Leximar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToConvert.Location = new System.Drawing.Point(6, 32);
            this.txtToConvert.Multiline = true;
            this.txtToConvert.Name = "txtToConvert";
            this.txtToConvert.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToConvert.Size = new System.Drawing.Size(454, 196);
            this.txtToConvert.TabIndex = 0;
            // 
            // txtConverted
            // 
            this.txtConverted.Font = new System.Drawing.Font("Leximar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConverted.Location = new System.Drawing.Point(6, 276);
            this.txtConverted.Multiline = true;
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.ReadOnly = true;
            this.txtConverted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConverted.Size = new System.Drawing.Size(454, 210);
            this.txtConverted.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnConvert.Font = new System.Drawing.Font("Leximar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Teal;
            this.btnConvert.Location = new System.Drawing.Point(372, 234);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(83, 25);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leximar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Converted Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leximar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "To Convert Text";
            // 
            // cmbFontOption
            // 
            this.cmbFontOption.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFontOption.Font = new System.Drawing.Font("Leximar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFontOption.ForeColor = System.Drawing.Color.DarkRed;
            this.cmbFontOption.FormattingEnabled = true;
            this.cmbFontOption.Location = new System.Drawing.Point(169, 235);
            this.cmbFontOption.Name = "cmbFontOption";
            this.cmbFontOption.Size = new System.Drawing.Size(195, 25);
            this.cmbFontOption.TabIndex = 7;
            this.cmbFontOption.Text = "Select Font Option";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Leximar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(372, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(469, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFontOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.txtToConvert);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Leximar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TextBoxShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToConvert;
        private System.Windows.Forms.TextBox txtConverted;
        public System.Windows.Forms.Button btnConvert;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbFontOption;
        public System.Windows.Forms.Button button1;
    }
}