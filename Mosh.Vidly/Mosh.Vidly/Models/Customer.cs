using System;
using System.ComponentModel.DataAnnotations;

namespace Mosh.Vidly.Models
{
    public class Customer
    {
        [Id]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

        [Min18YearsIfMember]
        public DateTime? Birthday { get; set; }
    }
}