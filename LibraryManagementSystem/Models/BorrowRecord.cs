using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class BorrowRecord
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowId { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public bool IsReturned { get; set; }
    }
}
