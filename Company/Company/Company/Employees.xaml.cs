using Company.BLL;
using Company.Model;
using Company.Persistance;
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
    public partial class Employees : MasterDetailPage
    {
        public Employees()
        {
            InitializeComponent();

            MasterPage.ListView.ItemSelected += ListView_ItemSelected;

            // Initialize table
            EmployeeDb.CreateTable();
        }

        void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItem.MenuItem;
            if (item == null)
                return;
            if (item.Id == 0)
                Detail = new NavigationPage(new EmployeesList());
            else if (item.Id == 1)
                Detail = new NavigationPage(new CreateEmployee());
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}