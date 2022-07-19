using AppBurger.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBurger
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
#if DEBUG
            HotReloader.Current.Run(this);
#endif

            MainPage = new NavigationPage( new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
