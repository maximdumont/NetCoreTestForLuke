using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    public class LinqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}