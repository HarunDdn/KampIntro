
namespace Opp3_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chk_tasit = new System.Windows.Forms.CheckBox();
            this.chk_konut = new System.Windows.Forms.CheckBox();
            this.chk_bireysel = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chk_mailgonder = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tasitsonuc = new System.Windows.Forms.TextBox();
            this.txt_konutsonuc = new System.Windows.Forms.TextBox();
            this.txt_bireyselsonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chk_tasit
            // 
            this.chk_tasit.AutoSize = true;
            this.chk_tasit.Location = new System.Drawing.Point(46, 24);
            this.chk_tasit.Name = "chk_tasit";
            this.chk_tasit.Size = new System.Drawing.Size(87, 19);
            this.chk_tasit.TabIndex = 0;
            this.chk_tasit.Text = "Taşıt Kredisi";
            this.chk_tasit.UseVisualStyleBackColor = true;
            this.chk_tasit.CheckedChanged += new System.EventHandler(this.chk_tasit_CheckedChanged);
            // 
            // chk_konut
            // 
            this.chk_konut.AutoSize = true;
            this.chk_konut.Location = new System.Drawing.Point(46, 61);
            this.chk_konut.Name = "chk_konut";
            this.chk_konut.Size = new System.Drawing.Size(96, 19);
            this.chk_konut.TabIndex = 1;
            this.chk_konut.Text = "Konut Kredisi";
            this.chk_konut.UseVisualStyleBackColor = true;
            this.chk_konut.CheckedChanged += new System.EventHandler(this.chk_konut_CheckedChanged);
            // 
            // chk_bireysel
            // 
            this.chk_bireysel.AutoSize = true;
            this.chk_bireysel.Location = new System.Drawing.Point(46, 101);
            this.chk_bireysel.Name = "chk_bireysel";
            this.chk_bireysel.Size = new System.Drawing.Size(96, 19);
            this.chk_bireysel.TabIndex = 2;
            this.chk_bireysel.Text = "Bireysel Kredi";
            this.chk_bireysel.UseVisualStyleBackColor = true;
            this.chk_bireysel.CheckedChanged += new System.EventHandler(this.chk_bireysel_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÇEKİLECEK TUTAR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(368, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 244);
            this.listBox1.TabIndex = 6;
            // 
            // chk_mailgonder
            // 
            this.chk_mailgonder.AutoSize = true;
            this.chk_mailgonder.Location = new System.Drawing.Point(46, 233);
            this.chk_mailgonder.Name = "chk_mailgonder";
            this.chk_mailgonder.Size = new System.Drawing.Size(91, 19);
            this.chk_mailgonder.TabIndex = 7;
            this.chk_mailgonder.Text = "Mail Gonder";
            this.chk_mailgonder.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "SONUÇ";
            // 
            // txt_tasitsonuc
            // 
            this.txt_tasitsonuc.Location = new System.Drawing.Point(209, 22);
            this.txt_tasitsonuc.Name = "txt_tasitsonuc";
            this.txt_tasitsonuc.Size = new System.Drawing.Size(100, 23);
            this.txt_tasitsonuc.TabIndex = 10;
            // 
            // txt_konutsonuc
            // 
            this.txt_konutsonuc.Location = new System.Drawing.Point(209, 59);
            this.txt_konutsonuc.Name = "txt_konutsonuc";
            this.txt_konutsonuc.Size = new System.Drawing.Size(100, 23);
            this.txt_konutsonuc.TabIndex = 10;
            // 
            // txt_bireyselsonuc
            // 
            this.txt_bireyselsonuc.Location = new System.Drawing.Point(209, 97);
            this.txt_bireyselsonuc.Name = "txt_bireyselsonuc";
            this.txt_bireyselsonuc.Size = new System.Drawing.Size(100, 23);
            this.txt_bireyselsonuc.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.txt_bireyselsonuc);
            this.Controls.Add(this.txt_konutsonuc);
            this.Controls.Add(this.txt_tasitsonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chk_mailgonder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chk_bireysel);
            this.Controls.Add(this.chk_konut);
            this.Controls.Add(this.chk_tasit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_tasit;
        private System.Windows.Forms.CheckBox chk_konut;
        private System.Windows.Forms.CheckBox chk_bireysel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chk_mailgonder;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_konutsonuc;
        private System.Windows.Forms.TextBox txt_bireyselsonuc;
        public System.Windows.Forms.TextBox txt_tasitsonuc;
    }
}

