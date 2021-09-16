using pe1.Webshop.Domain;
using pe1.Webshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class HomeDetailsVM
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Publisher { get; set; }
        public string Serie { get; set; }
        public string Image { get; set; }
        public IEnumerable<ProductInfo> Info { get; set; }
        public decimal Price { get; set; }

        public HomeDetailsVM(Product product)
        {
            this.Id = product.Id;
            this.ProductName = product.ProductName;
            this.Category = product.Category?.CategoryName;
            this.Publisher = product.Publisher?.Name;
            this.Serie = product.Serie?.SerieName;
            this.Image = product.Image;
            this.Info = product.ProductInfos;
            this.Price = product.Price;
        }
        public HomeDetailsVM()
        {

        }

    }
    
}
