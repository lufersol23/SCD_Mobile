using System;
using System.Collections.ObjectModel;
namespace SCD_Mobile.Models
{
    public class MenuItemsModel
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string IconPath { set; get; }

        public MenuItemsModel()
        {
        }

        public ObservableCollection<MenuItemsModel> getMenuItems()
        {
            ObservableCollection<MenuItemsModel> lstMenuItems = new ObservableCollection<MenuItemsModel>(new[]{

                new MenuItemsModel {Id=1, Title="Inicio",IconPath="home_icon.png"},
                new MenuItemsModel {Id=2, Title="Citas",IconPath="home_icon.png"},
                new MenuItemsModel {Id=3, Title="Pacientes",IconPath="home_icon.png"},
                new MenuItemsModel {Id=4, Title="Cuentas",IconPath="home_icon.png"},
                new MenuItemsModel {Id=5, Title="Estadisticas",IconPath="home_icon.png"},
                new MenuItemsModel {Id=6, Title="Inventario",IconPath="home_icon.png"},
                new MenuItemsModel {Id=7, Title="Mantenimiento",IconPath="home_icon.png"}
            });

            return lstMenuItems;
        }
    }
}
