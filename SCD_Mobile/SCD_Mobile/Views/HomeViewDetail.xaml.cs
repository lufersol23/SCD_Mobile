using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SCD_Mobile.Views
{
    public partial class HomeViewDetail : ContentPage
    {
        public HomeViewDetail()
        {
            InitializeComponent();
        }

		protected override void OnAppearing()
		{
            //Set Color
            ((NavigationPage)((MasterDetailPage)App.Current.MainPage).Detail).BarBackgroundColor = Color.FromHex("2bd0fe");
            ((NavigationPage)((MasterDetailPage)App.Current.MainPage).Detail).BarTextColor = Color.FromHex("ffffff");
            NavigationPage.SetTitleIcon(this, "home_icon.png");
		}
    }
}
