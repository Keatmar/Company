using Company.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Company.SQLite
{
    public interface IEmployeeDb
    {
        /// <summary>
        /// Insert new employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<int> InsertEmployee(Employee employee);

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>
        Task<ObservableCollection<Employee>> FindEmployees();

        /// <summary>
        /// Get employee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       // Task<Employee> FindEmployeeById(int id);

        /// <summary>
        /// Update employee
        /// </summary>
        /// <param name="employee"></param>
        Task UpdateEmployee(Employee employee);

        /// <summary>
        /// Delete employee with primary key id
        /// </summary>
        /// <param name="id"></param>
        Task DeleteEmployee(int id);
    }
}
