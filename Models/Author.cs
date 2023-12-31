﻿using System.ComponentModel.DataAnnotations;

namespace Konya_Zoltan_Lab22.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }

        [Display(Name = "LastName")]
        public string? LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
