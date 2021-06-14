using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.DAL.Models.JoinTables
{
    public class ItemCategory
    {
        public Item Item { get; set; }
        public int ItemId { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
