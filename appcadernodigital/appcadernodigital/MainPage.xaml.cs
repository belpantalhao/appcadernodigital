using appcadernodigital.Primeiro;
using appcadernodigital.Segundo;
using appcadernodigital.Terceiro;
using System;
using appcadernodigital;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appcadernodigital
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
            NavigationPage.SetHasNavigationBar(this, false);
        }

        //é um método que representa um evento de click do botão.
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //Essa classe e usada para fazer a navegação hierárquica entre as páginas
            //criadas,que ficam como uma "pilha",aonde você pode
            //navegar para frente e para atrás conforme desejar e o pushAsync é usada para
            //que seja enviada por push para a pilha de
            //navegação, em que ele se torna a página ativa .
            Navigation.PushAsync(new DisciplinasPrimeiro());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiciplinaSegundo());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
           Navigation.PushAsync(new DisciplinaTerceiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tecnicoprimeiro());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TecnicoSegundo());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TecnicoTerceiro());
        }
    }
}
