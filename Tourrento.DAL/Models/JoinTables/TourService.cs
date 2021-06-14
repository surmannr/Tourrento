using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.DAL.Models.JoinTables
{
    public class TourService
    {
        public Tour Tour { get; set; }
        public int TourId { get; set; }

        public Service Service { get; set; }
        public int ServiceId { get; set; }
    }
}
