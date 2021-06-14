using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.DAL.Models.JoinTables
{
    public class RequiredCategoryTour
    {
        public Tour Tour { get; set; }
        public int TourId { get; set; }

        public Category RequiredCategory { get; set; }
        public int RequiredCategoryId { get; set; }
    }
}
