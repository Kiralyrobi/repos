using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12A_grafika_2
{
    public partial class Form1 : Form
    {
        private int FizetendoOsszesen {  get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGomb_Click(object sender, EventArgs e)
        {
            if(ButtonFizetes.Text=="Fizetés")
            {
                buttonBankkartya.Visible = true;
                buttonKeszpenz.Visible = true;
                ButtonFizetes.Text = "Mégsem";
            }
            else
            {
                buttonBankkartya.Visible = false;
                buttonKeszpenz.Visible = false;
                ButtonFizetes.Text = "Fizetés";
            }
        }

        private void radioButtonTea_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCitrom.Enabled=true;
            checkBoxCitrom.Checked=false;
            checkBoxKavekrem.Enabled=false;
            checkBoxTejpor.Enabled=false;
            checkBoxTejszin.Enabled=false;
            checkBoxKavekrem.Checked=false;
            checkBoxTejpor.Checked=false;
            checkBoxTejszin.Checked=false;
            Calculator();
        }

        private void radioButtonEspresso_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
            Calculator();
        }

        private void radioButtonDuplakave_CheckedChanged(object sender, EventArgs e)
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
            checkBoxCitrom.Enabled = false;
            checkBoxCitrom.Checked = false;
            checkBoxKavekrem.Enabled = true;
            checkBoxTejpor.Enabled = true;
            checkBoxTejszin.Enabled = true;
            checkBoxKavekrem.Checked = false;
            checkBoxTejpor.Checked = false;
            checkBoxTejszin.Checked = false;

        }

        private void Calculator()
        {
            int ital=0, hozzavalo=0, cukor=0;

            if (radioButtonEspresso.Checked) { ital += 140; }
            if (radioButtonDuplakave.Checked) { ital += 200; }
            if(radioButtonHosszuKave.Checked) { ital += 170; }
            if (radioButtonTea.Checked) { ital += 120; }
            textBoxItalAr.Text=ital.ToString();
            if(checkBoxCitrom.Checked) { hozzavalo += 20; }
            if (checkBoxKavekrem.Checked) { hozzavalo += 40; }
            if (checkBoxTejpor.Checked) { hozzavalo += 25; }
            if (checkBoxTejszin.Checked) { hozzavalo += 30; }
            textBoxHozzavaloAr.Text=hozzavalo.ToString();
            if (radioButtonCukorKeves.Checked) { cukor += 60; }
            if (radioCukorSok.Checked) { cukor += 10; }
            textBoxCukorAr.Text=cukor.ToString();
            FizetendoOsszesen = ital + hozzavalo + cukor;
            textBoxOsszesenAr.Text=FizetendoOsszesen.ToString();
        }

        private void checkBoxKavekrem_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void checkBoxTejszin_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void checkBoxTejpor_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void checkBoxCitrom_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void radioCukorSok_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void radioButtonCukorKeves_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void radioButtonCukorNelkul_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void buttonBankkartya_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A kártyaolvasó nem működik, sajnálom!","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void buttonKeszpenz_Click(object sender, EventArgs e)
        {
            groupBoxKeszpenzFizetes.Visible = true;

        }

        private void buttonPenzBedobas_Click(object sender, EventArgs e)
        {
            int kp = int.Parse(textBoxKeszpenz.Text);
            if( kp == FizetendoOsszesen )
            {
                labelTajekoztatas.Text = "Pont annyi!";
            }
            else if(kp>FizetendoOsszesen)
            {
                labelTajekoztatas.Text = $"Visszajáró: {kp-FizetendoOsszesen} Ft";
            }
            else
            {
                labelTajekoztatas.Text = "Ez kevés lesz...";
            }
        }
    }
}
