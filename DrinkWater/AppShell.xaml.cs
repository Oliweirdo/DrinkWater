﻿using System;
using System.Collections.Generic;
using DrinkWater.ViewModels;
using DrinkWater.Views;
using Xamarin.Forms;

namespace DrinkWater
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SetPage), typeof(SetPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        }

    }
}
