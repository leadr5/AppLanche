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
    public partial class ViewProduto : ContentPage
    {
        public ViewProduto()
        {
            InitializeComponent();

            txtID.Text = InitialPage.Pid.ToString();
            imgLanche.Source = InitialPage.PimgProduto;
            txtProduto.Text = InitialPage.Pproduto;
            txtDescricao.Text = InitialPage.PdescricaoProduto;
            txtPreco.Text = "R$ " + InitialPage.PprecoProduto;
        }

        private void voltar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}