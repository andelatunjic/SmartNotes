using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotes.Exceptions
{
    public class NoItemException : ApplicationException
    {

        public string Greska { get; set; }

        public NoItemException(string greska)
        {
            this.Greska = greska;
        }
    }
}
