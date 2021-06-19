using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.DAL.Models.JoinTables
{
    public class ParticipateTour
    {
        public User User { get; set; }
        public string UserId { get; set; }

        public Tour Tour { get; set; }
        public int TourId { get; set; }

        [Required(ErrorMessage = "Kötelező megadni, hogy ki lett-e fizetve vagy nem.")]
        public bool IsPaid { get; set; }

        [Required(ErrorMessage = "A túra árát kötelező megadni!")]
        [Range(0, int.MaxValue, ErrorMessage = "Az ár nem lehet negatív szám.")]
        public int Price { get; set; }
    }
}
