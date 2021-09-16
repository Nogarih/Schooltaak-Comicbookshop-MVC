using Microsoft.AspNetCore.Http;
using pe1.Webshop.Domain;
using pe1.Webshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class ProductsCreateVM
    {
        private Product product;


        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Serie { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public IEnumerable<int> InfoIds { get; set; }





        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Serie> Series { get; set; }
        public IEnumerable<Info> Infos { get; set; }



    }
}
