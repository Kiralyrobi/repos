namespace WindowsFormsSzoba
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
            this.textBoxHosszusag = new System.Windows.Forms.TextBox();
            this.textBoxSzelesseg = new System.Windows.Forms.TextBox();
            this.textBoxMagassag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSzamitas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAlapterulet = new System.Windows.Forms.TextBox();
            this.textBoxTerfogat = new System.Windows.Forms.TextBox();
            this.textBoxFalfelulet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxHosszusag
            // 
            this.textBoxHosszusag.Location = new System.Drawing.Point(118, 26);
            this.textBoxHosszusag.Name = "textBoxHosszusag";
            this.textBoxHosszusag.Size = new System.Drawing.Size(100, 20);
            this.textBoxHosszusag.TabIndex = 0;
            // 
            // textBoxSzelesseg
            // 
            this.textBoxSzelesseg.Location = new System.Drawing.Point(118, 69);
            this.textBoxSzelesseg.Name = "textBoxSzelesseg";
            this.textBoxSzelesseg.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzelesseg.TabIndex = 1;
            // 
            // textBoxMagassag
            // 
            this.textBoxMagassag.Location = new System.Drawing.Point(118, 115);
            this.textBoxMagassag.Name = "textBoxMagassag";
            this.textBoxMagassag.Size = new System.Drawing.Size(100, 20);
            this.textBoxMagassag.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hosszúság:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szélesség:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Magasság:";
            // 
            // buttonSzamitas
            // 
            this.buttonSzamitas.Location = new System.Drawing.Point(123, 173);
            this.buttonSzamitas.Name = "buttonSzamitas";
            this.buttonSzamitas.Size = new System.Drawing.Size(75, 23);
            this.buttonSzamitas.TabIndex = 6;
            this.buttonSzamitas.Text = "Számítás";
            this.buttonSzamitas.UseVisualStyleBackColor = true;
            this.buttonSzamitas.Click += new System.EventHandler(this.buttonSzamitas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alapterület:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Térfogat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Falfelület:";
            // 
            // textBoxAlapterulet
            // 
            this.textBoxAlapterulet.Location = new System.Drawing.Point(115, 225);
            this.textBoxAlapterulet.Name = "textBoxAlapterulet";
            this.textBoxAlapterulet.ReadOnly = true;
            this.textBoxAlapterulet.Size = new System.Drawing.Size(103, 20);
            this.textBoxAlapterulet.TabIndex = 10;
            // 
            // textBoxTerfogat
            // 
            this.textBoxTerfogat.Location = new System.Drawing.Point(115, 266);
            this.textBoxTerfogat.Name = "textBoxTerfogat";
            this.textBoxTerfogat.ReadOnly = true;
            this.textBoxTerfogat.Size = new System.Drawing.Size(103, 20);
            this.textBoxTerfogat.TabIndex = 11;
            // 
            // textBoxFalfelulet
            // 
            this.textBoxFalfelulet.Location = new System.Drawing.Point(115, 310);
            this.textBoxFalfelulet.Name = "textBoxFalfelulet";
            this.textBoxFalfelulet.ReadOnly = true;
            this.textBoxFalfelulet.Size = new System.Drawing.Size(103, 20);
            this.textBoxFalfelulet.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 367);
            this.Controls.Add(this.textBoxFalfelulet);
            this.Controls.Add(this.textBoxTerfogat);
            this.Controls.Add(this.textBoxAlapterulet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSzamitas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMagassag);
            this.Controls.Add(this.textBoxSzelesseg);
            this.Controls.Add(this.textBoxHosszusag);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szoba Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHosszusag;
        private System.Windows.Forms.TextBox textBoxSzelesseg;
        private System.Windows.Forms.TextBox textBoxMagassag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSzamitas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAlapterulet;
        private System.Windows.Forms.TextBox textBoxTerfogat;
        private System.Windows.Forms.TextBox textBoxFalfelulet;
    }
}

