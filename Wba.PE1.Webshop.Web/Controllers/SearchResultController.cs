using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pe1.Webshop.Domain;
using pe1.Webshop.Domain.Entities;
using pe1.Webshop.Web.Data;
using pe1.Webshop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.Controllers
{
    public class SearchResultController : Controller
    {

        protected readonly WebshopContext _webshopDbContext;

        public SearchResultController(WebshopContext webshopContext)
        {
            _webshopDbContext = webshopContext;
        }

        [Route("SearchResult/AllMarvelComics")]
        public IActionResult AllMarvelComics()
        {
            ViewBag.Title = "All Marvel Comics: ";

            var homeIndexVM = new HomeIndexVM();
            var products = _webshopDbContext.Products
                .Include(p => p.Category)
                .Where(p => p.Serie.Id == 5)
                .ToList();

            homeIndexVM.Products =
                products.Select(product =>
                {
                    return new HomeDetailsVM(product);
                });

            return View(homeIndexVM);
        }

        [Route("SearchResult/AllAnimeFromAOT")]
        public IActionResult AllAnimeFromAOT()
        {
            ViewBag.Title = "Anime from serie Attack on Titan: ";


            var homeIndexVM = new HomeIndexVM();
            var products = _webshopDbContext.Products
                .Include(p => p.Category)
                .Where(p => p.Category.Id == 2 && p.Serie.Id == 1)
                .ToList();

            homeIndexVM.Products =
                products.Select(product =>
                {
                    return new HomeDetailsVM(product);
                });
            return View(homeIndexVM);
        }

        [Route("SearchResult/AllTakaraWithPriceHigherThan40")]
        public IActionResult AllTakaraWithPriceHigherThan40()
        {
            ViewBag.Title = "Takara with price higher than 40: ";

            var homeIndexVM = new HomeIndexVM();
            var products = _webshopDbContext.Products
                .Include(p => p.Category)
                .Where(p => p.Publisher.Id == 2 && p.Price > 40)
                .ToList();

            homeIndexVM.Products =
                products.Select(product =>
                {
                    return new HomeDetailsVM(product);
                });
            return View(homeIndexVM);


        }

        [Route("SearchResult/AllMHAWithPriceLowerThan10")]
        public IActionResult AllMHAWithPriceLowerThan10()
        {
            ViewBag.Title = "My Hero Academia with price lower than 10: ";

            var homeIndexVM = new HomeIndexVM();
            var products = _webshopDbContext.Products
                .Include(p => p.Category)
                .Where(p => p.Serie.Id == 2 && p.Price < 10)
                .ToList();

            homeIndexVM.Products =
                products.Select(product =>
                {
                    return new HomeDetailsVM(product);
                });
            return View(homeIndexVM);

        }
    }
}
