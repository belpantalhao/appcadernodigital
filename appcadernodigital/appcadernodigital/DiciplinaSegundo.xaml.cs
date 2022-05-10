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
    public partial class DiciplinaSegundo : ContentPage
    {
        public DiciplinaSegundo()
        {
            InitializeComponent();

            
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.artesSegundo());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.BiologiaSegundo());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
          Navigation.PushAsync(new Segundo.EdSegundo());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.FilosofiaSegundo());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.FisicaSegundo());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.GeografiaSegundo());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.HistoriaSegundo());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.InglesSegundo());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.MatematicaSegundo());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.portuguesSegundo());
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.QuimicaSegundo());
        }

    }
}