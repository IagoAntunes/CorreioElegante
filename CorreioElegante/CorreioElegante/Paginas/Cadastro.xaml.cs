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
        public int selecionados=0;
        public Cadastro()
        {
            InitializeComponent();
            btnCadastrar.IsEnabled = false;
            mensagem = entryMensagem.Text;
        }

        private void btnEnabled()
        {
            if(selecionados > 0)
            {
                btnCadastrar.IsEnabled = true;
            }
            else
            {
                btnCadastrar.IsEnabled = false;
            }
        }

        private void Cadastrar(object sender,EventArgs args)
        {
            if (string.IsNullOrEmpty(entryNome.Text))
            {
                App.Current.MainPage = new TelaCarregar(entryEmail.Text, entryMensagem.Text, carrinho,"Admirador Secreto");
            }
            else
            {
                App.Current.MainPage = new TelaCarregar(entryEmail.Text, entryMensagem.Text, carrinho, entryNome.Text);
            }
        }
        private void img1Change(object sender,EventArgs args)
        {
            if(img1.BackgroundColor == Color.FromHex("#bdbdbd"))
            {
                img1.BackgroundColor = Color.FromHex("#dcdcdc");
                carrinho.Remove(0);
                selecionados--;
                btnEnabled();
            }
            else
            {
                carrinho.Add(0);
                selecionados++;
                img1.BackgroundColor = Color.FromHex("#bdbdbd");
                btnEnabled();
            }
        }
        private void img2Change(object sender, EventArgs args)
        {
            if (img2.BackgroundColor == Color.FromHex("#bdbdbd"))
            {
                img2.BackgroundColor = Color.FromHex("#dcdcdc");
                selecionados--;
                carrinho.Remove(1);
                btnEnabled();

            }
            else
            {
                carrinho.Add(1);
                selecionados++;
                img2.BackgroundColor = Color.FromHex("#bdbdbd");
                btnEnabled();
            }
        }
        private void img3Change(object sender, EventArgs args)
        {
            if (img3.BackgroundColor == Color.FromHex("#bdbdbd"))
            {
                img3.BackgroundColor = Color.FromHex("#dcdcdc");
                carrinho.Remove(2);
                selecionados--;
                btnEnabled();

            }
            else
            {
                carrinho.Add(2);
                selecionados++;
                img3.BackgroundColor = Color.FromHex("#bdbdbd");
                btnEnabled();
            }
        }
    }
}