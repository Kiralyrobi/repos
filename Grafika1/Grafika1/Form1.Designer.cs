namespace Grafika1
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSzorzás = new System.Windows.Forms.Button();
            this.buttonOsszeadas = new System.Windows.Forms.Button();
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(692, 14);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(87, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Felhasználó név:";
            this.labelUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.PasswordChar = '*';
            this.textBoxInput.Size = new System.Drawing.Size(410, 20);
            this.textBoxInput.TabIndex = 4;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(598, 9);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Módosít";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(428, 12);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(146, 23);
            this.buttonChangeColor.TabIndex = 5;
            this.buttonChangeColor.Text = "ChangeColor";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.TextChanged += new System.EventHandler(this.x);
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Szám1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Szám2";
            // 
            // buttonSzorzás
            // 
            this.buttonSzorzás.Location = new System.Drawing.Point(202, 232);
            this.buttonSzorzás.Name = "buttonSzorzás";
            this.buttonSzorzás.Size = new System.Drawing.Size(75, 23);
            this.buttonSzorzás.TabIndex = 10;
            this.buttonSzorzás.Text = "Szorzás";
            this.buttonSzorzás.UseVisualStyleBackColor = true;
            this.buttonSzorzás.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonOsszeadas
            // 
            this.buttonOsszeadas.Location = new System.Drawing.Point(283, 232);
            this.buttonOsszeadas.Name = "buttonOsszeadas";
            this.buttonOsszeadas.Size = new System.Drawing.Size(75, 23);
            this.buttonOsszeadas.TabIndex = 11;
            this.buttonOsszeadas.Text = "Összeadás";
            this.buttonOsszeadas.UseVisualStyleBackColor = true;
            this.buttonOsszeadas.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Location = new System.Drawing.Point(436, 237);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(54, 13);
            this.labelEredmeny.TabIndex = 12;
            this.labelEredmeny.Text = "Eredmény";
            this.labelEredmeny.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEredmeny);
            this.Controls.Add(this.buttonOsszeadas);
            this.Controls.Add(this.buttonSzorzás);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelUserName);
            this.Name = "Form1";
            this.Text = "12A első grafikus programja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSzorzás;
        private System.Windows.Forms.Button buttonOsszeadas;
        private System.Windows.Forms.Label labelEredmeny;
    }
}

