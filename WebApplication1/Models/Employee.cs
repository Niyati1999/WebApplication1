using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Sex { get; set; }
        public static List<Employee> listedEmployees()
        {
            List<Employee> list = new List<Employee>();
            Employee e1 = new Employee { Id = 1, Name = "Ramesh", Designation="Executive Manager", Sex="Male" };
            list.Add(e1);
            Employee e2 = new Employee { Id = 2, Name = "Stephen", Designation = "Manager", Sex="Male" };
            list.Add(e2);
            Employee e3 = new Employee { Id = 3, Name = "Caroline", Designation = "HR", Sex="Female" };
            list.Add(e3);
            return list;
        }
    }
}
