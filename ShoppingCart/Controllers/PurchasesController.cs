﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Controllers
{
    public class PurchasesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
