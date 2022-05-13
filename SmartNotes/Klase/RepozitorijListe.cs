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
    public class RepozitorijListe
    {
        public List<Liste> DohvatiListe(int idKorisnika)
        {
            List<Liste> listaListi = new List<Liste>();
            using (var context = new Entities3())
            {
                var query = from l in context.Lists
                            where l.korisnikID == idKorisnika
                            select new Liste
                            {
                                ListaID = l.listaID,
                                NaslovListe = l.naslovListe,
                                DatumListe = l.datumListe,
                                Omiljeno = l.omiljenaLista,
                                KorisnikID = l.korisnikID
                            };
                listaListi = query.ToList();
            }
            return listaListi;
        }
        public List DohvatiListu(int id)
        {
            
            using (var context = new Entities3())
            {
                List lista = (from l in context.Lists
                             where l.listaID == id
                             select l).Single();
                return lista;
            }
            
        }


        public List DodajListu(Liste lista)
        {
            List novaLista = new List();

            using (var context = new Entities3())
            {
                var postoji = from l in context.Lists
                              where l.korisnikID == lista.KorisnikID && l.naslovListe == lista.NaslovListe
                              select l;

                List listaPostoji = postoji.FirstOrDefault();

                if (listaPostoji == null)
                {
                    novaLista.naslovListe = lista.NaslovListe;
                    novaLista.datumListe = lista.DatumListe;
                    novaLista.omiljenaLista = lista.Omiljeno;
                    novaLista.korisnikID = lista.KorisnikID;

                    context.Lists.Add(novaLista);
                    context.SaveChanges();
                }
                else
                {
                    throw new InvalidTitleException("Lista s odabranim naslovom već postoji.");
                }
            }

            return novaLista;
        }

        public List AzurirajListu(string naslovListe, byte omiljeno, Liste odabranaLista)
        {
            List listaAzurirana = new List();

            using (var context = new Entities3())
            {
                var pronadiListu = from l in context.Lists
                                   where l.korisnikID == odabranaLista.KorisnikID && l.naslovListe == odabranaLista.NaslovListe
                                   select l;

                List pronadenaLista = pronadiListu.FirstOrDefault();

                pronadenaLista.naslovListe = naslovListe;
                pronadenaLista.omiljenaLista = omiljeno;

                context.SaveChanges();

            }

            return listaAzurirana;
        }

        public void ObrisiListu(Liste odabranaLista)
        {
            using (var context = new Entities3())
            {
                var pronadiListu = from l in context.Lists
                                   where l.korisnikID == odabranaLista.KorisnikID && l.naslovListe == odabranaLista.NaslovListe
                                   select l;

                List pronadenaLista = pronadiListu.FirstOrDefault();

                context.Lists.Remove(pronadenaLista);
                context.SaveChanges();

            }
        }
    }
}
