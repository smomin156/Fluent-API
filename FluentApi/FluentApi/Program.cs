using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using all filter options  
            var emps = new EmpDetails().LoadEmployees().FilterByLocation("Montreal").FilterByAge(50).GetData();

            foreach (var emp in emps)
            {
                Console.WriteLine($"Employee details are {emp.ID},{emp.Name},{emp.Location},{emp.age}");
            }

            // Using one filter option  
            var empsCityOnly = new EmpDetails().LoadEmployees().FilterByLocation("Toronto").GetData();

            foreach (var emp in empsCityOnly)
            {
                Console.WriteLine($"Employee details are {emp.ID},{emp.Name},{emp.Location},{emp.age}");
            }

            Console.ReadLine();
        }
    }
}
