using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.Shared.Dto
{
    public class User
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "A megadott email cím formátuma nem megfelelő.")]
        public string Email { get; set; }
        public string Password { get; set; }
        [Phone(ErrorMessage = "A megadott telefonszám formátuma nem megfelelő.")]
        public string PhoneNumber { get; set; }
    }
}
