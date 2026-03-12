using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public enum EmployeeRole
    {
        Manager,
        Administrator,
        Cleaner
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middle_name { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public EmployeeRole Role { get; set; }
        public bool IsActive { get; set; }
    }
}
