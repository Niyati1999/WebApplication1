using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentList()
        {
            List<Student> list = new List<Student>();
            Student s1 = new Student() { Id = 01, Name = "Niyati", Marks = 91 };
            list.Add(s1);
            Student s2 = new Student() { Id = 02, Name = "Asha", Marks = 95 };
            list.Add(s2);
            Student s3 = new Student() { Id = 03, Name = "Nayan", Marks = 99 };
            list.Add(s3);
            return View("StudentList", list);
        }
        public IActionResult GetSubject()
        {
            List<Subject> list = new List<Subject>();
            Subject s1 = new Subject() { SubjectId = 201, SubjectName = "Mathematics" };
            list.Add(s1);
            Subject s2 = new Subject() { SubjectId = 202, SubjectName = "Chemistry" };
            list.Add(s2);
            Subject s3 = new Subject() { SubjectId = 203, SubjectName = "Biology" };
            list.Add(s3);
            Subject s4 = new Subject() { SubjectId = 204, SubjectName = "English" };
            list.Add(s4);
            Subject s5 = new Subject() { SubjectId = 205, SubjectName = "Accounts" };
            list.Add(s5);
            return View("GetSubject",list);
        }
        
    }
}
