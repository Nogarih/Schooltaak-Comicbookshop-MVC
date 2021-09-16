using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pe1.Webshop.Domain;
using pe1.Webshop.Domain.Entities;
using pe1.Webshop.Web.Data;
using pe1.Webshop.Web.ViewModels;

namespace pe1.Webshop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly WebshopContext _context;
        public readonly IHostingEnvironment _environment;

        public ProductsController(WebshopContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [Route("products/create")]

        // GET: Products/Create
        public IActionResult Create()
        {
            var viewModel = new ProductsCreateVM
            {

            };
            viewModel.Categories = _context.Categories.OrderBy(c => c.Id);
            viewModel.Publishers = _context.Publishers.OrderBy(p => p.Id);
            viewModel.Series = _context.Series.OrderBy(s => s.Id);
            viewModel.Infos = _context.Infos.OrderBy(i => i.Id);

            return View(viewModel);
        }

        [Route("products/create")]
        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Category,Publisher,Serie,ImageUrl,Image,InfoIds,Price")] ProductsCreateVM vm)
        {
            string guid = "";
            if (ModelState.IsValid)
            {
                if(vm.Image != null)
                {
                    guid = Guid.NewGuid().ToString();
                    string folder = "images/";
                    folder += guid + vm.Image.FileName;
                    string serverFolder = Path.Combine(_environment.WebRootPath, folder);
                    using (var newfileStream = new FileStream(serverFolder, FileMode.Create))
                    {
                        await vm.Image.CopyToAsync(newfileStream);
                    }


                    //await vm.Image.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

                }
                Product createdProduct = new Product()
                {
                    ProductName = vm.Name,
                    Category = _context.Categories.FirstOrDefault(c => c.CategoryName == vm.Category),
                    Publisher = _context.Publishers.FirstOrDefault(p => p.Name == vm.Publisher),
                    Serie = _context.Series.FirstOrDefault(s => s.SerieName == vm.Serie),
                    Image = guid + vm.Image.FileName,
                    Price = (decimal)vm.Price

                };
                _context.Add(createdProduct);
                await _context.SaveChangesAsync();


                int createdProductId = _context.Products.Max(p => p.Id);

                vm.InfoIds.ToList().ForEach(id =>
                {
                    _context.Add(new ProductInfo { InfoId = id, ProductId = createdProductId });
                });

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            vm.Categories = _context.Categories.OrderBy(c => c.Id);
            vm.Publishers = _context.Publishers.OrderBy(p => p.Id);
            vm.Series = _context.Series.OrderBy(s => s.Id);
            vm.Infos = _context.Infos.OrderBy(i => i.Id);

            return View(vm);
        }

        [Route("products/edit/{id:int}")]

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Publisher)
                .Include(p => p.Serie)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductsEditVM(product);

            viewModel.Categories = _context.Categories.Select(c => c);
            viewModel.Publishers = _context.Publishers.Select(p => p);
            viewModel.Series = _context.Series.Select(s => s);

            return View(viewModel);
        }

        [Route("products/edit/{id:int}")]
        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Category,Publisher,Serie,Price")] ProductsEditVM productVM)
        {
            if (id != productVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

                    product.ProductName = productVM.Name;
                    product.Category = _context.Categories.FirstOrDefault(c => c.CategoryName == productVM.Category);
                    product.Publisher = _context.Publishers.FirstOrDefault(p => p.Name == productVM.Publisher);
                    product.Serie = _context.Series.FirstOrDefault(s => s.SerieName == productVM.Serie);
                    product.Price = (decimal)productVM.Price;

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(productVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Home");
            }

            productVM.Categories = _context.Categories.Select(c => c);
            productVM.Publishers = _context.Publishers.Select(p => p);
            productVM.Series = _context.Series.Select(s => s);


            return View(productVM);
        }

        [Route("products/delete/{id:int}")]

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            var viewModel = new HomeDetailsVM(product);

            return View(viewModel);
        }

        [Route("products/delete/{id:int}")]
        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            Product productToDelete = await _context.Products.FindAsync(id);
            if(productToDelete != null)
            {
                DeleteImage(productToDelete);

                // Delete product
                _context.Products.Remove(productToDelete);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return NotFound($"A product with id {id} was not found!");
            }
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

        private void DeleteImage(Product product)
        {
            string deletePath = Path.Combine(_environment.WebRootPath, "images", product?.Image);
            System.IO.File.Delete(deletePath);
        }
    }
}
