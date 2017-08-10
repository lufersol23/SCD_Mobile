﻿using System;
using System.ComponentModel;
using System.Windows.Input;
using SCD_Mobile.Views;
using Xamarin.Forms;

namespace SCD_Mobile.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            InitComands();
        }

        private void Login()
        {
			App.Current.MainPage = new MasterDetailPage
			{
				Master = new HomeViewMaster(),
				Detail = new NavigationPage(new HomeViewDetail())
			};

        }


        private void InitComands()
        {

            LoginCommand = new Command(Login);

        }


        #region  Property Change

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion

    }
}
