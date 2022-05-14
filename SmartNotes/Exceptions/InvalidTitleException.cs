using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotes.Exceptions
{
    class InvalidTitleException : ApplicationException
    {
        public string Poruka { get; set; }

        public InvalidTitleException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
