using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Employee
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public Salary EmployeeSalary { set; get; }
    
    }
}
