using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProduct()
        {
            
            Product p1 = new Product() { Id = 101, Name = "Dettol", Rate = 105 };
            return View(p1);
        }
        public IActionResult ProductList()
        {
            List<Product> list = new List<Product>();
            Product p1 = new Product() { Id = 101, Name = "Dettol", Rate = 105, ImagePath= "/Images/dettol.jpeg" };
            list.Add(p1);
            Product p2 = new Product() { Id = 102, Name = "Cinthol Lime", Rate = 110, ImagePath= "/Images/cinthollime.jpeg" };
            list.Add(p2);
            Product p3 = new Product() { Id = 103, Name = "Dove", Rate = 200, ImagePath= "/Images/Dove.jpeg" };
            list.Add(p3);
            Product p4 = new Product() { Id = 104, Name = "Pears", Rate = 400, ImagePath= "/Images/Pears.jpeg" };
            list.Add(p4);
            Product p5 = new Product() { Id = 105, Name = "Santoor", Rate = 150, ImagePath= "/Images/santoor.jpeg" };
            list.Add(p5);
            return View("ProductList",list);
        }
        public IActionResult FindProduct()
        {
            return View("FindProduct");
        }
        
    }
}
