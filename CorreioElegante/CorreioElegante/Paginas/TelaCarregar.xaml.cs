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
    public partial class TelaCarregar : ContentPage
    {
        private string email;
        private string mensagem;
        private List<int> carrinho;
        public TelaCarregar(string email,string mensagem,List<int> carrinho)
        {
            InitializeComponent();
            this.email = email;
            this.mensagem = mensagem;
            this.carrinho = carrinho;
            ProgressBarAsync();
        }
        public async Task ProgressBarAsync()
        {
            await Bar1.ProgressTo(1, 2000, Easing.Linear);
            App.Current.MainPage = new Final(email,mensagem,carrinho);
        }
    }
}