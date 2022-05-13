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
using SmartNotes.Klase;
using SmartNotes.Forme;

namespace SmartNotes.Forme

{
    public partial class ListaPopis : Form
    {
        public List odabranaLista = new List();
        public ListaPopis(List lista)
        {
            InitializeComponent();
            odabranaLista = lista;
        }

        private void ListaPopis_Load(object sender, EventArgs e)
        {
            RepozitorijStvari repozitorij = new RepozitorijStvari();
            txtNaslov.Text = odabranaLista.naslovListe.ToString();
            txtDatum.Text = odabranaLista.datumListe.ToShortDateString();
            checkOmiljeno.Checked = true;

            txtNaslov.Enabled = false;
            txtDatum.Enabled = false;
            checkOmiljeno.Enabled = false;

            List<PopisStvari> popis = repozitorij.DohvatiStvariSamoIme(odabranaLista.listaID);

            dataGridView1.DataSource = popis;

            
        }
    }
}
