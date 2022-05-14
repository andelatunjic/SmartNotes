using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotes.Klase
{
    public class UkupanBrojTaskovaListi
    {
        public string NazivListe { get; set; }
        public int NePrekrizeno { get; set; }
        public int Prekrizeno { get; set; }

        public UkupanBrojTaskovaListi(string naziv, int nePrekrizeno, int prekrizeno)
        {
            NazivListe = naziv;
            NePrekrizeno = nePrekrizeno;
            Prekrizeno = prekrizeno;
        }
    }
}
