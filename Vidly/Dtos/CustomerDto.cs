using System;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Min18YearIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSuscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}