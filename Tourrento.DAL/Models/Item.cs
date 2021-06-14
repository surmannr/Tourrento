using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.DAL.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A felszerelés nevének kitöltése kötelező!")]
        [StringLength(100, ErrorMessage = "A felszerelés neve maximum 100 karakter hosszú lehet.")]
        public string Name { get; set; }

        [StringLength(3000, ErrorMessage = "A felszerelés leírása maximum 3000 karakter hosszú lehet.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A felszerelés árát kötelező megadni!")]
        [Min(0, ErrorMessage = "A felszerelés ára nem lehet negatív szám.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "A felszerelés késedelmi díját kötelező megadni!")]
        [Min(0, ErrorMessage = "A felszerelés késedelmi díja nem lehet negatív szám.")]
        public int FeePerDay { get; set; }

        [Required(ErrorMessage = "A felszerelés készletét kötelező megadni!")]
        [Min(0, ErrorMessage = "A felszerelés készlete nem lehet negatív szám.")]
        public int InStock { get; set; }
    }
}
