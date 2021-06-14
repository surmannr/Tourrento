﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.DAL.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A bejegyzéshez tartozó kérdés kitöltése kötelező!")]
        [StringLength(300, ErrorMessage = "A kérdés maximum 300 karakter hosszú lehet.")]
        public string Question { get; set; }

        [StringLength(300, ErrorMessage = "A válasz maximum 300 karakter hosszú lehet.")]
        public string Answer { get; set; }
    }
}
