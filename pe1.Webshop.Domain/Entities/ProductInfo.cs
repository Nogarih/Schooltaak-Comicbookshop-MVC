using System;
using System.Collections.Generic;
using System.Text;

namespace pe1.Webshop.Domain.Entities
{
    public class ProductInfo
    {
        public int ProductId { get; set; }
        public int InfoId { get; set; }
        public Product Product { get; set; }
        public Info Info { get; set; }
    }
}
