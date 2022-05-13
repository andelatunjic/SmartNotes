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
    public partial class frmBiljeska : Form
    {
        public User PrijavljeniKorisnik { get; set; }
        RepozitorijBiljeske repozitorij = new RepozitorijBiljeske();

        public frmBiljeska(User korisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = korisnik;
        }

        private void btnZatvoriBiljeska_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDatum.Text = DateTime.Now.ToShortDateString();
            txtNaslov.Text = "";
            txtOpis.Text = "";
            checkOmiljeno.Checked = false;
        }

        private void frmBiljeska_Load(object sender, EventArgs e)
        {
            txtDatum.Text = DateTime.Now.ToShortDateString();
            osvjezi();
        }

        private void osvjezi()
        {
            gridBiljeske.DataSource = null;
            gridBiljeske.DataSource = repozitorij.DohvatiBiljeske(PrijavljeniKorisnik.korisnikID);

            txtDatum.Text = DateTime.Now.ToShortDateString();
            txtNaslov.Text = "";
            txtOpis.Text = "";
            checkOmiljeno.Checked = false;
        }

        private void btnSpemi_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslov.Text;
            string tekst = txtOpis.Text;
            DateTime datum = DateTime.Parse(txtDatum.Text);
            byte omiljeno = 0;

            Biljeske biljeska = new Biljeske();

            if (checkOmiljeno.Checked == true)
            {
                omiljeno = 1;
            }

            try
            {
                using (var context = new Entities3())
                {
                    Note novaBiljeska = new Note();
                    novaBiljeska = biljeska.DodajNovuBiljesku(naslov, datum, omiljeno, tekst, PrijavljeniKorisnik.korisnikID);

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
            
            if (gridBiljeske.SelectedRows.Count == 1)
            {
                Biljeske odabranaBiljeska = gridBiljeske.CurrentRow.DataBoundItem as Biljeske;
                frmAzuriranjeBiljeske novaForma = new frmAzuriranjeBiljeske(odabranaBiljeska);
                novaForma.ShowDialog();
                osvjezi();

            }
            else
            {
                MessageBox.Show("Odaberite jednu bilješku koju želite ažurirati.");
            }

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            
            if (gridBiljeske.SelectedRows.Count == 1)
            {
                Biljeske odabranaBiljeska = gridBiljeske.CurrentRow.DataBoundItem as Biljeske;
                repozitorij.ObrisiBiljesku(odabranaBiljeska);
                osvjezi();

            }
            else
            {
                MessageBox.Show("Odaberite jednu bilješku koju želite obrisati.");
            }

        }

        
    }
}
