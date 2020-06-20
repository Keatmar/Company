using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Company.MenuItem
{

    public class MenuItem
    {
        private ObservableCollection<MenuItem> MenuItems { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type Target { get; set; }

        public ObservableCollection<MenuItem> GetItems()
        {
            MenuItems = new ObservableCollection<MenuItem>();
            MenuItems.Add(new MenuItem { Id = 0, Title = "List of employees", Icon = "users.gif", Target = typeof(EmployeesList) });
            MenuItems.Add(new MenuItem { Id = 1, Title = "Create new employee", Icon = "plus.gif", Target = typeof(CreateEmployee) });
            return MenuItems;
        }

    }
}
