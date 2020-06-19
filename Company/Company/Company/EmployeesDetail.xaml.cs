using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Company.BLL;
using Company.Model;

namespace Company
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeesDetail : ContentPage
    {
        public EmployeesDetail()
        {
            InitializeComponent();
            listView.ItemsSource = new EmployeeBL().GetEmployees();
        }
    }
}