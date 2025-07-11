using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Publisher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public string? Address { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
