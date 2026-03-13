using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grafika1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            labelUserName.Text=textBoxInput.Text;
            buttonChangeColor.ForeColor=Color.Red;
        }

        private void x(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {


            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
        

            labelEredmeny.Text = "Eredmény: " + (a * b);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            labelEredmeny.Text = "Eredmény: " + (a + b);
        }
    }
}
