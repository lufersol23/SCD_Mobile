using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SCD_Mobile.ViewModels;

namespace SCD_Mobile.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

            BindingContext = new LoginViewModel();
        }
    }
}
