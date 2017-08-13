using System;
using System.Collections.Generic;
using SCD_Mobile.ViewModels;
using Xamarin.Forms;

namespace SCD_Mobile.Views
{
    public partial class HomeViewMaster : ContentPage
    {
        public HomeViewMaster()
        {
            InitializeComponent();

            BindingContext = new HomeViewMasterViewModel();
        }

    }
}
