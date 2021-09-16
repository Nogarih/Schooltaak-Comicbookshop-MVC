using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.Controllers
{
    public class SearchController : Controller
    {
        [Route("search/")]
        public IActionResult Index()
        {

            return View();
        }


    }
}
