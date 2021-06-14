using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.DAL.Models.JoinTables
{
    public class ItemCart
    {
        public User User { get; set; }
        public string UserId { get; set; }

        public Item Item { get; set; }
        public int ItemId { get; set; }

        [Required(ErrorMessage = "A mennyiséget kötelező megadni!")]
        [Min(0, ErrorMessage ="A mennyiség nem lehet negatív szám.")]
        public int Quantity { get; set; }
    }
}
