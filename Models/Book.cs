
using System.ComponentModel.DataAnnotations;

namespace Anita_Dot_Net_Assignment.Models
{
    public class Book
    {
        [Key]  // This attribute marks BookId as the primary key
        public required int BookId { get; set; }

        // Marks BookName as a required field (using required keyword)
        [MaxLength(255)]  // Optional: Limit the length of the book name
        public required string BookName { get; set; }

        // Marks AuthorName as a required field (using required keyword)
        [MaxLength(255)]  // Optional: Limit the length of the author's name
        public required string AuthorName { get; set; }

        // Marks PublishedDate as a required field (using required keyword)
        public required DateTime PublishedDate { get; set; }
    }
}