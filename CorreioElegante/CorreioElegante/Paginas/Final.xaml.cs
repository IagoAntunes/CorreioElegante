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
        public Final(string email,string mensagem,List<int> carrinho,String nome)
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
            alteraNome(nome.Trim());
            TabelaItens(carrinho);
            RetornarHomeAsync();
        }
        private void alteraNome(string nome)
        {
            alteraAdmirador(char.ToUpper(nome[0]) + nome.Substring(1));
        }
        private void alteraAdmirador(string nome)
        {
            Proprietario.Text = string.Format("De: {0}",nome);
        }

        private async Task RetornarHomeAsync()
        {
            await Task.Delay(5000);
            App.Current.MainPage = new Home();
        }
        private void TabelaItens(List<int> items)
        {
            foreach(var item in items)
            {
                if(item == 0)
                {

                    boxImage.Children.Add(new Image
                    {
                        Source = "FastFoodDev2.png"
                    });

                }
                if (item == 1)
                {
                    boxImage.Children.Add(new Image
                    {
                        Source = "WineDev2.png"
                    });
                }
                if (item == 2)
                {
                    boxImage.Children.Add(new Image
                    {
                        Source = "BeerDev2.png"
                    });
                }
            }
        }
    }
}