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
    public class Statistika
    {

        public int DohvatiZbrojIzradenihBiljeski(int korisnikID, DateTime datumOd, DateTime datumDo)
        {
            int zbroj = 0;

            using (var context = new Entities3())
            {
                zbroj = (from n in context.Notes
                        where n.KorisnikID == korisnikID && n.datumBiljeske >= datumOd && n.datumBiljeske <= datumDo
                        select n).Count();
            }

            return zbroj;
        }

        public int DohvatiZbrojIzradenihListi(int korisnikID, DateTime datumOd, DateTime datumDo)
        {
            int zbroj = 0;

            using (var context = new Entities3())
            {
                zbroj = (from l in context.Lists
                         where l.korisnikID == korisnikID && l.datumListe >= datumOd && l.datumListe <= datumDo
                         select l).Count();
            }

            return zbroj;
        }

        public int DohvatiZbrojIzradenihDogadaja(int korisnikID, DateTime datumOd, DateTime datumDo)
        {
            int zbroj = 0;

            using (var context = new Entities3())
            {
                zbroj = (from e in context.Events
                         where e.korisnikID == korisnikID && e.datumDogadaja >= datumOd && e.datumDogadaja <= datumDo
                         select e).Count();
            }

            return zbroj;
        }

        public int DohvatiZbrojIzradenihPodsjetnika(int korisnikID, DateTime datumOd, DateTime datumDo)
        {
            int zbroj = 0;

            using (var context = new Entities3())
            {
                zbroj = (from r in context.Reminders
                         where r.KorisnikID == korisnikID && r.datumKreiranja >= datumOd && r.datumKreiranja <= datumDo
                         select r).Count();
            }

            return zbroj;
        }
        public List<UkupanBrojZapisa> PopuniGridUkupanBrojZapisa(int korisnikID, DateTime datumOd, DateTime datumDo)
        {
            List<UkupanBrojZapisa> rezultat = new List<UkupanBrojZapisa>();

            using (var context = new Entities3())
            {
                var zbrojBiljeske = DohvatiZbrojIzradenihBiljeski(korisnikID, datumOd, datumDo);

                var zbrojListe = DohvatiZbrojIzradenihListi(korisnikID, datumOd, datumDo);

                var zbrojDogadaji = DohvatiZbrojIzradenihDogadaja(korisnikID, datumOd, datumDo);

                var zbrojPodsjetnici = DohvatiZbrojIzradenihPodsjetnika(korisnikID, datumOd, datumDo);

                rezultat.Add(new UkupanBrojZapisa(zbrojBiljeske, zbrojListe, zbrojDogadaji, zbrojPodsjetnici));
            }

            return rezultat;
        }

        public List<UkupanBrojTaskovaListi> PopuniGridTaskovi(int korisnikID, DateTime datumOd, DateTime datumDo)
        {
            List<UkupanBrojTaskovaListi> rezultat = new List<UkupanBrojTaskovaListi>();

            using (var context = new Entities3())
            {
                var liste = from l in context.Lists
                            where l.korisnikID == korisnikID && l.datumListe >= datumOd && l.datumListe <= datumDo
                            select l.listaID;

                var listeNaslov = from l in context.Lists
                            where l.korisnikID == korisnikID && l.datumListe >= datumOd && l.datumListe <= datumDo
                            select l.naslovListe;

                var lista = liste.ToList();
                int brojLista = lista.Count;
                var naslov = listeNaslov.ToList();

                for (int i = 0; i < brojLista; i++)
                {
                    int zbrojPrekrizenih = DohvatiPrekrizene(lista[i]);
                    int zbrojNePrekrizenih = DohvatiNePrekrizene(lista[i]);
                    rezultat.Add(new UkupanBrojTaskovaListi(naslov[i], zbrojNePrekrizenih, zbrojPrekrizenih));
                }
                return rezultat;
            }
        }

        private int DohvatiNePrekrizene(int idListe)
        {
            int zbroj = 0;
            using (var context = new Entities3())
            {
                var zbrojNePrekrizenihStvari = (from t in context.ListThings  
                                               where t.prekrizeno == 0 && t.ListaID == idListe
                                               select t).Count();

                zbroj = zbrojNePrekrizenihStvari;
            }
            return zbroj;
        }

        private int DohvatiPrekrizene(int idListe)
        {
            int zbroj = 0;
            using (var context = new Entities3())
            {
                var zbrojPrekrizenihStvari = (from t in context.ListThings
                                                where t.prekrizeno == 1 && t.ListaID == idListe
                                                select t).Count();

                zbroj = zbrojPrekrizenihStvari;
            }
            return zbroj;
        }





        //Ukupna statistika




        public int DohvatiZbrojIzradenihBiljeskiUkupno(DateTime datumOd, DateTime datumDo)
        {
            int zbroj = 0;

            using (var context = new Entities3())
            {
                zbroj = (from n in context.Notes
                         where n.datumBiljeske >= datumOd && n.datumBiljeske <= datumDo
                         select n).Count();
            }

            return zbroj;
        }

        public int DohvatiZbrojIzradenihListiUkupno(DateTime datumOd, DateTime datumDo)
        {
            int zbroj = 0;

            using (var context = new Entities3())
            {
                zbroj = (from l in context.Lists
                         where l.datumListe >= datumOd && l.datumListe <= datumDo
                         select l).Count();
            }

            return zbroj;
        }

        public int DohvatiZbrojIzradenihDogadajaUkupno(DateTime datumOd, DateTime datumDo)
        {
            int zbroj = 0;

            using (var context = new Entities3())
            {
                zbroj = (from e in context.Events
                         where e.datumDogadaja >= datumOd && e.datumDogadaja <= datumDo
                         select e).Count();
            }

            return zbroj;
        }

        public int DohvatiZbrojIzradenihPodsjetnikaUkupno(DateTime datumOd, DateTime datumDo)
        {
            int zbroj = 0;

            using (var context = new Entities3())
            {
                zbroj = (from r in context.Reminders
                         where r.datumKreiranja >= datumOd && r.datumKreiranja <= datumDo
                         select r).Count();
            }

            return zbroj;
        }
        public List<UkupanBrojZapisa> PopuniGridUkupanBrojZapisaUkupno(DateTime datumOd, DateTime datumDo)
        {
            List<UkupanBrojZapisa> rezultat = new List<UkupanBrojZapisa>();

            using (var context = new Entities3())
            {
                var zbrojBiljeske = DohvatiZbrojIzradenihBiljeskiUkupno(datumOd, datumDo);

                var zbrojListe = DohvatiZbrojIzradenihListiUkupno(datumOd, datumDo);

                var zbrojDogadaji = DohvatiZbrojIzradenihDogadajaUkupno(datumOd, datumDo);

                var zbrojPodsjetnici = DohvatiZbrojIzradenihPodsjetnikaUkupno(datumOd, datumDo);

                rezultat.Add(new UkupanBrojZapisa(zbrojBiljeske, zbrojListe, zbrojDogadaji, zbrojPodsjetnici));
            }

            return rezultat;
        }

        public List<UkupanBrojTaskovaListi> PopuniGridTaskoviUkupno(DateTime datumOd, DateTime datumDo)
        {
            List<UkupanBrojTaskovaListi> rezultat = new List<UkupanBrojTaskovaListi>();

            using (var context = new Entities3())
            {
                var liste = from l in context.Lists
                            where l.datumListe >= datumOd && l.datumListe <= datumDo
                            select l.listaID;

                var listeNaslov = from l in context.Lists
                                  where l.datumListe >= datumOd && l.datumListe <= datumDo
                                  select l.naslovListe;

                var lista = liste.ToList();
                int brojLista = lista.Count;
                var naslov = listeNaslov.ToList();

                for (int i = 0; i < brojLista; i++)
                {
                    int zbrojPrekrizenih = DohvatiPrekrizeneUkupno(lista[i]);
                    int zbrojNePrekrizenih = DohvatiNePrekrizeneUkupno(lista[i]);
                    rezultat.Add(new UkupanBrojTaskovaListi(naslov[i], zbrojNePrekrizenih, zbrojPrekrizenih));
                }
                return rezultat;
            }
        }

        private int DohvatiNePrekrizeneUkupno(int idListe)
        {
            int zbroj = 0;
            using (var context = new Entities3())
            {
                var zbrojNePrekrizenihStvari = (from t in context.ListThings
                                                where t.prekrizeno == 0 && t.ListaID == idListe
                                                select t).Count();

                zbroj = zbrojNePrekrizenihStvari;
            }
            return zbroj;
        }

        private int DohvatiPrekrizeneUkupno(int idListe)
        {
            int zbroj = 0;
            using (var context = new Entities3())
            {
                var zbrojPrekrizenihStvari = (from t in context.ListThings
                                              where t.prekrizeno == 1 && t.ListaID == idListe
                                              select t).Count();

                zbroj = zbrojPrekrizenihStvari;
            }
            return zbroj;
        }




    }
}
