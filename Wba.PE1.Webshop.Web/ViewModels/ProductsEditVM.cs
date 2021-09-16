using Microsoft.AspNetCore.Http;
using pe1.Webshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class ProductsEditVM : ProductsCreateVM
    {
        public int Id { get; set; }
        public new IFormFile Image { get; set; }
        public new IEnumerable<int> InfoIds { get; set; }


        public ProductsEditVM(Product product)
        {
            this.Id = product.Id;
            this.Name = product.ProductName;
            this.Category = product.Category?.CategoryName;
            this.Publisher = product.Publisher?.Name;
            this.Serie = product.Serie?.SerieName;
            this.ImageUrl = product.Image;
            this.Price = (double)product.Price;

        }

        public ProductsEditVM()
        {

        }
    }

}
