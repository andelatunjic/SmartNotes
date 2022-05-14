using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotes.Klase
{
    public class UkupanBrojZapisa
    {
        public int ZbrojBiljeski { get; set; }
        public int ZbrojLista { get; set; }
        public int ZbrojDogadaja { get; set; }
        public int ZbrojPodsjetnika { get; set; }

        public UkupanBrojZapisa(int zbrojB, int zbrojL, int zbrojD, int zbrojP)
        {
            ZbrojBiljeski = zbrojB;
            ZbrojLista = zbrojL;
            ZbrojDogadaja = zbrojD;
            ZbrojPodsjetnika = zbrojP;
        }
    }
}
