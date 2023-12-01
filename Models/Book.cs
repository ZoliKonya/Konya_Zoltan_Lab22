using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Konya_Zoltan_Lab22.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "titlul cartii este completat obiligatoriu")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "lungimea maxima pentru titlu sa fie de 150 de caractere si o lungime minima de 3 caractere")]
        public string Title { get; set; }

        [ForeignKey("AuthorID")] 
        public int? AuthorID { get; set; }

        public Author? Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publish Date")]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }

        public Publisher? Publisher { get; set; }

        public int? BorrowingID { get; set; }

        public Borrowing? Borrowing { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
