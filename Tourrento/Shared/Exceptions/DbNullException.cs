using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.Shared.Exceptions
{
    public class DbNullException : Exception
    {
        public DbNullException() : base("Nem található elem az adatbázisban.")
        {
        }

    }
}
