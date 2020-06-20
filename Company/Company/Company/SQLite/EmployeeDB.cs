using Company.Model;
using Company.Persistance;
using SQLite;
using System;
using System.Collections.Generic;
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

        async public void InsertEmployee(Employee employee)
        {
            try
            {
                await _con.InsertAsync(employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async public Task<List<Employee>> FindEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                CreateTable();
                employees = await _con.Table<Employee>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employees;
        }
    }
}
