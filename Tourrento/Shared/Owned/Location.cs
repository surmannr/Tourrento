using DataAnnotationsExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.Shared.Owned
{
    [Owned]
    public class Location
    {
        [Required(ErrorMessage = "Az utca kitöltése kötelező!")]
        [StringLength(150, ErrorMessage = "Az utca nem lehet több 150 karakternél.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "A város kitöltése kötelező!")]
        [StringLength(150, ErrorMessage = "A város nem lehet több 150 karakternél.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Az írányítószám kitöltése kötelező!")]
        [Min(0, ErrorMessage = "Az írányítószám nem lehet negatív.")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Az ország kitöltése kötelező!")]
        [StringLength(150, ErrorMessage = "Az ország nem lehet több 150 karakternél.")]
        public string Country { get; set; }
    }
}
