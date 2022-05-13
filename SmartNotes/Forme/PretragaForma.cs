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
    public partial class frmPretraga : Form
    {
        public User PrijavljeniKorisnik { get; set; }

        FiltriranjeSortiranje prikazi = new FiltriranjeSortiranje();
        RepozitorijBiljeske biljeske = new RepozitorijBiljeske();
        RepozitorijListe liste = new RepozitorijListe();
        RepozitorijDogadaji dogadaji = new RepozitorijDogadaji();

        public frmPretraga(User korisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = korisnik;
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            if (panelPretraga.Visible == false)
            {
                panelPretraga.Visible = true;
            }
            else
            {
                panelPretraga.Visible = false;
            }

        }

        private void btnZatvoriPretraga_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            panelPretraga.Visible = false;
            comboNaslovDatum.Items.Add("ID");
            comboNaslovDatum.Items.Add("Naslov");
            comboNaslovDatum.Items.Add("Datum");
            comboNaslovDatum.SelectedIndex = 0;
            osvjezi();
        }

        private void osvjezi()
        {
            if (radioBiljeska.Checked == true)
            {
                gridPrikaz.DataSource = null;
                gridPrikaz.DataSource = biljeske.DohvatiBiljeske(PrijavljeniKorisnik.korisnikID);
            }
            else if (radioLista.Checked == true)
            {
                gridPrikaz.DataSource = null;
                gridPrikaz.DataSource = liste.DohvatiListe(PrijavljeniKorisnik.korisnikID);
            }
            else if (radioDogadaj.Checked == true)
            {
                gridPrikaz.DataSource = null;
                gridPrikaz.DataSource = dogadaji.DohvatiDogadaje(PrijavljeniKorisnik.korisnikID);
            }
            
        }

        private void radioBiljeska_CheckedChanged(object sender, EventArgs e)
        {
            osvjezi();
        }

        private void radioLista_CheckedChanged(object sender, EventArgs e)
        {
            osvjezi();
        }

        private void radioDogadaj_CheckedChanged(object sender, EventArgs e)
        {
            osvjezi();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslovPretraga.Text;

            try
            {
                if (radioBiljeska.Checked == true)
                {
                    gridPrikaz.DataSource = null;
                    gridPrikaz.DataSource = prikazi.DohvatiRezultatTrazenjaBiljeske(PrijavljeniKorisnik.korisnikID, naslov);
                }
                else if (radioLista.Checked == true)
                {
                    gridPrikaz.DataSource = null;
                    gridPrikaz.DataSource = prikazi.DohvatiRezultatTrazenjaListe(PrijavljeniKorisnik.korisnikID, naslov);
                }
                else if (radioDogadaj.Checked == true)
                {
                    gridPrikaz.DataSource = null;
                    gridPrikaz.DataSource = prikazi.DohvatiRezultatTrazenjaDogadaja(PrijavljeniKorisnik.korisnikID, naslov);
                }
            }
            catch (MissingDataExceptions ex)
            {
                MessageBox.Show(ex.Poruka);
                osvjezi();
            }
            catch (InvalidTitleException ex)
            {
                MessageBox.Show(ex.Poruka);
                osvjezi();
            }
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            string uzlaznoSilazno = "uzlazno";
            if (radioSilazno.Checked == true)
            {
                uzlaznoSilazno = "silazno";
            }
            string opcijaCombo = comboNaslovDatum.SelectedItem.ToString();

            try
            {
                if (radioBiljeska.Checked == true)
                {
                    gridPrikaz.DataSource = null;
                    gridPrikaz.DataSource = prikazi.DohvatiSortiraneBiljeske(PrijavljeniKorisnik.korisnikID, opcijaCombo, uzlaznoSilazno);
                }
                else if (radioLista.Checked == true)
                {
                    gridPrikaz.DataSource = null;
                    gridPrikaz.DataSource = prikazi.DohvatiSortiraneListe(PrijavljeniKorisnik.korisnikID, opcijaCombo, uzlaznoSilazno);
                }
                else if (radioDogadaj.Checked == true)
                {
                    gridPrikaz.DataSource = null;
                    gridPrikaz.DataSource = prikazi.DohvatiSortiraneDogadaje(PrijavljeniKorisnik.korisnikID, opcijaCombo, uzlaznoSilazno);
                }
            }
            catch (MissingDataExceptions ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (radioBiljeska.Checked == true)
            {
                if (gridPrikaz.SelectedRows.Count == 1)
                {
                    Biljeske odabranaBiljeska = gridPrikaz.CurrentRow.DataBoundItem as Biljeske;
                    frmDetaljiBiljeske novaForma = new frmDetaljiBiljeske(odabranaBiljeska);
                    novaForma.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Odaberite jednu bilješku za koju želite vidjeti detalje.");
                }
            }
            else if (radioLista.Checked == true)
            {
                if (gridPrikaz.SelectedRows.Count == 1)
                {
                    Liste odabranaLista = gridPrikaz.CurrentRow.DataBoundItem as Liste;
                    frmDetaljiListe novaForma = new frmDetaljiListe(odabranaLista);
                    novaForma.ShowDialog();
                    osvjezi();
                }
                else
                {
                    MessageBox.Show("Odaberite jedan zapis za prikaz detalja.");
                }

            }
            else if (radioDogadaj.Checked == true)
            {
                if (gridPrikaz.SelectedRows.Count == 1)
                {
                    Dogadaji odabraniDogadaj = gridPrikaz.CurrentRow.DataBoundItem as Dogadaji;
                    frmDetaljiDogadaja novaForma = new frmDetaljiDogadaja(odabraniDogadaj);
                    novaForma.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Odaberite jedan događaj za kojeg želite vidjeti detalje.");
                }
            }
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            frmPDF pdf = new frmPDF();
            this.Close();
            pdf.ShowDialog();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
