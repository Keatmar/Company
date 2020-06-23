using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Company.BLL;
using Company.Model;
using System.Collections.ObjectModel;
using Company.ViewModel;

namespace Company
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeesList : ContentPage
    {
        private EmployeesListViewModel ViewModel { get; set; }
        public EmployeesList()
        {
            InitializeComponent();
            ViewModel = new EmployeesListViewModel();
            BindingContext = ViewModel;
        }

        /// <summary>
        /// handle item selected from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            var employee = e.Item as Employee;
            await Navigation.PushAsync(new DetailEmployee(employee));
        }

        /// <summary>
        /// Remove selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        /// <summary>
        /// Refresh list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Handle_ListRefreshing(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Employees();
        }

    }

}