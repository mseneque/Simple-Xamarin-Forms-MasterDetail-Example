using Xamarin.Forms;

namespace Simple_MasterDetail_Example
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();

            MainPage = new Simple_MasterDetail_Example.MainPage()
            {
                BarBackgroundColor = Color.DarkGray,
                BarTextColor = Color.Black
            };

            //MainPage = new NavigationPage(new Simple_MasterDetail_Example.ActivityFeedPage())
            //{
            //    BarBackgroundColor = Color.DarkGray,
            //    BarTextColor = Color.White
            //};
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
