using Company.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.BLL
{
    public class EmployeeBL
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Name = "Marios", Surname="Katsos", Address="Smyrnis 20", Phone= "6986644593", Specialty="Software Developer"},
                new Employee{Name = "Eleni", Surname="Spyrou", Address="Smyrnis 20", Phone= "2109964695", Specialty="Hr"}
            };
            return employees;
        }
    }
}
