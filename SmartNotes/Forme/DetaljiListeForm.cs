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
    public partial class frmDetaljiListe : Form
    {
        public Liste OdabranaLista { get; set; }
        RepozitorijStvari repozitorij = new RepozitorijStvari();

        
        public frmDetaljiListe(Liste odabranaLista)
        {
            InitializeComponent();
            OdabranaLista = odabranaLista;
        }

        private void btnZatvoriPretraga_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetaljiListe_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = OdabranaLista.NaslovListe;
            txtDatum.Text = OdabranaLista.DatumListe.ToShortDateString();
            osvjezi();
        }

        private void osvjezi()
        {
            gridPrekrizi.DataSource = null;
            gridPrekrizi.DataSource = repozitorij.DohvatiStvariZaPrekriziti(OdabranaLista.ListaID);
           
            gridPrekrizeno.DataSource = null;
            gridPrekrizeno.DataSource = repozitorij.DohvatiStvariPrekrizene(OdabranaLista.ListaID);
        }

        private void btnPrekrizi_Click(object sender, EventArgs e)
        {
            if (gridPrekrizi.SelectedRows.Count == 1)
            {
                Stvari odabranaStvar = gridPrekrizi.CurrentRow.DataBoundItem as Stvari;
                repozitorij.PrekriziStvar(odabranaStvar);
                osvjezi();
            }
            else
            {
                MessageBox.Show("Odaberite jednu stvar koju želite prekrižiti s liste.");
            }
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            if (gridPrekrizeno.SelectedRows.Count == 1)
            {
                Stvari odabranaStvar = gridPrekrizeno.CurrentRow.DataBoundItem as Stvari;
                repozitorij.VratiStvar(odabranaStvar);
                osvjezi();
            }
            else
            {
                MessageBox.Show("Odaberite jednu stvar koju želite prekrižiti s liste.");
            }
        }
    }
}
