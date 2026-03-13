using ClassLibraryKektura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kekturaForm
{
    public partial class Form1 : Form
    {
        private static List<Kektura> lathatoLista = new List<Kektura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Kektura.FileBeolvasas("kektura.csv");
                TeljesListaMasolat();
                ListaMegjelenites();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TeljesListaMasolat()
        {
            lathatoLista.Clear();
            foreach (var obj in Kektura.KekturaLista)
            {
                lathatoLista.Add(obj);
            }
        }

        private void ListaMegjelenites()
        {
            listBoxUtvonalLista.Items.Clear();
            foreach (var obj in lathatoLista)
            {
                listBoxUtvonalLista.Items.Add(obj.KiinduloPont);
            }
            labelSorokSzama.Text=lathatoLista.Count.ToString() + " db";
        }

        private void buttonAdatokMegjelenitese_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxUtvonalLista.SelectedItem == null)
                {
                    MessageBox.Show("Válasszon ki egy elemet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int index = listBoxUtvonalLista.SelectedIndex;
                    textBoxKiinduloPont.Text=lathatoLista[index].KiinduloPont;
                    textBoxVegPont.Text=lathatoLista[index].VegPont;
                    textBoxSzakaszHossz.Text = lathatoLista[index].SzakaszHosszKm.ToString();
                    textBoxEmelkedes.Text = lathatoLista[index].Emelkedes.ToString();
                    textBoxLejtes.Text = lathatoLista[index].Lejtes.ToString();
                    checkBoxPecseteloHely.Checked = lathatoLista[index].Pecsetelohely;


                }
            }
            catch { }
        }

        private void listBoxUtvonalLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonKereses_Click(object sender, EventArgs e)
        {
            if (textBoxKereses.Text == null)
            {
                return;
            }
            else
            {
                lathatoLista.Clear();
                string darab=textBoxKereses.Text;
                foreach(var obj in Kektura.KekturaLista)
                {
                    if(obj.KiinduloPont.Contains(darab))
                    {
                        lathatoLista.Add(obj);
                    }
                }
                ListaMegjelenites();
            }
        }
    }
}
