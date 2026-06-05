using ClassLibrarySzoba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSzoba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSzamitas_Click(object sender, EventArgs e)
        {
            try
            {
                Szoba obj = new Szoba(double.Parse(textBoxHosszusag.Text), double.Parse(textBoxSzelesseg.Text), double.Parse(textBoxMagassag.Text));
                textBoxAlapterulet.Text = obj.Alapterulet().ToString();
                textBoxFalfelulet.Text = obj.FalFelulet().ToString();
                textBoxTerfogat.Text = obj.Terfogat().ToString();
            }
            catch
            {
                MessageBox.Show("Hibás adatokat adtál meg!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxHosszusag.Text = string.Empty;
                textBoxSzelesseg.Text = string.Empty;
                textBoxMagassag.Text = string.Empty;
                textBoxAlapterulet.Text = string.Empty;
                textBoxFalfelulet.Text= string.Empty;
                textBoxTerfogat.Text= string.Empty;
            }
        }
    }
}
