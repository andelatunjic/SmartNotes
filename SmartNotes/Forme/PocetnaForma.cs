using SmartNotes.Data;
using SmartNotes.Forme;
using SmartNotes.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartNotes
{
    public partial class frmPocetna : Form
    {

        public User prijavljeniKorisnik = new User();
        public frmPocetna(User korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
            prilagodiDizajn();
            lblKorisnickoIme.Text = prijavljeniKorisnik.ime.ToString() + " " + prijavljeniKorisnik.prezime.ToString();
        }

        #region Dizajn
        private void prilagodiDizajn()
        {
            panelDodaj.Visible = false;
        }
        private void prikaziSakrijPanelDodaj()
        {
            if (panelDodaj.Visible == true)
            {
                panelDodaj.Visible = false;
            }
            else
            {
                panelDodaj.Visible = true;
            }
        }
        private void sakrijPanelDodaj()
        {
            if (panelDodaj.Visible == true)
            {
                panelDodaj.Visible = false;
            }
        }
        #endregion

        #region Otvaranje nove forme unutar panela na početnoj formi
        private Form aktivnaForma = null;
        private void OtvoriFormu(Form novaForma)
        {
            if (aktivnaForma != null)
            {
                aktivnaForma.Close();
            }
            aktivnaForma = novaForma;
            novaForma.TopLevel = false;
            novaForma.FormBorderStyle = FormBorderStyle.None;
            novaForma.Dock = DockStyle.Fill;
            panelNovaForma.Controls.Add(novaForma);
            panelNovaForma.Tag = novaForma;
            novaForma.BringToFront();
            novaForma.FormClosed += novaForma_FormClosed;
            novaForma.Show();

        }

        private void novaForma_FormClosed(object sender, FormClosedEventArgs e)
        {

            KorisniciRepozitorij korisniciRepozitorij = new KorisniciRepozitorij();
            prijavljeniKorisnik = korisniciRepozitorij.dohvatiKorisnika(prijavljeniKorisnik.korisnikID);
            lblKorisnickoIme.Text = prijavljeniKorisnik.ime.ToString() + " " + prijavljeniKorisnik.prezime.ToString();
        }
        #endregion
        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            prikaziSakrijPanelDodaj();
        }

        private void btnDodajBiljesku_Click(object sender, EventArgs e)
        {
            sakrijPanelDodaj();
            OtvoriFormu(new frmBiljeska(prijavljeniKorisnik));
        }

        private void btnDodajListu_Click(object sender, EventArgs e)
        {
            sakrijPanelDodaj();
            OtvoriFormu(new frmLista(prijavljeniKorisnik));
        }

        private void btnDodajDogadaj_Click(object sender, EventArgs e)
        {
            sakrijPanelDodaj();
            OtvoriFormu(new frmDogadaj());
        }

        private void btnFavoriti_Click(object sender, EventArgs e)
        {
            sakrijPanelDodaj();
            OtvoriFormu(new OmiljeniZapisiForma(prijavljeniKorisnik));
        }

        private void btnGrupe_Click(object sender, EventArgs e)
        {
            sakrijPanelDodaj();
            OtvoriFormu(new frmGrupe());
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            sakrijPanelDodaj();
            OtvoriFormu(new frmStatistika(prijavljeniKorisnik));
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            PocetnaPrijavaForma pocetna = new PocetnaPrijavaForma();
            this.Hide();
            pocetna.ShowDialog();
            this.Close();

        }

        private void btnMojiZapisi_Click(object sender, EventArgs e)
        {
            sakrijPanelDodaj();
            OtvoriFormu(new frmPretraga(prijavljeniKorisnik));
        }

        private void lblKorisnickoIme_Click(object sender, EventArgs e)
        {
            sakrijPanelDodaj();
            OtvoriFormu(new frmKorisnickiRacun(prijavljeniKorisnik));


        }


        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            KorisniciRepozitorij korisniciRepozitorij = new KorisniciRepozitorij();
            prijavljeniKorisnik = korisniciRepozitorij.dohvatiKorisnika(prijavljeniKorisnik.korisnikID);
            lblKorisnickoIme.Text = prijavljeniKorisnik.ime.ToString() + " " + prijavljeniKorisnik.prezime.ToString();


        }


        private void ButtonPodsjetnik_Click(object sender, EventArgs e)
        {
            sakrijPanelDodaj();
            OtvoriFormu(new PodsjetnikForma(prijavljeniKorisnik));

        }

        private void FrmPocetna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
    
