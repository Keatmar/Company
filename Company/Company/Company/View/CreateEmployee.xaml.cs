using Company.BLL;
using Company.Model;
using Company.SQLite;
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
    public partial class CreateEmployee : ContentPage
    {
        public CreateEmployee()
        {
            InitializeComponent();
        }

        void SaveEmployee(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                if (Name.Text == null)
                {
                    label.Text = "Required name to add employee";
                    return;
                }
                else if (Name.Text.Length < 5)
                {
                    label.Text = "Name should be at least 5 characters";
                    return;
                }
                else
                {
                    employee.Name = Name.Text;
                }

                if (Surname.Text == null)
                {
                    label.Text = "Required surname to add employee";
                    return;
                }
                else if (Surname.Text.Length < 5)
                {
                    label.Text = "Surname should be at least 5 characters";
                    return;
                }
                else
                {
                    employee.Surname = Surname.Text;
                }

                if (Phone.Text == null)
                {
                    label.Text = "Required phone to add employee";
                    return;
                }
                else if (Phone.Text.Length != 10)
                {
                    label.Text = "Phone should be 10 characters";
                    return;
                }
                else
                    employee.Phone = Phone.Text;

                if (Address.Text == null)
                {
                    label.Text = "Required address to add employee";
                    return;
                }
                else if (Address.Text.Length < 5)
                {
                    label.Text = "Address should be at least 5 characters";
                    return;
                }
                else
                {
                    employee.Address = Address.Text;
                }

                if (Specialty.Text == null)
                {
                    label.Text = "Required specialty to add employee";
                    return;
                }
                else if (Specialty.Text.Length < 5)
                {
                    label.Text = "Specialty should be at least 5 characters";
                    return;
                }
                else
                {
                    employee.Specialty = Specialty.Text;
                }
                int employeeId = new EmployeeBL().SaveEmployee(employee);
                Application.Current.MainPage = new Employees();
            }
            catch
            {
            }
        }

        void ClearFields(object sender, EventArgs e)
        {
            Name.Text = null;
            Surname.Text = null;
            Phone.Text = null;
            Address.Text = null;
            Specialty.Text = null;
            label.Text = null;
        }
    }
}