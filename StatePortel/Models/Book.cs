﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatePortel.Models
{
    public partial class Book
    {
        [Key]
        public int BookId { get; set; }
        [StringLength(100)]
        public string BookName { get; set; }
        public bool? IsActive { get; set; }
    }
}
