using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SCD_Mobile.Models;

namespace SCD_Mobile.ViewModels
{
    public class HomeViewMasterViewModel : INotifyPropertyChanged
    {
		#region Instances

        //Menu Items List
		private ObservableCollection<MenuItemsModel> _lstMenuItems = new ObservableCollection<MenuItemsModel>();

		public ObservableCollection<MenuItemsModel> lstMenuItems
		{
			get
			{
				return _lstMenuItems;
			}
			set
			{
				_lstMenuItems = value;
				OnPropertyChanged("_lstMenuItems");
			}
		}

        MenuItemsModel menuItemM = new MenuItemsModel();


        #endregion

        public HomeViewMasterViewModel() 
        {
            InitClass();
        }

        private void InitClass()
        {
            lstMenuItems = menuItemM.getMenuItems();
        }


		#region INotifyPropertyChanged Implementation
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null) // if there is any subscribers 
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
}
