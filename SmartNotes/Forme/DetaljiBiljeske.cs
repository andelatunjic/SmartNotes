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
    public partial class frmDetaljiBiljeske : Form
    {
        public Biljeske OdabranaBiljeska { get; set; }
        public frmDetaljiBiljeske(Biljeske odabranaBiljeska)
        {
            InitializeComponent();
            OdabranaBiljeska = odabranaBiljeska;
        }

        private void btnZatvoriPretraga_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetaljiBiljeske_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = OdabranaBiljeska.NaslovBiljeske;
            txtDatum.Text = OdabranaBiljeska.DatumBiljeske.ToShortDateString();
            txtOpisBiljeske.Text = OdabranaBiljeska.TekstBiljeske;

            txtNaslov.Enabled = false;
            txtDatum.Enabled = false;
            txtOpisBiljeske.Enabled = false;
            checkOmiljeno.Enabled = false;

            if (OdabranaBiljeska.Omiljeno == 1)
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
