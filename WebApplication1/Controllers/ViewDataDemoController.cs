using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ViewDataDemoController : Controller
    {
        [ViewData]
        public string subject { get; set; }
        public IActionResult Index()
        {
            ViewData["Name"] = "Devanshi";
            ViewData["Semester"] = 7;
            ViewData.Add("Grade", 7.1);
            subject = "Calculus";
            Address A1 = new Address() { City = "Ahmedabad", Country = "India", State = "Gujarat" };
            ViewData["Address"] = A1;
            return View(A1);
        }
    }
}
