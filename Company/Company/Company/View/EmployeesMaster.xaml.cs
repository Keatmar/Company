using Company.MenuItem;
using Company.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

            BindingContext = new MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuItem.MenuItem> MenuItems { get; set; }

            public MasterViewModel()
            {
                ObservableCollection<MenuItem.MenuItem> items = new MenuItem.MenuItem().GetItems();

                MenuItems = items;
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
    }
}