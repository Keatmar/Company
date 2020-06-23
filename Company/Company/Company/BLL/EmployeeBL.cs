using Company.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using Company.Persistance;
using Xamarin.Forms;
using Company.SQLite;
using System.Threading.Tasks;

namespace Company.BLL
{
    public class EmployeeBL
    {
        public static void CreateEmployeeTable()
        {
            EmployeeDb.CreateTable();
        }
        public ObservableCollection<Employee> GetEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            try
            {
                IEmployeeDb da = new EmployeeDb();
                Task<ObservableCollection<Employee>> emplTask = Task.Run(() => da.FindEmployees());
                Task.WhenAll(emplTask);
                employees = emplTask.Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employees;
        }


        public int SaveEmployee(Employee employee)
        {
            int id = 0;
            try
            {
                IEmployeeDb da = new EmployeeDb();
                if (employee.Id == 0)
                {
                    Task<int> emplTask = Task.Run(() => da.InsertEmployee(employee));
                    Task.WaitAll(emplTask);
                    id = emplTask.Id;
                }
                else
                {
                    Task emplTask = Task.Run(() => da.UpdateEmployee(employee));
                    Task.WhenAll(emplTask);
                    id = employee.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }

        public void DeleteEmploye(int id)
        {
            try
            {
                IEmployeeDb db = new EmployeeDb();
                Task deleteTask = Task.Run(() => db.DeleteEmployee(id));
                Task.WaitAll(deleteTask);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
