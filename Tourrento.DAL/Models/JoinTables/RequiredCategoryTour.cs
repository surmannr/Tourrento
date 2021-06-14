using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.DAL.Models.JoinTables
{
    public class RequiredCategoryTour
    {
        public Tour Tour { get; set; }
        public int TourId { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
