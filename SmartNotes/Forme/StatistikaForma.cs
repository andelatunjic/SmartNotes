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
    public partial class frmStatistika : Form
    {
        public User PrijavljeniKorisnik { get; set; }
        Statistika statistika = new Statistika();
        public frmStatistika(User korisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = korisnik;
        }

        private void btnZatvoriStatistika_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStatistika_Load(object sender, EventArgs e)
        {
            if (PrijavljeniKorisnik.UlogaID != 1)
            {
                btnUkupnaStatistika.Hide();
            }
            osvjezi();
        }

        private void osvjezi()
        {
            gridUkupanBrojZapisa.DataSource = null;
            chartZapisi.Series[0].Points.Clear();

            gridTaskovi.DataSource = null;
            chartTaskovi.Series[0].Points.Clear();
            chartTaskovi.Series[1].Points.Clear();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            osvjezi();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            DateTime datumOd = pickerDatumOd.Value;
            DateTime datumDo = pickerDatumDo.Value;
            if (datumDo == null || datumDo == null)
            {
                MessageBox.Show("Odaberite razdoblje.");
            }
            else if (datumOd > datumDo)
            {
                MessageBox.Show("Krivo odabrano razdoblje.");
            }
            else
            {
                int zbrojBiljeski = statistika.DohvatiZbrojIzradenihBiljeski(PrijavljeniKorisnik.korisnikID, datumOd, datumDo);
                int zbrojLista = statistika.DohvatiZbrojIzradenihListi(PrijavljeniKorisnik.korisnikID, datumOd, datumDo);
                int zbrojDogadaja = statistika.DohvatiZbrojIzradenihDogadaja(PrijavljeniKorisnik.korisnikID, datumOd, datumDo);
                int zbrojPodsjetnika = statistika.DohvatiZbrojIzradenihPodsjetnika(PrijavljeniKorisnik.korisnikID, datumOd, datumDo);
                
                chartZapisi.Series[0].Points.Clear();
                PopuniDijagramZapisi(zbrojBiljeski, zbrojLista, zbrojDogadaja, zbrojPodsjetnika);

                gridUkupanBrojZapisa.DataSource = null;
                gridUkupanBrojZapisa.DataSource = statistika.PopuniGridUkupanBrojZapisa(PrijavljeniKorisnik.korisnikID, datumOd, datumDo);

                gridTaskovi.DataSource = null;
                gridTaskovi.DataSource = statistika.PopuniGridTaskovi(PrijavljeniKorisnik.korisnikID, datumOd, datumDo);

                chartTaskovi.Series[0].Points.Clear();
                chartTaskovi.Series[1].Points.Clear();
                var listaPodataka = statistika.PopuniGridTaskovi(PrijavljeniKorisnik.korisnikID, datumOd, datumDo);
                PopuniDijagramTaskovi(listaPodataka);
            }
        }

        private void PopuniDijagramTaskovi(List<UkupanBrojTaskovaListi> listaPodataka)
        {
            for (int i = 0; i < listaPodataka.Count; i++)
            {
                chartTaskovi.Series["Prekriženo"].Points.AddXY(listaPodataka[i].NazivListe, listaPodataka[i].Prekrizeno);
                chartTaskovi.Series["Nije prekriženo"].Points.AddXY(listaPodataka[i].NazivListe, listaPodataka[i].NePrekrizeno);
            }
            
        }

        private void PopuniDijagramZapisi(int zbrojZ, int zbrojL, int zbrojD, int zbrojP)
        {
            chartZapisi.Series["Zapisi"].Points.AddXY("Bilješke", zbrojZ);
            chartZapisi.Series["Zapisi"].Points.AddXY("Liste", zbrojL);
            chartZapisi.Series["Zapisi"].Points.AddXY("Događaji", zbrojD);
            chartZapisi.Series["Zapisi"].Points.AddXY("Podsjetnici", zbrojP);

        }

        private void btnUkupnaStatistika_Click(object sender, EventArgs e)
        {
            DateTime datumOd = pickerDatumOd.Value;
            DateTime datumDo = pickerDatumDo.Value;
            if (datumDo == null || datumDo == null)
            {
                MessageBox.Show("Odaberite razdoblje.");
            }
            else if (datumOd > datumDo)
            {
                MessageBox.Show("Krivo odabrano razdoblje.");
            }
            else
            {
                int zbrojBiljeski = statistika.DohvatiZbrojIzradenihBiljeskiUkupno(datumOd, datumDo);
                int zbrojLista = statistika.DohvatiZbrojIzradenihListiUkupno(datumOd, datumDo);
                int zbrojDogadaja = statistika.DohvatiZbrojIzradenihDogadajaUkupno(datumOd, datumDo);
                int zbrojPodsjetnika = statistika.DohvatiZbrojIzradenihPodsjetnikaUkupno(datumOd, datumDo);

                chartZapisi.Series[0].Points.Clear();
                PopuniDijagramZapisi(zbrojBiljeski, zbrojLista, zbrojDogadaja, zbrojPodsjetnika);

                gridUkupanBrojZapisa.DataSource = null;
                gridUkupanBrojZapisa.DataSource = statistika.PopuniGridUkupanBrojZapisaUkupno(datumOd, datumDo);

                gridTaskovi.DataSource = null;
                gridTaskovi.DataSource = statistika.PopuniGridTaskoviUkupno(datumOd, datumDo);

                chartTaskovi.Series[0].Points.Clear();
                chartTaskovi.Series[1].Points.Clear();
                var listaPodataka = statistika.PopuniGridTaskoviUkupno(datumOd, datumDo);
                PopuniDijagramTaskovi(listaPodataka);
            }
        }

        
    }
}
