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
    public class Biljeske
    {
        RepozitorijBiljeske repozitorij = new RepozitorijBiljeske();
        public int BiljeskaID { get; set; }
        public string NaslovBiljeske { get; set; }
        public DateTime DatumBiljeske { get; set; }
        public byte? Omiljeno { get; set; }
        public string TekstBiljeske { get; set; }
        public int KorisnikID { get; set; }

        public Biljeske()
        {
            
        }
        private Biljeske(string naslovBiljeske, DateTime datumBiljeske, byte omiljeno, string tekstBiljeske, int korisnikID)
        {
            this.NaslovBiljeske = naslovBiljeske;
            this.DatumBiljeske = datumBiljeske;
            this.Omiljeno = omiljeno;
            this.TekstBiljeske = tekstBiljeske;
            this.KorisnikID = korisnikID;
        }
        public Note DodajNovuBiljesku(string naslovBiljeske, DateTime datumBiljeske, byte omiljeno, string tekstBiljeske, int korisnikID)
        {
            if (naslovBiljeske == "" || tekstBiljeske == "")
            {
                throw new MissingDataExceptions("Provjerite da li ste unjeli naslov i tekst bilješke.");
            }
            else
            {
                provjeraNaslova(naslovBiljeske);
                provjeraTeksta(tekstBiljeske);

                Biljeske biljeska = new Biljeske(naslovBiljeske, datumBiljeske, omiljeno, tekstBiljeske, korisnikID);
                Note novaBiljeska = repozitorij.DodajBiljesku(biljeska);
                return novaBiljeska;
            }
        }

        private void provjeraTeksta(string tekstBiljeske)
        {
            if (tekstBiljeske.Length > 1000)
            {
                throw new InvalidLengthException("Predugačka bilješka.");
            }
        }

        private void provjeraNaslova(string naslovBiljeske)
        {
            if (naslovBiljeske.Length > 25)
            {
                throw new InvalidLengthException("Predugačak naziv.");
            }
        }

        public Note AzurirajOdabranuBiljesku(string naslovBiljeske, string tekstBiljeske, byte omiljeno, Biljeske odabranaBiljeska)
        {
            if (naslovBiljeske == "" || tekstBiljeske == "")
            {
                throw new MissingDataExceptions("Provjerite da li ste unjeli naslov i tekst bilješke.");
            }
            else
            {
                provjeraNaslova(naslovBiljeske);

                Note biljeska = repozitorij.AzurirajBiljesku(naslovBiljeske, tekstBiljeske, omiljeno, odabranaBiljeska);
                return biljeska;
            }
        }

    }
}
