﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CoolBreeze
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            this.BindingContext = App.ViewModel;
            if (App.ViewModel.NeedsRefresh) App.ViewModel.RefreshCurrentConditionsAsync();
            base.OnAppearing();
        }

        
    }
}