using ClassLibraryFürjes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fürj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClassFurj.FileBeolvasas("furjek.csv");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Új fürj bevitel")
            {
                groupBoxKozos.Visible = true;
                button1.Text = "Vissza";
                buttonFurjekListaja.Visible = false;
                FurjekListaja.Visible = false;
                buttonFurjesKep.Visible = false;
                groupBoxFurjKep.Visible = false;
            }
            else
            {
                groupBoxKozos.Visible = false;
                button1.Text = "Új fürj bevitel";
                buttonFurjekListaja.Visible = true;
                FurjekListaja.Visible = false;
                buttonFurjekListaja.Text = "Fürjek listája";
                buttonFurjesKep.Visible = true;
                groupBoxFurjKep.Visible = false;
                buttonFurjesKep.Text = "Fürj képek";
 
            }
        }

        private void buttonFurjekListaja_Click(object sender, EventArgs e)
        {
            if (buttonFurjekListaja.Text == "Fürjek listája")
            {
                FurjekListaja.Visible = true;
                buttonFurjekListaja.Text = "Vissza";
            }
            else
            {
                FurjekListaja.Visible = false;
                buttonFurjekListaja.Text = "Fürjek listája";
            }
            try
            {
                FurjekListaja.Items.Clear();

                foreach (ClassFurj f in ClassFurj.FürjekLista)
                {
                    FurjekListaja.Items.Add(f);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void buttonHozzaad_Click(object sender, EventArgs e)
        {
            try
            {
                int sorszam = int.Parse(textBoxFurjekSorszama.Text);

                if (ClassFurj.FürjekLista.Any(furj => furj.Sorszam == sorszam))
                {
                    MessageBox.Show("Már létezik ilyen sorszámú fürj!","Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fajta = textBoxFaj.Text;
                int tojikE = radioButtonIgen.Checked ? 1 : 0;
                int eletkor = int.Parse(textBoxEletkor.Text);
                string sor = $"{sorszam},{fajta},{tojikE},{eletkor}";

                ClassFurj ujFurj = new ClassFurj(sor);

                FurjekListaja.Items.Add(ujFurj.Sorszam + "\t" + ujFurj.Fajta + "\t" + ujFurj.TojikE + "\t" + ujFurj.Eletkor);

                textBoxFurjekSorszama.Clear();
                textBoxFaj.Clear();
                textBoxEletkor.Clear();
                radioButtonIgen.Checked = false;
                radioButtonNem.Checked = false ;

                MessageBox.Show("Adatok sikeresen hozzáadva a listához!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
      

        private void groupBoxFaj_Enter(object sender, EventArgs e)
        {

        }

        private void labelTexasFurjKep_Click(object sender, EventArgs e)
        {

        }

        private void buttonFurjesKep_Click(object sender, EventArgs e)
        {
            if(buttonFurjesKep.Text=="Fürj képek")
            {
                groupBoxFurjKep.Visible = false;
                buttonFurjesKep.Text = "Vissza";
                groupBoxFurjKep.Visible=true;

            }
            else
            {
                groupBoxFurjKep.Visible = true;
                buttonFurjesKep.Text = "Fürj képek";
                groupBoxFurjKep.Visible = false;

            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (buttonMenu.Text == "MENÜ")
            {
                button1.Visible = true;
                buttonFurjekListaja.Visible = true;
                buttonFurjesKep.Visible = true;
                buttonFoOldal.Visible = true;

                buttonMenu.Visible = false;
            }
        }

        private void buttonFoOldal_Click(object sender, EventArgs e)
        {
            buttonMenu.Visible = true;
            button1.Visible = false;
            buttonFurjekListaja.Visible = false;
            buttonFurjesKep.Visible = false;
        }
    }
}