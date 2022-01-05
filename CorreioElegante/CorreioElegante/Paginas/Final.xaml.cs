using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorreioElegante.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Final : ContentPage
    {
        public Final(string email,string mensagem,List<int> carrinho)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
            //TabelaItens(carrinho);
            //RetornarHomeAsync();
        }
        private async Task RetornarHomeAsync()
        {
            await Task.Delay(5000);
            App.Current.MainPage = new Home();
        }
        private void TabelaItens(List<int> items)
        {
            imagemAqui = new StackLayout
            { 
                BackgroundColor = Color.Blue,
                Children =
                {
                    
                }
            };
            foreach(var item in items)
            {
                if(item == 0)
                {
                    new Image
                    {
                        Source = "FastFoodDev2"
                    };
                }
                if(item == 1)
                {
                    principal.Children.Add(
                        new Image
                        {
                            Source = "WineDev2"
                        }
                    );
                }
            }
            Content = principal;
        }
    }
}