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
    public partial class frmAzuriranjeStvari : Form
    {
        public Stvari OdabranaStvar { get; set; }
        public frmAzuriranjeStvari(Stvari odabranaStvar)
        {
            InitializeComponent();
            OdabranaStvar = odabranaStvar;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAzuriranjeStvari_Load(object sender, EventArgs e)
        {
            txtNazivStvari.Text = OdabranaStvar.NazivStvari;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string naziv = txtNazivStvari.Text;

            Stvari stvar = new Stvari();

            try
            {
                ListThing stvarAzuriranje = new ListThing();
                stvarAzuriranje = stvar.AzurirajOdabranuStvar(naziv, OdabranaStvar);
                Close();
            }
            catch (MissingDataExceptions ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (InvalidLengthException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
