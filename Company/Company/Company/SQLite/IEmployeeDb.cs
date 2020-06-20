using Company.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Company.SQLite
{
    public interface IEmployeeDb
    {
        void InsertEmployee(Employee employee);
        Task<List<Employee>> FindEmployees();
    }
}
