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

        /// <summary>
        /// if employee selected navigate to detail page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var employee = e.SelectedItem as Employee;
            await Navigation.PushAsync(new Details(employee));
            listView.SelectedItem = null;
        }

        ///// <summary>
        ///// if employee tapped navigate to detail page
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    if (e.SelectedItem == null)
        //        return;
        //    var employee = e.Item as Employee;
        //    await Navigation.PushAsync(new Details(employee));
        //    listView.SelectedItem = null;
        //}

        /// <summary>
        /// if scroll to refresh, refresh the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Handle_ListRefreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = new EmployeeBL().GetEmployees();
            listView.EndRefresh();
        }
    }
}