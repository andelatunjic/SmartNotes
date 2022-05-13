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
    public class Liste
    {
        RepozitorijListe repozitorij = new RepozitorijListe();
        public int ListaID { get; set; }
        public string NaslovListe { get; set; }
        public DateTime DatumListe { get; set; }
        public byte? Omiljeno { get; set; }
        public int KorisnikID { get; set; }

        public Liste()
        {

        }

        private Liste(string naslovListe, DateTime datumListe, byte omiljeno, int korisnikID)
        {
            this.NaslovListe = naslovListe;
            this.DatumListe = datumListe;
            this.Omiljeno = omiljeno;
            this.KorisnikID = korisnikID;
        }

        public List DodajNovuListu(string naslovListe, DateTime datumListe, byte omiljeno, int korisnikID)
        {
            if (naslovListe == "")
            {
                throw new MissingDataExceptions("Provjerite da li ste unjeli naslov liste.");
            }
            else
            {
                provjeraNaslova(naslovListe);

                Liste lista = new Liste(naslovListe, datumListe, omiljeno,  korisnikID);
                List novaLista = repozitorij.DodajListu(lista);
                return novaLista;
            }
        }
        public List AzurirajOdabranuListu(string naslovListe, byte omiljeno, Liste odabranaLista)
        {
            if (naslovListe == "")
            {
                throw new MissingDataExceptions("Provjerite da li ste unjeli naslov liste.");
            }
            else
            {
                provjeraNaslova(naslovListe);

                List lista = repozitorij.AzurirajListu(naslovListe, omiljeno, odabranaLista);
                return lista;
            }
        }
        private void provjeraNaslova(string naslovListe)
        {
            if (naslovListe.Length > 25)
            {
                throw new InvalidLengthException("Predugačak naslov liste.");
            }
        }
    }
}
