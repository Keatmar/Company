using Company.BLL;
using Company.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Company
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeesMaster : ContentPage
    {
        public ListView ListView;

        public EmployeesMaster()
        {
            InitializeComponent();

            BindingContext = new EmployeesMasterViewModel();
            ListView = MenuItemsListView;
        }

        class EmployeesMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<Employee> MenuItems { get; set; }

            public EmployeesMasterViewModel()
            {
                ObservableCollection<Employee> employees = new EmployeeBL().GetEmployees();
                MenuItems = employees;
            }


            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }

        private void MenuItemsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}