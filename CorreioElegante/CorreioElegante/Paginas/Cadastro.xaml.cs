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
    public partial class Cadastro : ContentPage
    {
        public List<string> itens = new List<string>()
        {
            "FastFoodDev2.png",
            "WineDev2.png",
            "BeerDev2.png"
        };
        public List<int> carrinho = new List<int>();
        public string mensagem;
        public Cadastro()
        {
            InitializeComponent();
            mensagem = entryMensagem.Text;
        }
        private void Cadastrar(object sender,EventArgs args)
        {
            App.Current.MainPage = new TelaCarregar(entryEmail.Text,entryMensagem.Text,carrinho);
        }
        private void img1Change(object sender,EventArgs args)
        {
            carrinho.Add(0);
            img1.BackgroundColor = Color.FromHex("#bdbdbd");
        }
        private void img2Change(object sender, EventArgs args)
        {
            carrinho.Add(1);
            img2.BackgroundColor = Color.FromHex("#bdbdbd");
        }
        private void img3Change(object sender, EventArgs args)
        {
            carrinho.Add(2);
            img3.BackgroundColor = Color.FromHex("#bdbdbd");
        }
    }
}