using Company.Model;
using Company.Persistance;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Company.SQLite
{
    public class EmployeeDb : IEmployeeDb
    {
        private static SQLiteAsyncConnection _con;
        /// <summary>
        /// Create table to mobile if not exist
        /// </summary>
        public static void CreateTable()
        {
            _con = DependencyService.Get<ISQLiteDb>().GetConnection();
            _con.CreateTableAsync<Employee>();
        }

        /// <summary>
        /// Insert new employee to database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task<int> InsertEmployee(Employee employee)
        {
            int id = 0;
            try
            {

                int item = await _con.InsertAsync(employee);
                if (item == 0)
                    throw new Exception("Something wrong with insert employee");
                else
                    id = item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }

        /// <summary>
        /// Update employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task UpdateEmployee(Employee employee)
        {
            try
            {
                int row = await _con.UpdateAsync(employee);
                if (row == 0)
                    throw new Exception("Non row effected");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>
        async public Task<ObservableCollection<Employee>> FindEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            try
            {
                var items = await _con.Table<Employee>().ToListAsync();
                if (items != null && items.Any())
                {
                    foreach (Employee item in items)
                        employees.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employees;
        }

        /// <summary>
        /// Delete employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        async public Task DeleteEmployee(int id)
        {
            try
            {
                var row = await _con.DeleteAsync<Employee>(id);
                if (row == 0)
                    throw new Exception("Non row deleted");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
