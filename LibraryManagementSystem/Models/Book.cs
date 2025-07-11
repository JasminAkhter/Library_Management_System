using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [StringLength(13)]
        public string ISBN { get; set; }

        public int TotalCopies { get; set; }

        public int AvailableCopies { get; set; }

        public DateTime PublishedDate { get; set; }
    }
}
