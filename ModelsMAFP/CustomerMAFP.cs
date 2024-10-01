﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsMAFP.Shared;

namespace ModelsMAFP
{
    public class CustomerMAFP: BaseEntityMAFP
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string PasswordHash { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(25)]
        public string PostalCode { get; set; }
        [MaxLength(25)]
        public string Country { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
   
        public ICollection<OrderMAFP> Orders { get; set; }
    }
}
