﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Company
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Employees();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
