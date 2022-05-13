using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartNotes.Data;
using SmartNotes.Exceptions;
using SmartNotes.Klase;
using SmartNotes.Forme;

namespace SmartNotes.Forme
{
    public partial class frmAzuriranjeListe : Form
    {
        public Liste OdabranaLista { get; set; }
        public frmAzuriranjeListe(Liste odabranaLista)
        {
            InitializeComponent();
            OdabranaLista = odabranaLista;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAzuriranjeListe_Load(object sender, EventArgs e)
        {
            txtNaslovListe.Text = OdabranaLista.NaslovListe;
            if (OdabranaLista.Omiljeno == 1)
            {
                checkOmiljeno.Checked = true;
            }
            else
            {
                checkOmiljeno.Checked = false;
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslovListe.Text;
            byte omiljeno = 0;

            Liste lista = new Liste();

            if (checkOmiljeno.Checked == true)
            {
                omiljeno = 1;
            }

            try
            {
                List listaAzuriranje = new List();
                listaAzuriranje = lista.AzurirajOdabranuListu(naslov, omiljeno, OdabranaLista);
                Close();
            }
            catch (MissingDataExceptions ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (InvalidLengthException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
