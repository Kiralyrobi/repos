using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jaja
{
    public partial class Form1 : Form
    {
        private int FizetendoOsszesen {  get; set; }
        public Form1()
        {
            InitializeComponent();
            Calculator();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void labelEredmeny_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGomb_Click_1(object sender, EventArgs e)
        {
            if (buttonFizetes.Text == "Fizetés")
            {
                buttonBankkartya.Visible = true;
                buttonKeszPenz.Visible = true;
                buttonFizetes.Text = "Mégsem";
            }
            else
            {
                buttonBankkartya.Visible = false;
                buttonKeszPenz.Visible = false;
                buttonFizetes.Text = "Fizetés";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Citrom.Enabled = true;
            Citrom.Checked = false;
            checkBoxKávéKrém.Enabled = false;
            checkBoxTejpor.Enabled = false;
            checkBoxTejszín.Enabled = false;
            checkBoxKávéKrém.Checked = false;
            checkBoxTejpor.Checked = false;
            checkBoxTejszín.Checked = false;
            Calculator();
        }
        private void radioButtonEspresso_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Calculator();
        }

        private void radioButtonDuplaKave_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Calculator();
        }

        private void radioButtonHosszuKave_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Calculator();
        }
        private void IngredientsSettings()
        {
            Citrom.Enabled = false;
            Citrom.Checked = false;
            checkBoxKávéKrém.Enabled = true;
            checkBoxTejpor.Enabled = true;
            checkBoxTejszín.Enabled = true;
            checkBoxKávéKrém.Checked = false;
            checkBoxTejpor.Checked =false;
            checkBoxTejszín.Checked = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Calculator()
        {
            int ital=0, hozzavalo=0, cukor=0, osszesen=0;
            if(radioButtonEspresso.Checked ) { ital += 140; }
            if (radioButtonDuplaKave.Checked) { ital += 200; }
            if(radioButtonHosszuKave.Checked ) { ital += 170; }
            if (Tea.Checked) { ital += 120; }
            textBoxItalAr.Text=ital.ToString();

            if (Citrom.Checked) { hozzavalo += 20; }
            if (checkBoxKávéKrém.Checked) { hozzavalo += 40; }
            if (checkBoxTejpor.Checked) { hozzavalo += 25; }
            if (checkBoxTejszín.Checked) { hozzavalo += 30; }
            textBoxHozzavalokAr.Text=hozzavalo.ToString();

            if(radioButtonKevésCukor.Checked) { cukor += 60; }
            if (radioButtonSokCukor.Checked) { cukor += 10; }
            textBoxCukorAr.Text=cukor.ToString();
            FizetendoOsszesen = ital + hozzavalo + cukor;
            textBoxOsszesenAr.Text=FizetendoOsszesen.ToString();
        }

        private void checkBoxKávéKrém_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void checkBoxTejszín_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void checkBoxTejpor_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }
        private void Citrom_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void radioButtonSokCukor_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void radioButtonKevésCukor_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void radioButtonCukorNelkul_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void buttonBankkartya_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A kártyolvasó nem működik, sajnálom! (Szemben van egy ATM :)  )", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonKeszPenz_Click(object sender, EventArgs e)
        {
            groupBoxKeszpenzFizetes.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxKészpénz.Text == "")
            {
                textBoxKészpénz.Text = "0";
            }
            int kp = int.Parse(textBoxKészpénz.Text);
            if (kp == FizetendoOsszesen)
            {
                labelTajekoztatas.Text = "Pont annyi!";
            }
            else if(kp>FizetendoOsszesen)
            {
                labelTajekoztatas.Text = $"Visszajáró: {kp - FizetendoOsszesen} Ft";
            }
            else
            {
                labelTajekoztatas.Text = "Ez kevés lesz...";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            groupBoxKeszpenzFizetes.Visible =false;
            buttonBankkartya.Visible =false;
            buttonKeszPenz.Visible =false;
            buttonFizetes.Text = "Fizetés";
            IngredientsSettings();
            radioButtonCukorNelkul.Checked = true;
            radioButtonEspresso.Checked = true;
            Calculator();

        }
    }
}
