using pe1.Webshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class CategoryDetailsVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }


        public CategoryDetailsVM(Category category)
        {
            this.Id = category.Id;
            this.CategoryName = category?.CategoryName;
        }
    }
}
