﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Customer name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        // This is implicitly required as the default setting does not return a value
        // and so can not be converted to a byte
        [Required]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        // As this is a custom validation, it will not be validated client-side, only server-side
        // Unless custom jquery is written to perform the validation
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}