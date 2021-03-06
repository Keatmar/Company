﻿using System;
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

        /// <summary>
        /// List item for master page
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<MenuItem> GetItems()
        {
            MenuItems = new ObservableCollection<MenuItem>();
            MenuItems.Add(new MenuItem { Id = 0, Title = "List of employees", Icon = "\uf0c0", Target = typeof(EmployeesList) });
            MenuItems.Add(new MenuItem { Id = 1, Title = "Create new employee", Icon = "\uf055", Target = typeof(CreateEmployee) });
            return MenuItems;
        }

    }
}
