using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(string sluglink)
        {
            Product product = DataBase.GetProduct(sluglink);
            return View();
        }
        public IActionResult List()
        {
            List<Product> products = DataBase.GetProducts();
            return View(products);
        }
    }
}
