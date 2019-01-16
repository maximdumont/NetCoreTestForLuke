using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    public class FizzBuzzController : Controller
    {
        public FizzBuzzController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}