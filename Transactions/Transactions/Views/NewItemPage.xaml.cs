using System;
using System.Collections.Generic;
using System.ComponentModel;
using Transactions.Models;
using Transactions.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transactions.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}