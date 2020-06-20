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

        async void Handler_AddEmployee(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                if (Name.Text == null)
                {
                    label.Text = "*Required name to add employee";
                    return;
                }
                else
                    employee._name = Name.Text;
                if (Surname.Text == null)
                {
                    label.Text = "*Required surname to add employee";
                    return;
                }
                else
                    employee._surname = Surname.Text;
                if (Phone.Text == null)
                {
                    label.Text = "*Required phone to add employee";
                    return;
                }
                else
                    employee._phone = Phone.Text;
                if (Address.Text == null)
                {
                    label.Text = "*Required address to add employee";
                    return;
                }
                else
                    employee._address = Address.Text;
                if (Specialty.Text == null)
                {
                    label.Text = "*Required specialty to add employee";
                    return;
                }
                else
                    employee._specialty = Specialty.Text;

                new EmployeeBL().SaveEmployee(employee);
            }
            catch
            {
            }
        }
    }
}