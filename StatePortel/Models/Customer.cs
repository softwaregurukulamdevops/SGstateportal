﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatePortel.Models
{
    public partial class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [StringLength(100)]
        public string CustomerName { get; set; }
        public bool? IsActive { get; set; }
    }
}
