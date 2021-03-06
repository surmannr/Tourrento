using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.Shared.Dto
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A kategória nevének kitöltése kötelező!")]
        [StringLength(100, ErrorMessage = "A kategória maximum 100 karakter hosszú lehet.")]
        public string Name { get; set; }

        public int? ParentCategoryId { get; set; }

    }
}
