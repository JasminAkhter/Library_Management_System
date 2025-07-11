using LibraryManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.DTOs
{
    public class AuthorDto
    {
        public int AuthorId { get; set; }

        [Required, StringLength(100, ErrorMessage = "Maximum lenght is 100")]
        public string Name { get; set; }

        public byte[] Photo { get; set; }

        public string? Biography { get; set; }

        public ICollection<BookDto>? BookDtos { get; set; }
    }
}
