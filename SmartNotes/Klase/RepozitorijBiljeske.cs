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
    public class RepozitorijBiljeske
    {

        public List<Biljeske> DohvatiBiljeske(int idKorisnika)
        {
            List<Biljeske> listaBiljeski = new List<Biljeske>();
            using (var context = new Entities3())
            {
                var query = from n in context.Notes
                            where n.KorisnikID == idKorisnika
                            select new Biljeske
                            {
                                BiljeskaID = n.biljeskaID,
                                NaslovBiljeske = n.naslovBiljeske,
                                DatumBiljeske = n.datumBiljeske,
                                Omiljeno = n.omiljenaBiljeska,
                                TekstBiljeske = n.tekstBiljeske,
                                KorisnikID = n.KorisnikID
                            };
                listaBiljeski = query.ToList();
            }
            return listaBiljeski;
        }

        public Note DodajBiljesku(Biljeske biljeska)
        {
            Note novaBiljeska = new Note();

            using (var context = new Entities3())
            {
                var postoji = from n in context.Notes
                            where n.KorisnikID == biljeska.KorisnikID && n.naslovBiljeske == biljeska.NaslovBiljeske
                            select n;

                Note biljeskaPostoji = postoji.FirstOrDefault();

                if (biljeskaPostoji == null)
                {
                    novaBiljeska.naslovBiljeske = biljeska.NaslovBiljeske;
                    novaBiljeska.datumBiljeske = biljeska.DatumBiljeske;
                    novaBiljeska.omiljenaBiljeska = biljeska.Omiljeno;
                    novaBiljeska.tekstBiljeske = biljeska.TekstBiljeske;
                    novaBiljeska.KorisnikID = biljeska.KorisnikID;

                    context.Notes.Add(novaBiljeska);
                    context.SaveChanges();
                }
                else
                {
                    throw new InvalidTitleException("Bilješka s odabranim naslovom već postoji.");
                }
            }

            return novaBiljeska;
        }

        public Note AzurirajBiljesku(string naslovBiljeske, string tekstBiljeske, byte omiljeno, Biljeske odabranaBiljeska)
        {
            Note biljeskaAzurirana = new Note();

            using (var context = new Entities3())
            {
                var pronadiBiljesku = from n in context.Notes
                                      where n.KorisnikID == odabranaBiljeska.KorisnikID && n.naslovBiljeske == odabranaBiljeska.NaslovBiljeske
                                      select n;

                Note pronadenaBiljeska = pronadiBiljesku.FirstOrDefault();
                
                pronadenaBiljeska.naslovBiljeske = naslovBiljeske;
                pronadenaBiljeska.tekstBiljeske = tekstBiljeske;
                pronadenaBiljeska.omiljenaBiljeska = omiljeno;

                context.SaveChanges();
                
            }

            return biljeskaAzurirana;
        }

        public void ObrisiBiljesku(Biljeske odabranaBiljeska)
        {
            using (var context = new Entities3())
            {
                var pronadiBiljesku = from n in context.Notes
                                      where n.KorisnikID == odabranaBiljeska.KorisnikID && n.naslovBiljeske == odabranaBiljeska.NaslovBiljeske
                                      select n;

                Note pronadenaBiljeska = pronadiBiljesku.FirstOrDefault();

                context.Notes.Remove(pronadenaBiljeska);
                context.SaveChanges();

            }
        }



    }
}
