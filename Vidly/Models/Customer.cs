using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required()]
        [MaxLength(255)]
        public string Name { get; set; }


        [Display(Name = "Date of Birth")]
        [Min18YearIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSuscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public MembershipType MembershipType { get; set; }
    }
}