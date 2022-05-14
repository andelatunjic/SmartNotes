using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotes.Klase
{
    public class Dogadaji
    {
        public int DogadajID { get; set; }
        public string NaslovDogadaja { get; set; }
        public DateTime DatumDogadaja { get; set; }
        public byte? Omiljeno { get; set; }
        public DateTime DatumPodsjetnika { get; set; }
        public int KorisnikID { get; set; }

        public Dogadaji()
        {

        }

        private Dogadaji(string naslovDogadaja, DateTime datumDogadaja, byte omiljeno, DateTime datumPodsjetnika, int korisnikID)
        {
            this.NaslovDogadaja = naslovDogadaja;
            this.DatumDogadaja = datumDogadaja;
            this.Omiljeno = omiljeno;
            this.DatumPodsjetnika = DatumPodsjetnika;
            this.KorisnikID = korisnikID;
        }
    }
}
