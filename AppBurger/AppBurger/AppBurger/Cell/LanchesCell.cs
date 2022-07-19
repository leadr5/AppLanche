using AppBurger.API;
using ImageCircle.Forms.Plugin.Abstractions;
using service_lanche.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBurger.Cell
{
    public class LanchesCell : ViewCell
    {
        
        public LanchesCell()
        {            
            var IDCliente = new Label
            {
                HorizontalTextAlignment = TextAlignment.End,
                HorizontalOptions = LayoutOptions.Start,
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.White
            };
            IDCliente.SetBinding(Label.TextProperty, new Binding("id"));

            var Nome = new Label
            {
                Padding = new Thickness(50, 0, 0, 0),
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Start,
                Margin = 5,
                TextColor = Color.White
            };
            Nome.SetBinding(Label.TextProperty, new Binding("produto"));

            var Preco = new Label
            {
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = 5,
                TextColor = Color.White
            };
            Preco.SetBinding(Label.TextProperty, new Binding("precoProduto"));

            var Descricao = new Label
            {
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Start,
                Margin = 5,
                TextColor = Color.White
            };
            Descricao.SetBinding(Label.TextProperty, new Binding("descricaoProduto"));


            var Image = new CircleImage
            {
                BorderColor = Color.White,
                BorderThickness = 3,
                HeightRequest = 80,
                WidthRequest = 80,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                Source = ""
            };
            //Image.SetDynamicResource(CircleImage.SourceProperty, "login.png");
            Image.SetBinding(CircleImage.SourceProperty, new Binding("imgProduto"));


            var line1 = new StackLayout
            {
                BackgroundColor = Color.FromRgb(42, 44, 46),
                Orientation = StackOrientation.Horizontal,
                Children = {
                     Image,Nome
                },
            };
            var line2 = new StackLayout
            {
                Margin = new Thickness(0, -6, 0, -1),
                BackgroundColor = Color.FromRgb(42, 44, 46),
                Orientation = StackOrientation.Horizontal,
                Children = {
                     Descricao
                },
            };
            var line3 = new StackLayout
            {           
                
                Margin = new Thickness(0, -6, 0, 5),
                BackgroundColor = Color.FromRgb(42, 44, 46),
                Orientation = StackOrientation.Horizontal,
                Children = {
                    Preco
                },
            };


            View = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    line1,line2, line3
                },
            };
        }
    }
}
