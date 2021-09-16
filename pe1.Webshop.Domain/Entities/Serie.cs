using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace pe1.Webshop.Domain
{
    public class Serie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string SerieName { get; set; }

    }
}
