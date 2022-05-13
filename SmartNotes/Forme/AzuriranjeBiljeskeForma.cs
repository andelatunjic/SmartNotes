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
    public partial class frmAzuriranjeBiljeske : Form
    {
        public Biljeske OdabranaBiljeska { get; set; }
        public frmAzuriranjeBiljeske(Biljeske odabranaBiljeska)
        {
            InitializeComponent();
            OdabranaBiljeska = odabranaBiljeska;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAzuriranjeBiljeske_Load(object sender, EventArgs e)
        {
            txtNaslovBiljeske.Text = OdabranaBiljeska.NaslovBiljeske;
            txtOpis.Text = OdabranaBiljeska.TekstBiljeske;
            if (OdabranaBiljeska.Omiljeno == 1)
            {
                checkOmiljeno.Checked = true;
            }
            else
            {
                checkOmiljeno.Checked = false;
            }
            biljeskaHelp.HelpNamespace = AppDomain.CurrentDomain.BaseDirectory + "biljeska.html";
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslovBiljeske.Text;
            string tekst = txtOpis.Text;
            byte omiljeno = 0;

            Biljeske biljeska = new Biljeske();

            if (checkOmiljeno.Checked == true)
            {
                omiljeno = 1;
            }

            try
            {
                Note biljeskaAzuriranje = new Note();
                biljeskaAzuriranje = biljeska.AzurirajOdabranuBiljesku(naslov, tekst, omiljeno, OdabranaBiljeska);
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
