namespace kekturaForm
{
    partial class Form1
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
            this.listBoxUtvonalLista = new System.Windows.Forms.ListBox();
            this.labelSorokSzama = new System.Windows.Forms.Label();
            this.buttonAdatokMegjelenitese = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKiinduloPont = new System.Windows.Forms.TextBox();
            this.textBoxVegPont = new System.Windows.Forms.TextBox();
            this.textBoxSzakaszHossz = new System.Windows.Forms.TextBox();
            this.textBoxEmelkedes = new System.Windows.Forms.TextBox();
            this.textBoxLejtes = new System.Windows.Forms.TextBox();
            this.checkBoxPecseteloHely = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonKereses = new System.Windows.Forms.Button();
            this.textBoxKereses = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUtvonalLista
            // 
            this.listBoxUtvonalLista.FormattingEnabled = true;
            this.listBoxUtvonalLista.Location = new System.Drawing.Point(42, 38);
            this.listBoxUtvonalLista.Name = "listBoxUtvonalLista";
            this.listBoxUtvonalLista.Size = new System.Drawing.Size(336, 108);
            this.listBoxUtvonalLista.TabIndex = 0;
            this.listBoxUtvonalLista.SelectedIndexChanged += new System.EventHandler(this.listBoxUtvonalLista_SelectedIndexChanged);
            // 
            // labelSorokSzama
            // 
            this.labelSorokSzama.AutoSize = true;
            this.labelSorokSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSorokSzama.Location = new System.Drawing.Point(346, 149);
            this.labelSorokSzama.Name = "labelSorokSzama";
            this.labelSorokSzama.Size = new System.Drawing.Size(32, 13);
            this.labelSorokSzama.TabIndex = 1;
            this.labelSorokSzama.Text = "0 db";
            this.labelSorokSzama.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonAdatokMegjelenitese
            // 
            this.buttonAdatokMegjelenitese.Location = new System.Drawing.Point(412, 43);
            this.buttonAdatokMegjelenitese.Name = "buttonAdatokMegjelenitese";
            this.buttonAdatokMegjelenitese.Size = new System.Drawing.Size(139, 23);
            this.buttonAdatokMegjelenitese.TabIndex = 2;
            this.buttonAdatokMegjelenitese.Text = "Adatok megjelenítése";
            this.buttonAdatokMegjelenitese.UseVisualStyleBackColor = true;
            this.buttonAdatokMegjelenitese.Click += new System.EventHandler(this.buttonAdatokMegjelenitese_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kiinduló pont";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Végpont";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Szakasz hossz (km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emelkedés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lejtés";
            // 
            // textBoxKiinduloPont
            // 
            this.textBoxKiinduloPont.Location = new System.Drawing.Point(42, 179);
            this.textBoxKiinduloPont.Name = "textBoxKiinduloPont";
            this.textBoxKiinduloPont.ReadOnly = true;
            this.textBoxKiinduloPont.Size = new System.Drawing.Size(336, 20);
            this.textBoxKiinduloPont.TabIndex = 9;
            // 
            // textBoxVegPont
            // 
            this.textBoxVegPont.Location = new System.Drawing.Point(42, 227);
            this.textBoxVegPont.Name = "textBoxVegPont";
            this.textBoxVegPont.ReadOnly = true;
            this.textBoxVegPont.Size = new System.Drawing.Size(336, 20);
            this.textBoxVegPont.TabIndex = 10;
            // 
            // textBoxSzakaszHossz
            // 
            this.textBoxSzakaszHossz.Location = new System.Drawing.Point(42, 278);
            this.textBoxSzakaszHossz.Name = "textBoxSzakaszHossz";
            this.textBoxSzakaszHossz.ReadOnly = true;
            this.textBoxSzakaszHossz.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzakaszHossz.TabIndex = 11;
            // 
            // textBoxEmelkedes
            // 
            this.textBoxEmelkedes.Location = new System.Drawing.Point(42, 325);
            this.textBoxEmelkedes.Name = "textBoxEmelkedes";
            this.textBoxEmelkedes.ReadOnly = true;
            this.textBoxEmelkedes.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmelkedes.TabIndex = 12;
            // 
            // textBoxLejtes
            // 
            this.textBoxLejtes.Location = new System.Drawing.Point(42, 371);
            this.textBoxLejtes.Name = "textBoxLejtes";
            this.textBoxLejtes.ReadOnly = true;
            this.textBoxLejtes.Size = new System.Drawing.Size(100, 20);
            this.textBoxLejtes.TabIndex = 13;
            // 
            // checkBoxPecseteloHely
            // 
            this.checkBoxPecseteloHely.AutoSize = true;
            this.checkBoxPecseteloHely.Enabled = false;
            this.checkBoxPecseteloHely.Location = new System.Drawing.Point(127, 409);
            this.checkBoxPecseteloHely.Name = "checkBoxPecseteloHely";
            this.checkBoxPecseteloHely.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPecseteloHely.TabIndex = 14;
            this.checkBoxPecseteloHely.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pecsételőhely:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxKereses);
            this.groupBox1.Controls.Add(this.buttonKereses);
            this.groupBox1.Location = new System.Drawing.Point(414, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 85);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keresés a kiinduló pontok között";
            // 
            // buttonKereses
            // 
            this.buttonKereses.Location = new System.Drawing.Point(253, 19);
            this.buttonKereses.Name = "buttonKereses";
            this.buttonKereses.Size = new System.Drawing.Size(75, 23);
            this.buttonKereses.TabIndex = 0;
            this.buttonKereses.Text = "Keresés";
            this.buttonKereses.UseVisualStyleBackColor = true;
            this.buttonKereses.Click += new System.EventHandler(this.buttonKereses_Click);
            // 
            // textBoxKereses
            // 
            this.textBoxKereses.Location = new System.Drawing.Point(3, 16);
            this.textBoxKereses.Name = "textBoxKereses";
            this.textBoxKereses.Size = new System.Drawing.Size(244, 20);
            this.textBoxKereses.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxPecseteloHely);
            this.Controls.Add(this.textBoxLejtes);
            this.Controls.Add(this.textBoxEmelkedes);
            this.Controls.Add(this.textBoxSzakaszHossz);
            this.Controls.Add(this.textBoxVegPont);
            this.Controls.Add(this.textBoxKiinduloPont);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdatokMegjelenitese);
            this.Controls.Add(this.labelSorokSzama);
            this.Controls.Add(this.listBoxUtvonalLista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kéktúra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUtvonalLista;
        private System.Windows.Forms.Label labelSorokSzama;
        private System.Windows.Forms.Button buttonAdatokMegjelenitese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKiinduloPont;
        private System.Windows.Forms.TextBox textBoxVegPont;
        private System.Windows.Forms.TextBox textBoxSzakaszHossz;
        private System.Windows.Forms.TextBox textBoxEmelkedes;
        private System.Windows.Forms.TextBox textBoxLejtes;
        private System.Windows.Forms.CheckBox checkBoxPecseteloHely;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxKereses;
        private System.Windows.Forms.Button buttonKereses;
    }
}

