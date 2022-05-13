using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotes.Exceptions
{
    public class InvalidLengthException : ApplicationException
    {
        public string Poruka { get; set; }

        public InvalidLengthException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
