using Xamarin.Forms;
using SCD_Mobile.Views;

namespace SCD_Mobile
{
    public partial class App : Application
    {
        static public int ScreenWidth;

        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
