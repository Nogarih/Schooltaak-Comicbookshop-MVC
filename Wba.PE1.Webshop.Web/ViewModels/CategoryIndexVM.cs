﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class CategoryIndexVM
    {
       public IEnumerable<CategoryDetailsVM> Categories { get; set; }
    }
}
