using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Author
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public byte[] Photo { get; set; }

        public string? Biography { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
