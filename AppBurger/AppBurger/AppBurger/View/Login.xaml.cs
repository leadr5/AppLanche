using AppBurger.API;
using Plugin.Connectivity;
using service_lanche.Models;
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
    public partial class Login : ContentPage
    {
        List<clientes> listCliente;
        public static bool isLoggedIn;
        public Login()
        {
            InitializeComponent();
            listCliente = new List<clientes>();
            //App.Current.Properties.Clear();
            bool isLoggedIn = Application.Current.Properties.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(Application.Current.Properties["IsLoggedIn"]) : false;
            if (!isLoggedIn)
            {
                //Load if Not Logged In
            }
            else
            {
                //Load if Logged In
                jaLogado();
            }
        }

        public void clearLogin()
        {
            Xamarin.Forms.Application.Current.Properties.Clear();
        }

        public async void jaLogado()
        {
            await Navigation.PushAsync(new PageInitial());
        }
        public async void Logar()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                bool isLoggedIn = Application.Current.Properties.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(Application.Current.Properties["IsLoggedIn"]) : false;
                

                if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtSenha.Text))
                {
                    listCliente = await ApiService.ObterCliente();
                    var client = listCliente.Where(x => x.email == txtEmail.Text && x.senha == txtSenha.Text).ToList();
                    if (client.Count > 0)
                    {
                        await Navigation.PushAsync(new PageInitial());
                    }
                    else
                    {
                        await DisplayAlert("Erro!", "Usuário ou senha inválidos.", "ok");
                    }
                }
                else
                {
                    await DisplayAlert("Erro!", "Preencha todos os campos.", "ok");
                }
            }
            else
            {
                await DisplayAlert("Erro!", "Verifique sua conexão com a internet.", "ok");
            }
        }
        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Logar();
        }
    }
}