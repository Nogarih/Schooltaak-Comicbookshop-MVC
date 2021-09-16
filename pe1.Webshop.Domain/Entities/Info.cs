using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace pe1.Webshop.Domain.Entities
{
    public class Info
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string InfoText { get; set; }

        public IEnumerable<ProductInfo> ProductInfos { get; set; }
    }
}
