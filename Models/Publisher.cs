using System.ComponentModel.DataAnnotations;

namespace Konya_Zoltan_Lab22.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Display(Name = "Publisher")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
