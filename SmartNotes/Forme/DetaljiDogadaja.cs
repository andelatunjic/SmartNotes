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
    public partial class frmDetaljiDogadaja : Form
    {
        public Dogadaji OdabraniDogadaj { get; set; }
        public frmDetaljiDogadaja(Dogadaji odabraniDogadaj)
        {
            InitializeComponent();
            OdabraniDogadaj = odabraniDogadaj;
        }

        private void btnZatvoriPretraga_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetaljiDogadaja_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = OdabraniDogadaj.NaslovDogadaja;
            txtDatum.Text = OdabraniDogadaj.DatumDogadaja.ToShortDateString();
            txtDatumPodsjetnika.Text = OdabraniDogadaj.DatumPodsjetnika.ToShortDateString();

            if (OdabraniDogadaj.Omiljeno == 1)
            {
                checkOmiljeno.Checked = true;
            }
            else
            {
                checkOmiljeno.Checked = false;
            }
        }
    }
}
