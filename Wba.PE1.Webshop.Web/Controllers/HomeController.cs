using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pe1.Webshop.Domain;
using pe1.Webshop.Web.Data;
using pe1.Webshop.Web.ViewModels;
using Wba.PE1.Webshop.Web.Models;

namespace Wba.PE1.Webshop.Web.Controllers
{
    public class HomeController : Controller
    {

        // Declare the repositories
        protected readonly WebshopContext _webshopDbContext;

        public HomeController(WebshopContext webshopContext)
        {
            _webshopDbContext = webshopContext;
        }

        [Route("/")]
        [Route("home/")]
        public IActionResult Index()
        {
            var viewModel = new HomeIndexVM();
            var products = _webshopDbContext.Products
                .Include( p => p.Category)
                .Include(p => p.Publisher)
                .Include(p => p.Serie)
                .ToList();

            viewModel.Products = 
                products.Select(product =>
            {
                return new HomeDetailsVM(product);
            });
            return View(viewModel);
        }

        [Route("home/details/{id:int}")]
        public IActionResult Details(int id)
        {
            var product = _webshopDbContext.Products
                .Include(p => p.Category)
                .Include(p => p.Publisher)
                .Include(p => p.Serie)
                .FirstOrDefault(p => p.Id == id);

            var productInfos = _webshopDbContext.ProductInfos
                .Include(p => p.Info)
                .Include(p => p.Product)
                .Where(pi => pi.ProductId == id);

            foreach(var pi in productInfos)
            {
                product.ProductInfos.Append(pi);
            }

            var viewModel = new HomeDetailsVM(product);

            return View(viewModel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
