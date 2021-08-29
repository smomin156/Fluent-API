using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    public interface IEmpDetails
    {
        IEmpDetails LoadEmployees();
        IEmpDetails FilterByLocation(string location);
        IEmpDetails FilterByAge(int age);
        List<Employee> GetData();
        List<Employee> Employees { get; set; }
    }
}
