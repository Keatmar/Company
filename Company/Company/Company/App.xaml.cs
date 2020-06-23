using Company.BLL;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Company
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            EmployeeBL.CreateEmployeeTable();   //Create table to database if not exists
            MainPage = new Employees();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
