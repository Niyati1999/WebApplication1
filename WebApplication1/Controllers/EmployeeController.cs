using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Index(int Id,string Name, string Designation)
        //{
        //    int empid = Id;
        //    string empName = Name;
        //    string empDesignation = Designation;
        //    return View();
        //}
        [HttpPost]
        public IActionResult Index(Employee e1)
        {
            //int empid = e1.Id;
            //string empName = e1.Name;
            //string empDesignation = e1.Designation;
            return View("GetEmployee",e1);
        }
        public IActionResult GetEmployee()
        {
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.Name = "Niyati";
            e1.Designation = "Manager";
            return View(e1);
        }
        [HttpGet]
        public IActionResult listedEmployees()
        {
            var list = Employee.listedEmployees();
            return View("listedEmployees",list);
        }
        public IActionResult listedEmployees1()
        {
            var list = Employee.listedEmployees();
            return View(list);
        }
        public IActionResult listedEmployees2()
        {
            var list = Employee.listedEmployees();
            return View(list);
        }

        [HttpPost]
        public IActionResult listedEmployees(int Id)
        {
            var list = Employee.listedEmployees();
            Employee result = null;
            foreach (var item in list)
            {
                if (item.Id == Id)
                {
                    result = item;
                    break;
                }
            }
            return View("SearchEmployee",result);
        }
    }
}
