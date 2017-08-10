using System;
using System.ComponentModel;

namespace SCD_Mobile.ViewModels
{
    public class HomeViewMasterViewModel : INotifyPropertyChanged
    {
        public HomeViewMasterViewModel() 
        {
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
