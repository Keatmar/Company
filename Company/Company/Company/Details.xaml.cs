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
    public partial class Details : ContentPage
    {
        public Details(Employee employee)
        {

            if (employee == null)
                throw new ArgumentException();
            BindingContext = employee;
            InitializeComponent();
        }
    }
}