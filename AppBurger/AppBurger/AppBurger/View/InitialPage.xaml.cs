using AppBurger.API;
using AppBurger.Cell;
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
    public partial class InitialPage : ContentPage
    {
        public static int Pid;
        public static string Pproduto;
        public static string PimgProduto;
        public static string PprecoProduto;
        public static string PdescricaoProduto;

        public List<produtos> ListaProduto;
        public InitialPage()
        {
            InitializeComponent();
            //saveLogin();
            ListaProduto = new List<produtos>();

            ListViewLanches.ItemTemplate = new DataTemplate(typeof(LanchesCell));
            //ListViewLanches.VerticalOptions = LayoutOptions.FillAndExpand;
            //ListViewLanches.RowHeight = RelativeLayout;
            ListViewLanches.ItemSelected += ListViewLanches_ItemSelect;
            
        }

        //public async void saveLogin()
        //{
        //    Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
        //    //App.Current.Properties.Add("savedPropA", phoneno);
        //    await App.Current.SavePropertiesAsync();
        //}
        public async void CarregarLanches()
        {
            ListaProduto = await ApiService.ObterProdutos();
            int it = -1;
            foreach(var i in ListaProduto)
            {
                it++;
                //Console.WriteLine("Aquiiii: " + i.precoProduto);
                ListaProduto[it].precoProduto = "R$ " + i.precoProduto;
            }
            string test = ListaProduto.Where(x => x.id == 1).ToString();            
            ListViewLanches.ItemsSource = ListaProduto.ToList().OrderBy(x=>x.id);
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregarLanches();

        }

        private void ListViewLanches_ItemSelect(object sender, SelectedItemChangedEventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                var produto = (produtos)e.SelectedItem;
                Pid = produto.id;
                Pproduto = produto.produto;
                PimgProduto = produto.imgProduto;
                PprecoProduto = produto.precoProduto;
                PdescricaoProduto = produto.descricaoProduto;

                Navigation.PushAsync(new ViewProduto());

            }
            catch (Exception ex)
            {

                DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private void pesquisaLanche_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textPesquisa = pesquisaLanche.Text;;
            //ListaProduto.ToList().OrderBy(x=>x.produto)
            ListViewLanches.ItemsSource = ListaProduto.Where(x=>x.produto.ToLower().Contains(textPesquisa.ToLower())).ToList();
        }

        async private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            CarregarLanches();
            await Task.Delay(1000);
            myRefreshView.IsRefreshing = false;
        }

        private void voltar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}