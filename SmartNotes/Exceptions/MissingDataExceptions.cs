using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotes.Exceptions
{
    public class MissingDataExceptions : ApplicationException
    {

        public string Poruka { get; set; }

        public MissingDataExceptions(string poruka)
        {
            this.Poruka = poruka;
        }
    }
}
