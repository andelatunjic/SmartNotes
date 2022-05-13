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
    public class RepozitorijStvari
    {
        public List<Stvari> DohvatiStvari(int idListe)
        {
            List<Stvari> listaStvari = new List<Stvari>();
            using (var context = new Entities3())
            {
                var query = from t in context.ListThings
                            where t.ListaID == idListe
                            select new Stvari
                            {
                                StvarID = t.stvarID,
                                NazivStvari = t.nazivStvari,
                                Prekrizeno = t.prekrizeno,
                                ListaID = t.ListaID
                            };
                listaStvari = query.ToList();
            }
            return listaStvari;
        }

        public ListThing DodajStvar(Stvari stvar)
        {
            ListThing novaStvar = new ListThing();

            using (var context = new Entities3())
            {
                var postoji = from t in context.ListThings
                              where t.nazivStvari == stvar.NazivStvari && t.ListaID == stvar.ListaID
                              select t;

                ListThing stvarPostoji = postoji.FirstOrDefault();

                if (stvarPostoji == null)
                {
                    novaStvar.nazivStvari = stvar.NazivStvari;
                    novaStvar.prekrizeno = stvar.Prekrizeno;
                    novaStvar.ListaID = stvar.ListaID;

                    context.ListThings.Add(novaStvar);
                    context.SaveChanges();
                }
                else
                {
                    throw new InvalidTitleException("Na odabranoj listi se već nalazi stvar s istim nazivom.");
                }
            }

            return novaStvar;
        }

        public ListThing AzurirajStvar(string nazivStvari, Stvari odabranaStvar)
        {
            ListThing stvarAzurirana = new ListThing();

            using (var context = new Entities3())
            {
                var pronadiStvar = from t in context.ListThings
                                   where t.nazivStvari == odabranaStvar.NazivStvari && t.ListaID == odabranaStvar.ListaID
                                   select t;

                ListThing pronadenaStvar = pronadiStvar.FirstOrDefault();

                pronadenaStvar.nazivStvari = nazivStvari;

                context.SaveChanges();

            }

            return stvarAzurirana;
        }

        public void ObrisiStvar(Stvari odabranaStvar)
        {
            using (var context = new Entities3())
            {
                var pronadiStvar = from t in context.ListThings
                                   where t.nazivStvari == odabranaStvar.NazivStvari && t.ListaID == odabranaStvar.ListaID
                                   select t;

                ListThing pronadenaStvar = pronadiStvar.FirstOrDefault();

                context.ListThings.Remove(pronadenaStvar);
                context.SaveChanges();
            }
        }

        public List<Stvari> DohvatiStvariZaPrekriziti(int idListe)
        {
            List<Stvari> listaStvari = new List<Stvari>();
            using (var context = new Entities3())
            {
                var query = from t in context.ListThings
                            where t.ListaID == idListe && t.prekrizeno == 0
                            select new Stvari
                            {
                                StvarID = t.stvarID,
                                NazivStvari = t.nazivStvari,
                                Prekrizeno = t.prekrizeno,
                                ListaID = t.ListaID
                            };
                listaStvari = query.ToList();
            }
            return listaStvari;
        }

        public List<Stvari> DohvatiStvariPrekrizene(int idListe)
        {
            List<Stvari> listaStvari = new List<Stvari>();
            using (var context = new Entities3())
            {
                var query = from t in context.ListThings
                            where t.ListaID == idListe && t.prekrizeno == 1
                            select new Stvari
                            {
                                StvarID = t.stvarID,
                                NazivStvari = t.nazivStvari,
                                Prekrizeno = t.prekrizeno,
                                ListaID = t.ListaID
                            };
                listaStvari = query.ToList();
            }
            return listaStvari;
        }

        public void PrekriziStvar(Stvari odabranaStvar)
        {
            using (var context = new Entities3())
            {
                var pronadiStvar = from t in context.ListThings
                                   where t.stvarID == odabranaStvar.StvarID
                                   select t;

                ListThing pronadenaStvar = pronadiStvar.FirstOrDefault();

                pronadenaStvar.prekrizeno = 1;

                context.SaveChanges();

            }
        }

        public void VratiStvar(Stvari odabranaStvar)
        {
            using (var context = new Entities3())
            {
                var pronadiStvar = from t in context.ListThings
                                   where t.stvarID == odabranaStvar.StvarID
                                   select t;

                ListThing pronadenaStvar = pronadiStvar.FirstOrDefault();

                pronadenaStvar.prekrizeno = 0;

                context.SaveChanges();

            }
        }

        public List<PopisStvari> DohvatiStvariSamoIme(int idListe)
        {
            List<PopisStvari> listaStvari = new List<PopisStvari>();
            using (var context = new Entities3())
            {
                var query = from t in context.ListThings
                            where t.ListaID == idListe
                            select new PopisStvari
                            {
                                Naziv = t.nazivStvari
                            };
                listaStvari = query.ToList();
            }
            return listaStvari;
        }
    }
}
