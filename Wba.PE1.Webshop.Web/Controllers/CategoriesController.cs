using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebSockets.Internal;
using Microsoft.EntityFrameworkCore;
using pe1.Webshop.Domain;
using pe1.Webshop.Web.Data;
using pe1.Webshop.Web.ViewModels;

namespace pe1.Webshop.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly WebshopContext _context;

        public CategoriesController(WebshopContext context)
        {
            _context = context;
        }

        [Route("categories/create")]

        // GET: Categories/Create
        public IActionResult Create()
        {
            //var viewModel = new CategoriesCreateVM
            //{

            //};

            return View( new CategoriesCreateVM());
        }

        [Route("categories/create")]
        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryName")] CategoriesCreateVM createVM)
        {
            if (ModelState.IsValid)
            {
                Category createCategory = new Category
                {
                    CategoryName = createVM.CategoryName
                };

                 _context.Add(createCategory);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Category");
            }
            return View(createVM);
        }

        [Route("categories/delete/{id:int}")]
        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [Route("categories/delete/{id:int}")]
        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Category");
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
