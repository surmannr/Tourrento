using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models.JoinTables;

namespace Tourrento.DAL.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        public ICollection<Rent> Rents { get; set; }
        public ICollection<ItemCart> ItemCarts { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Tour> CreatedTours { get; set; }
        public ICollection<ParticipateTour> ParticipateTours { get; set; }
    }
}
