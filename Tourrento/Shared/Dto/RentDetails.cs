using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.Shared.Attributes;

namespace Tourrento.Shared.Dto
{
    public class RentDetails
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A kölcsönzés időpontját kötelező megadni!")]
        [AfterNow(ErrorMessage = "A kölcsönzés időpontja nem lehet korábban a mai dátumnál.")]
        public DateTimeOffset RentalDate { get; set; }

        [Required(ErrorMessage = "A kölcsönzés időpontjának végét kötelező megadni!")]
        [AfterNow(ErrorMessage = "A kölcsönzés vége nem lehet korábban a mai dátumnál.")]
        [AfterDate(DateName = "RentalDate", ErrorMessage = "A kölcsönzés vége nem lehet korábban a kölcsönzés kezdeténél.")]
        public DateTimeOffset UntilDate { get; set; }

        [Required(ErrorMessage = "A végösszeget kötelező megadni!")]
        [Range(0, int.MaxValue, ErrorMessage = "A végösszeg nem lehet negatív szám.")]
        public int TotalPrice { get; set; }

        [Required(ErrorMessage = "A szerződést kötelező megadni, hogy elfogadjuk-e!")]
        public bool AcceptContract { get; set; }

        public string UserId { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
