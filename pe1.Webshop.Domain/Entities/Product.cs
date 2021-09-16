using pe1.Webshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace pe1.Webshop.Domain
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string ProductName { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Publisher Publisher { get; set; }

        [Required]
        public Serie Serie { get; set; }

        [Required]
        public string Image { get; set; }
        public IEnumerable<ProductInfo> ProductInfos { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
