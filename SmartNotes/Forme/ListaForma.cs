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

namespace SmartNotes
{
    public partial class frmLista : Form
    {
        public User PrijavljeniKorisnik { get; set; }
        RepozitorijListe repozitorij = new RepozitorijListe();
        public frmLista(User korisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = korisnik;
        }

        private void btnZatvoriLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDatum.Text = DateTime.Now.ToShortDateString();
            txtNaslov.Text = "";
            checkOmiljeno.Checked = false;
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            txtDatum.Text = DateTime.Now.ToShortDateString();
            osvjezi();
        }

        private void osvjezi()
        {
            gridListe.DataSource = null;
            gridListe.DataSource = repozitorij.DohvatiListe(PrijavljeniKorisnik.korisnikID);

            txtDatum.Text = DateTime.Now.ToShortDateString();
            txtNaslov.Text = "";
            checkOmiljeno.Checked = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslov.Text;
            DateTime datum = DateTime.Parse(txtDatum.Text);
            byte omiljeno = 0;

            Liste lista = new Liste();

            if (checkOmiljeno.Checked == true)
            {
                omiljeno = 1;
            }

            try
            {
                using (var context = new Entities3())
                {
                    List novaLista = new List();
                    novaLista = lista.DodajNovuListu(naslov, datum, omiljeno, PrijavljeniKorisnik.korisnikID);

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
            
            if (gridListe.SelectedRows.Count == 1)
            {
                Liste odabranaLista = gridListe.CurrentRow.DataBoundItem as Liste;
                frmAzuriranjeListe novaForma = new frmAzuriranjeListe(odabranaLista);
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
            
            if (gridListe.SelectedRows.Count == 1)
            {
                Liste odabranaLista = gridListe.CurrentRow.DataBoundItem as Liste;
                repozitorij.ObrisiListu(odabranaLista);
                osvjezi();
            }
            else
            {
                MessageBox.Show("Odaberite jednu listu koju želite obrisati.");
            }
        }

        private void btnPopis_Click(object sender, EventArgs e)
        {
            if (gridListe.SelectedRows.Count == 1)
            {
                Liste odabranaLista = gridListe.CurrentRow.DataBoundItem as Liste;
                frmPopisStvari novaForma = new frmPopisStvari(odabranaLista);
                novaForma.ShowDialog();
                osvjezi();
            }
            else
            {
                MessageBox.Show("Odaberite jednu listu za koju želite urediti popis stvari.");
            }
        }
    }
}
