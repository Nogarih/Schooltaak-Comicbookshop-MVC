using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class CategoriesCreateVM
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
