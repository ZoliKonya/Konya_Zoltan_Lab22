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
        public string Title { get; set; }

        [ForeignKey("AuthorID")] 
        public int? AuthorID { get; set; }

        public Author? Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
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
