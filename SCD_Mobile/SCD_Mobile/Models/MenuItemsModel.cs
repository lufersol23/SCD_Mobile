using System;
using System.Collections.ObjectModel;
namespace SCD_Mobile.Models
{
    public class MenuItemsModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string IconPath { set; get; }

        public MenuItemsModel()
        {
        }

        public ObservableCollection<MenuItemsModel> getMenuItems()
        {
            ObservableCollection<MenuItemsModel> lstMenuItems = new ObservableCollection<MenuItemsModel>(new[]{

                new MenuItemsModel {Id=1, Name="",IconPath=""},
                new MenuItemsModel {Id=2, Name="",IconPath=""},
                new MenuItemsModel {Id=3, Name="",IconPath=""},
                new MenuItemsModel {Id=4, Name="",IconPath=""},
                new MenuItemsModel {Id=5, Name="",IconPath=""},
                new MenuItemsModel {Id=6, Name="",IconPath=""},
                new MenuItemsModel {Id=7, Name="",IconPath=""},
                new MenuItemsModel {Id=8, Name="",IconPath=""}
            });

            return lstMenuItems;
        }
    }
}
