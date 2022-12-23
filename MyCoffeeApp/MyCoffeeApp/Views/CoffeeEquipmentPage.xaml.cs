﻿using MyCoffeeApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeEquipmentPage : ContentPage
    {
        public CoffeEquipmentPage()
        {
            InitializeComponent();

            BindingContext = new CoffeeEquipmentViewModel();
        }

    }
}