using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models.JoinTables;

namespace Tourrento.DAL.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A szolgáltatás nevét kötelező kitölteni!")]
        [StringLength(100, ErrorMessage = "A szolgáltatás neve maximum 100 karakter hosszú lehet.")]
        public string Name { get; set; }

        public ICollection<TourService> TourServices { get; set; }
    }
}
