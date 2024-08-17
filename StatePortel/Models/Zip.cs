using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatePortel.Models
{
    public partial class Zip
    {
        [Key]
        public int ZipId { get; set; }
        [StringLength(100)]
        public string ZipCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
