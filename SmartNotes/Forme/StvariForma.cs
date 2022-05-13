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
    public partial class frmPopisStvari : Form
    {
        public Liste OdabranaLista { get; set; }
        RepozitorijStvari repozitorij = new RepozitorijStvari();
        public frmPopisStvari(Liste odabranaLista)
        {
            InitializeComponent();
            OdabranaLista = odabranaLista;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStvar.Text = "";
        }

        private void frmPopisStvari_Load(object sender, EventArgs e)
        {
            txtIdListe.Text = OdabranaLista.ListaID.ToString();
            txtNaslovListe.Text = OdabranaLista.NaslovListe;
            osvjezi();
        }

        private void osvjezi()
        {
            gridStvari.DataSource = null;
            gridStvari.DataSource = repozitorij.DohvatiStvari(OdabranaLista.ListaID);

            txtStvar.Text = "";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtStvar.Text;
            byte prekrizeno = 0;

            Stvari stvar = new Stvari();

            try
            {
                using (var context = new Entities3())
                {
                    ListThing novaStvar = new ListThing();
                    novaStvar = stvar.DodajNovuStvar(naziv, prekrizeno, OdabranaLista.ListaID);

                }
                osvjezi();

            }
            catch (MissingDataExceptions ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (InvalidLengthException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (InvalidTitleException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

            if (gridStvari.SelectedRows.Count == 1)
            {
                Stvari odabranaStvar = gridStvari.CurrentRow.DataBoundItem as Stvari;
                frmAzuriranjeStvari novaForma = new frmAzuriranjeStvari(odabranaStvar);
                novaForma.ShowDialog();
                osvjezi();
            }
            else
            {
                MessageBox.Show("Odaberite jednu listu koju želite ažurirati.");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (gridStvari.SelectedRows.Count == 1)
            {
                Stvari odabranaStvar = gridStvari.CurrentRow.DataBoundItem as Stvari;
                repozitorij.ObrisiStvar(odabranaStvar);
                osvjezi();
            }
            else
            {
                MessageBox.Show("Odaberite jednu stvar koju želite obrisati.");
            }
        }

        private void btnZatvoriBiljeska_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
