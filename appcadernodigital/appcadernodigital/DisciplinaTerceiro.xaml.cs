using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appcadernodigital
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisciplinaTerceiro : ContentPage
    {
        public DisciplinaTerceiro()
        {
            InitializeComponent();

            
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.ArtesTerceiro());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
         Navigation.PushAsync(new Terceiro.BiologiaTerceiro());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.EdTerceiro());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.FilosofiaTerceiro());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.FisicaTerceiro());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.GeografiaTerceiro());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.HistoriaTerceiro());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.InglesTerceiro());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.MatematicaTerceiro());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.portuguesTerceiro());
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Quimica());
        }
    }
}