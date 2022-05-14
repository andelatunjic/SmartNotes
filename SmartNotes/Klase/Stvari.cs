using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNotes.Data;
using SmartNotes.Exceptions;
using SmartNotes.Klase;
using SmartNotes.Forme;

namespace SmartNotes.Klase
{
    public class Stvari
    {
        RepozitorijStvari repozitorij = new RepozitorijStvari();
        public int StvarID { get; set; }
        public string NazivStvari { get; set; }
        public byte? Prekrizeno { get; set; }
        public int ListaID { get; set; }

        public Stvari()
        {

        }

        private Stvari(string nazivStvari, byte prekrizeno, int listaID)
        {
            this.NazivStvari = nazivStvari;
            this.Prekrizeno = prekrizeno;
            this.ListaID = listaID;
        }

        public ListThing DodajNovuStvar(string nazivStvari, byte prekrizeno, int listaID)
        {
            if (nazivStvari == "")
            {
                throw new MissingDataExceptions("Provjerite da li ste unjeli naziv stvari.");
            }
            else
            {
                provjeraNaziva(nazivStvari);

                Stvari stvar = new Stvari(nazivStvari, prekrizeno , listaID);
                ListThing novaStvar = repozitorij.DodajStvar(stvar);
                return novaStvar;
            }
        }
        public ListThing AzurirajOdabranuStvar(string nazivStvari, Stvari odabranaStvar)
        {
            if (nazivStvari == "")
            {
                throw new MissingDataExceptions("Provjerite da li ste unjeli naziv stvari.");
            }
            else
            {
                provjeraNaziva(nazivStvari);

                ListThing stvar = repozitorij.AzurirajStvar(nazivStvari, odabranaStvar);
                return stvar;
            }
        }
        private void provjeraNaziva(string nazivStvari)
        {
            if (nazivStvari.Length > 50)
            {
                throw new InvalidLengthException("Predugačak naziv stvari.");
            }
        }
    }
}
