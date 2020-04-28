﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using shellLogin01.Services;
using shellLogin01.Views;

namespace shellLogin01
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            var isLoogged = Xamarin.Essentials.SecureStorage.GetAsync("isLogged").Result;
            if (isLoogged == "2")
            {
                MainPage = new AppShell();
            }
            else
            {
                MainPage = new LoginPage();
            }

            //MainPage = new AppShell();
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
