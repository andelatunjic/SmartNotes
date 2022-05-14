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
    public class FiltriranjeSortiranje
    {

        public List<Biljeske> DohvatiSortiraneBiljeske(int idKorisnika, string combo, string silaznoUzlazno)
        {
            List<Biljeske> rezultatSortiranja = new List<Biljeske>();
            using (var context = new Entities3())
            {
                if (silaznoUzlazno == "uzlazno")
                {
                    if (combo == "ID")
                    {
                        var query = from n in context.Notes
                                    where n.KorisnikID == idKorisnika
                                    orderby n.biljeskaID
                                    select new Biljeske
                                    {
                                        BiljeskaID = n.biljeskaID,
                                        NaslovBiljeske = n.naslovBiljeske,
                                        DatumBiljeske = n.datumBiljeske,
                                        Omiljeno = n.omiljenaBiljeska,
                                        TekstBiljeske = n.tekstBiljeske,
                                        KorisnikID = n.KorisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Naslov")
                    {
                        var query = from n in context.Notes
                                    where n.KorisnikID == idKorisnika
                                    orderby n.naslovBiljeske
                                    select new Biljeske
                                    {
                                        BiljeskaID = n.biljeskaID,
                                        NaslovBiljeske = n.naslovBiljeske,
                                        DatumBiljeske = n.datumBiljeske,
                                        Omiljeno = n.omiljenaBiljeska,
                                        TekstBiljeske = n.tekstBiljeske,
                                        KorisnikID = n.KorisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Datum")
                    {
                        var query = from n in context.Notes
                                    where n.KorisnikID == idKorisnika
                                    orderby n.datumBiljeske
                                    select new Biljeske
                                    {
                                        BiljeskaID = n.biljeskaID,
                                        NaslovBiljeske = n.naslovBiljeske,
                                        DatumBiljeske = n.datumBiljeske,
                                        Omiljeno = n.omiljenaBiljeska,
                                        TekstBiljeske = n.tekstBiljeske,
                                        KorisnikID = n.KorisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }

                }
                else
                {
                    if (combo == "ID")
                    {
                        var query = from n in context.Notes
                                    where n.KorisnikID == idKorisnika
                                    orderby n.biljeskaID descending
                                    select new Biljeske
                                    {
                                        BiljeskaID = n.biljeskaID,
                                        NaslovBiljeske = n.naslovBiljeske,
                                        DatumBiljeske = n.datumBiljeske,
                                        Omiljeno = n.omiljenaBiljeska,
                                        TekstBiljeske = n.tekstBiljeske,
                                        KorisnikID = n.KorisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Naslov")
                    {
                        var query = from n in context.Notes
                                    where n.KorisnikID == idKorisnika
                                    orderby n.naslovBiljeske descending
                                    select new Biljeske
                                    {
                                        BiljeskaID = n.biljeskaID,
                                        NaslovBiljeske = n.naslovBiljeske,
                                        DatumBiljeske = n.datumBiljeske,
                                        Omiljeno = n.omiljenaBiljeska,
                                        TekstBiljeske = n.tekstBiljeske,
                                        KorisnikID = n.KorisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Datum")
                    {
                        var query = from n in context.Notes
                                    where n.KorisnikID == idKorisnika
                                    orderby n.datumBiljeske descending
                                    select new Biljeske
                                    {
                                        BiljeskaID = n.biljeskaID,
                                        NaslovBiljeske = n.naslovBiljeske,
                                        DatumBiljeske = n.datumBiljeske,
                                        Omiljeno = n.omiljenaBiljeska,
                                        TekstBiljeske = n.tekstBiljeske,
                                        KorisnikID = n.KorisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                }



            }

            if (rezultatSortiranja == null)
            {
                throw new MissingDataExceptions("Nemate zapise koje možete sortirati.");
            }
            else
            {
                return rezultatSortiranja;
            }
        }

        public List<Liste> DohvatiSortiraneListe(int idKorisnika, string combo, string silaznoUzlazno)
        {
            List<Liste> rezultatSortiranja = new List<Liste>();

            using (var context = new Entities3())
            {
                if (silaznoUzlazno == "uzlazno")
                {
                    if (combo == "ID")
                    {
                        var query = from l in context.Lists
                                    where l.korisnikID == idKorisnika
                                    orderby l.listaID
                                    select new Liste
                                    {
                                        ListaID = l.listaID,
                                        NaslovListe = l.naslovListe,
                                        DatumListe = l.datumListe,
                                        Omiljeno = l.omiljenaLista,
                                        KorisnikID = l.korisnikID
                                    };

                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Naslov")
                    {
                        var query = from l in context.Lists
                                    where l.korisnikID == idKorisnika
                                    orderby l.naslovListe
                                    select new Liste
                                    {
                                        ListaID = l.listaID,
                                        NaslovListe = l.naslovListe,
                                        DatumListe = l.datumListe,
                                        Omiljeno = l.omiljenaLista,
                                        KorisnikID = l.korisnikID
                                    };

                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Datum")
                    {
                        var query = from l in context.Lists
                                    where l.korisnikID == idKorisnika
                                    orderby l.datumListe
                                    select new Liste
                                    {
                                        ListaID = l.listaID,
                                        NaslovListe = l.naslovListe,
                                        DatumListe = l.datumListe,
                                        Omiljeno = l.omiljenaLista,
                                        KorisnikID = l.korisnikID
                                    };

                        rezultatSortiranja = query.ToList();
                    }
                }
                else
                {
                    if (combo == "ID")
                    {
                        var query = from l in context.Lists
                                    where l.korisnikID == idKorisnika
                                    orderby l.listaID descending
                                    select new Liste
                                    {
                                        ListaID = l.listaID,
                                        NaslovListe = l.naslovListe,
                                        DatumListe = l.datumListe,
                                        Omiljeno = l.omiljenaLista,
                                        KorisnikID = l.korisnikID
                                    };

                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Naslov")
                    {
                        var query = from l in context.Lists
                                    where l.korisnikID == idKorisnika
                                    orderby l.naslovListe descending
                                    select new Liste
                                    {
                                        ListaID = l.listaID,
                                        NaslovListe = l.naslovListe,
                                        DatumListe = l.datumListe,
                                        Omiljeno = l.omiljenaLista,
                                        KorisnikID = l.korisnikID
                                    };

                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Datum")
                    {
                        var query = from l in context.Lists
                                    where l.korisnikID == idKorisnika
                                    orderby l.datumListe descending
                                    select new Liste
                                    {
                                        ListaID = l.listaID,
                                        NaslovListe = l.naslovListe,
                                        DatumListe = l.datumListe,
                                        Omiljeno = l.omiljenaLista,
                                        KorisnikID = l.korisnikID
                                    };

                        rezultatSortiranja = query.ToList();
                    }
                }
            }

            if (rezultatSortiranja == null)
            {
                throw new MissingDataExceptions("Nemate zapise koje možete sortirati.");
            }
            else
            {
                return rezultatSortiranja;
            }
        }

        public List<Dogadaji> DohvatiSortiraneDogadaje(int idKorisnika, string combo, string silaznoUzlazno)
        {
            List<Dogadaji> rezultatSortiranja = new List<Dogadaji>();

            using (var context = new Entities3())
            {

                if (silaznoUzlazno == "uzlazno")
                {
                    if (combo == "ID")
                    {
                        var query = from e in context.Events
                                    where e.korisnikID == idKorisnika
                                    orderby e.dogadajID
                                    select new Dogadaji
                                    {
                                        DogadajID = e.dogadajID,
                                        NaslovDogadaja = e.naslovDogadaja,
                                        DatumDogadaja = e.datumDogadaja,
                                        Omiljeno = e.omiljenDogadaj,
                                        DatumPodsjetnika = e.datumPodsjetnika,
                                        KorisnikID = e.korisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Naslov")
                    {
                        var query = from e in context.Events
                                    where e.korisnikID == idKorisnika
                                    orderby e.naslovDogadaja
                                    select new Dogadaji
                                    {
                                        DogadajID = e.dogadajID,
                                        NaslovDogadaja = e.naslovDogadaja,
                                        DatumDogadaja = e.datumDogadaja,
                                        Omiljeno = e.omiljenDogadaj,
                                        DatumPodsjetnika = e.datumPodsjetnika,
                                        KorisnikID = e.korisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Datum")
                    {
                        var query = from e in context.Events
                                    where e.korisnikID == idKorisnika
                                    orderby e.datumPodsjetnika
                                    select new Dogadaji
                                    {
                                        DogadajID = e.dogadajID,
                                        NaslovDogadaja = e.naslovDogadaja,
                                        DatumDogadaja = e.datumDogadaja,
                                        Omiljeno = e.omiljenDogadaj,
                                        DatumPodsjetnika = e.datumPodsjetnika,
                                        KorisnikID = e.korisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                }
                else
                {
                    if (combo == "ID")
                    {
                        var query = from e in context.Events
                                    where e.korisnikID == idKorisnika
                                    orderby e.dogadajID descending
                                    select new Dogadaji
                                    {
                                        DogadajID = e.dogadajID,
                                        NaslovDogadaja = e.naslovDogadaja,
                                        DatumDogadaja = e.datumDogadaja,
                                        Omiljeno = e.omiljenDogadaj,
                                        DatumPodsjetnika = e.datumPodsjetnika,
                                        KorisnikID = e.korisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Naslov")
                    {
                        var query = from e in context.Events
                                    where e.korisnikID == idKorisnika
                                    orderby e.naslovDogadaja descending
                                    select new Dogadaji
                                    {
                                        DogadajID = e.dogadajID,
                                        NaslovDogadaja = e.naslovDogadaja,
                                        DatumDogadaja = e.datumDogadaja,
                                        Omiljeno = e.omiljenDogadaj,
                                        DatumPodsjetnika = e.datumPodsjetnika,
                                        KorisnikID = e.korisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                    else if (combo == "Datum")
                    {
                        var query = from e in context.Events
                                    where e.korisnikID == idKorisnika
                                    orderby e.datumPodsjetnika descending
                                    select new Dogadaji
                                    {
                                        DogadajID = e.dogadajID,
                                        NaslovDogadaja = e.naslovDogadaja,
                                        DatumDogadaja = e.datumDogadaja,
                                        Omiljeno = e.omiljenDogadaj,
                                        DatumPodsjetnika = e.datumPodsjetnika,
                                        KorisnikID = e.korisnikID
                                    };
                        rezultatSortiranja = query.ToList();
                    }
                }
            }
            if (rezultatSortiranja == null)
            {
                throw new MissingDataExceptions("Nemate zapise koje možete sortirati.");
            }
            else
            {
                return rezultatSortiranja;
            }
            
        }

        public List<Biljeske> DohvatiRezultatTrazenjaBiljeske(int idKorisnika, string naslov)
        {
            List<Biljeske> rezultatPretrage = new List<Biljeske>();
            if (naslov == "")
            {
                throw new InvalidTitleException("Niste unjeli naslov za pretraživanje");
            }
            else
            {
                using (var context = new Entities3())
                {
                    var query = from n in context.Notes
                                where n.KorisnikID == idKorisnika && n.naslovBiljeske.Contains(naslov)
                                select new Biljeske
                                {
                                    BiljeskaID = n.biljeskaID,
                                    NaslovBiljeske = n.naslovBiljeske,
                                    DatumBiljeske = n.datumBiljeske,
                                    Omiljeno = n.omiljenaBiljeska,
                                    KorisnikID = n.KorisnikID
                                };

                    rezultatPretrage = query.ToList();
                }

                if (rezultatPretrage == null)
                {
                    throw new MissingDataExceptions("Nemate zapise pod tim imenom.");
                }
                else
                {
                    return rezultatPretrage;
                }
            }
            
        }

        public List<Liste> DohvatiRezultatTrazenjaListe(int idKorisnika, string naslov)
        {
            List<Liste> rezultatPretrage = new List<Liste>();
            if (naslov == "")
            {
                throw new InvalidTitleException("Niste unjeli naslov za pretraživanje");
            }
            else
            {
                using (var context = new Entities3())
                {
                    var query = from l in context.Lists
                                where l.korisnikID == idKorisnika && l.naslovListe.Contains(naslov)
                                select new Liste
                                {
                                    ListaID = l.listaID,
                                    NaslovListe = l.naslovListe,
                                    DatumListe = l.datumListe,
                                    Omiljeno = l.omiljenaLista,
                                    KorisnikID = l.korisnikID
                                };
                    rezultatPretrage = query.ToList();
                }

                if (rezultatPretrage == null)
                {
                    throw new MissingDataExceptions("Nemate zapise pod tim imenom.");
                }
                else
                {
                    return rezultatPretrage;
                }
            }

            
        }

        public List<Dogadaji> DohvatiRezultatTrazenjaDogadaja(int idKorisnika, string naslov)
        {
            List<Dogadaji> rezultatPretrage = new List<Dogadaji>();
            if (naslov == "")
            {
                throw new InvalidTitleException("Niste unjeli naslov za pretraživanje");
            }
            else
            {
                using (var context = new Entities3())
                {
                    var query = from e in context.Events
                                where e.korisnikID == idKorisnika && e.naslovDogadaja.Contains(naslov)
                                select new Dogadaji
                                {
                                    DogadajID = e.dogadajID,
                                    NaslovDogadaja = e.naslovDogadaja,
                                    DatumDogadaja = e.datumDogadaja,
                                    Omiljeno = e.omiljenDogadaj,
                                    DatumPodsjetnika = e.datumPodsjetnika,
                                    KorisnikID = e.korisnikID
                                };
                    rezultatPretrage = query.ToList();
                }

                if (rezultatPretrage == null)
                {
                    throw new MissingDataExceptions("Nemate zapise pod tim imenom.");
                }
                else
                {
                    return rezultatPretrage;
                }
            }
            
        }
    }
}
