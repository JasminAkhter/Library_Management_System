using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Penalty
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PenaltyId { get; set; }

        public int BorrowId { get; set; }
        public BorrowRecord BorrowRecord { get; set; }

        public decimal Amount { get; set; }

        public DateTime PenaltyDate { get; set; }

        public bool IsPaid { get; set; }
    }
}
