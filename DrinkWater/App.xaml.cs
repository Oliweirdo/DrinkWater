﻿using System;
using Xamarin.Forms;


namespace DrinkWater
{
    public partial class App : Application
    {

        public App(bool flag)
        {
            InitializeComponent();
            MainPage = new AppShell();
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
