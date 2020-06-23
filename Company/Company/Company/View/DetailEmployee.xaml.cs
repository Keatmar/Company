using Company.BLL;
using Company.Model;
using Company.ViewModel;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Company
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailEmployee : ContentPage
    {
        private DetailEmployeeViewModel viewModel { get; set; }
        public DetailEmployee(Employee employee)
        {
            if (employee == null)
                throw new ArgumentException();
            viewModel = new DetailEmployeeViewModel(employee);
            BindingContext = viewModel.Employee;
            InitializeComponent();
        }

        private void Edit_Employee(object sender, EventArgs e)
        {
            viewModel.EditEmployee(Navigation);
        }

        private void Delete_Employee(object sender, EventArgs e)
        {
            viewModel.DeleteEmployee();
        }

    }
}