using Company.BLL;
using Company.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Company.ViewModel
{
    public class EmployeesListViewModel
    {
        public ObservableCollection<Employee> EmployeeList{get;set;}

        public EmployeesListViewModel()
        {
            EmployeeList = new ObservableCollection<Employee>();
            EmployeeList = new EmployeeBL().GetEmployees();
        }

        /// <summary>
        /// if scroll to refresh, refresh the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ListRefreshing(ListView listView)
        {
            listView.EndRefresh();
        }
    }
}
