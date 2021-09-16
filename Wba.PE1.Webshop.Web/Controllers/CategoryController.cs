using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pe1.Webshop.Domain;
using pe1.Webshop.Web.Data;
using pe1.Webshop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.Controllers
{
    public class CategoryController : Controller
    {

        protected readonly WebshopContext _webshopDbContext;

        public CategoryController(WebshopContext webshopContext)
        {
            _webshopDbContext = webshopContext;
        }

        [Route("category/")]
        public IActionResult Index()
        {
            ViewBag.Title = "All categories";
            var viewModel = new CategoryIndexVM();
            var categories = _webshopDbContext.Categories
                .ToList();

            viewModel.Categories =
                categories.Select(category =>
            {
                return new CategoryDetailsVM(category);
            });

            return View(viewModel);
        }

        [Route("category/details/{id:int}")]
        public IActionResult Details(int id, string name)
        {
            var viewModel = new HomeIndexVM();
            var products = _webshopDbContext.Products
                .Include(p => p.Category)
                .Where(p => p.Category.Id == id)
                .ToList();

            viewModel.Products =
                products.Select(product =>
                {
                    return new HomeDetailsVM(product);
                });

            ViewBag.Title = name;

            return View(viewModel);
        }
    }
}
