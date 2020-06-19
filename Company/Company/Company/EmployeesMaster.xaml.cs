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
            public ObservableCollection<EmployeesMasterMenuItem> MenuItems { get; set; }

            public EmployeesMasterViewModel()
            {
                MenuItems = new ObservableCollection<EmployeesMasterMenuItem>(new[]
                {
                    new EmployeesMasterMenuItem { Id = 0, Title = "Page 1" },
                    new EmployeesMasterMenuItem { Id = 1, Title = "Page 2" },
                    new EmployeesMasterMenuItem { Id = 2, Title = "Page 3" },
                    new EmployeesMasterMenuItem { Id = 3, Title = "Page 4" },
                    new EmployeesMasterMenuItem { Id = 4, Title = "Page 5" },
                });
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