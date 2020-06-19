using Company.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace Company.BLL
{
    public class EmployeeBL
    {
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>
            {
                new Employee{Id = 0, Name = "Marios", Surname="Katsos", Address="Smyrnis 20", Phone= "6986644593", Specialty="Software Developer"},
                new Employee{Id = 1 ,Name = "Eleni", Surname="Spyrou", Address="Smyrnis 20", Phone= "2109964695", Specialty="Hr"}
            };
        public ObservableCollection<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            Employee employee = null;
            List<Employee> employees = this.employees.Where(x => x.Id == id).ToList();
            if (employees != null && employees.Any())
                employee = employees.FirstOrDefault();
            return employee;
        }
    }
}
