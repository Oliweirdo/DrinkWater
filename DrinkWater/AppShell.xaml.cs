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
       
            Routing.RegisterRoute(nameof(SetNotificationPage), typeof(SetNotificationPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
