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
    public partial class Employees : MasterDetailPage
    {
        public Employees()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var employee = e.SelectedItem as Employee;
            if (employee == null)
                return;

            Detail = new NavigationPage(new Details(employee));
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}