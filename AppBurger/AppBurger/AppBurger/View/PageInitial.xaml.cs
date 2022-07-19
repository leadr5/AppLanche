using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBurger.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageInitial : ContentPage
    {
        public PageInitial()
        {
            InitializeComponent();
            saveLogin();
        }

        public async void saveLogin()
        {
            Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
            //App.Current.Properties.Add("savedPropA", phoneno);
            await App.Current.SavePropertiesAsync();
        }

        private async void Lanches_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InitialPage());
        }

        private void Bebidas_Clicked(object sender, EventArgs e)
        {
            //
        }

        async private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            myRefreshView.IsRefreshing = false;
        }

        private void voltar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}