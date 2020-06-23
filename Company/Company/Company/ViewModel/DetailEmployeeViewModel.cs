using Company.BLL;
using Company.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Company.ViewModel
{
    public class DetailEmployeeViewModel
    {
        public Employee Employee { get; set; }

        public DetailEmployeeViewModel(Employee employee)
        {
            Employee = employee;
        }

        public void EditEmployee(INavigation navigation)
        {
            if (Employee == null)
                return;
            Task newPage = Task.Run(() => Device.BeginInvokeOnMainThread(async () => await navigation.PushAsync(new EditEmployee(Employee))));
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        public void DeleteEmployee()
        {
            if (Employee == null)
                return;
            new EmployeeBL().DeleteEmployee(Employee.Id);

            Application.Current.MainPage = new Employees();
        }


        public void BackAction()
        {
            Application.Current.MainPage = new EmployeesList();
        }
    }
}
