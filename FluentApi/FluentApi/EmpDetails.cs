using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    public class EmpDetails : IEmpDetails
    {
        public List<Employee> Employees { get; set; }

        public IEmpDetails LoadEmployees()
        {
            Employees = new List<Employee>() {  new Employee { ID = 1, Name = "John Doe", age = 25, Location = "Toronto" },
                                                new Employee { ID = 2, Name = "Jane Doe", age = 30, Location = "Toronto" },
                                                new Employee { ID = 3, Name = "Jana Doe", age = 35, Location = "Montreal" },
                                                new Employee { ID = 4, Name = "Mike Doe", age = 40, Location = "Montreal" },
                                                new Employee { ID = 5, Name = "Sam Doe", age = 45, Location = "Toronto" }
            };
            return this;
        }

        public IEmpDetails FilterByLocation(string location)
        {
            Employees = Employees.Where(s => s.Location == location).ToList();
            return this;
        }
        public IEmpDetails FilterByAge(int age)
        {
            Employees = Employees.Where(s => s.age <= age).ToList();
            return this;
        }

        public List<Employee> GetData()
        {
            return Employees;
        }

    }
}
