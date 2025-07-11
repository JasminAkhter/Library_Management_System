using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [StringLength(15)]
        public string? Phone { get; set; }

        public DateTime MembershipDate { get; set; }

        public DateTime? DoB { get; set; }

        public string? Gender { get; set; }

        public string? IsPaidMember { get; set; }

        public string? Address { get; set; }

        public string? Photo { get; set; }

        public ICollection<BorrowRecord> BorrowRecords { get; set; }
    }
}
