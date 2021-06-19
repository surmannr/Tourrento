using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.Shared.Exceptions
{
    public class InvalidParameterException : Exception
    {
        public InvalidParameterException() : base("Érvénytelen paraméter(ek) / nem megadott paraméter(ek).")
        {
        }
    }
}
