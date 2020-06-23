using Company.BLL;
using Company.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Company
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditEmployee : ContentPage
    {
        private Employee _employee = null;
        public EditEmployee(Employee employee)
        {
            _employee = employee;
            InitializeComponent();
            BindingContext = employee;
        }

        void ClearFiled(object sender, EventArgs e)
        {
            Name.Text = null;
            Surname.Text = null;
            Phone.Text = null;
            Address.Text = null;
            Specialty.Text = null;
        }

        void SaveEmployee(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = _employee.Id;
                if (Name.Text == null)
                    employee.Name = _employee.Name;
                else
                    employee.Name = Name.Text;
                if (Surname.Text == null)
                    employee.Surname = _employee.Surname;
                else
                    employee.Surname = Surname.Text;
                if (Phone.Text == null)
                    employee.Phone = _employee.Phone;
                else
                    employee.Phone = Phone.Text;
                if (Address.Text == null)
                    employee.Address = _employee.Address;
                else
                    employee.Address= Address.Text;
                if (Specialty.Text == null)
                    employee.Specialty = _employee.Specialty;
                else
                    employee.Specialty = Specialty.Text;
                new EmployeeBL().SaveEmployee(employee);
                Task removeUpdatePage = Task.Run(() => Device.BeginInvokeOnMainThread(async () => await Navigation.PopAsync()));
                Task removeDetailPage = Task.Run(() => Device.BeginInvokeOnMainThread(async () => await Navigation.PopAsync()));
                Task.WaitAll(removeUpdatePage,removeDetailPage);
                Task newPage = Task.Run(() => Device.BeginInvokeOnMainThread(()=>Application.Current.MainPage = new Employees()));
            }
            catch { }
        }
    }
}