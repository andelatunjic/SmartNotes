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
    public class RepozitorijDogadaji
    {
        public List<Dogadaji> DohvatiDogadaje(int idKorisnika)
        {
            List<Dogadaji> listaDogadaja = new List<Dogadaji>();
            using (var context = new Entities3())
            {
                var query = from e in context.Events
                            where e.korisnikID == idKorisnika
                            select new Dogadaji
                            {
                                DogadajID = e.dogadajID,
                                NaslovDogadaja = e.naslovDogadaja,
                                DatumDogadaja = e.datumDogadaja,
                                Omiljeno = e.omiljenDogadaj,
                                DatumPodsjetnika = e.datumPodsjetnika,
                                KorisnikID = e.korisnikID
                            };
                listaDogadaja = query.ToList();
            }
            return listaDogadaja;
        }
    }
}
