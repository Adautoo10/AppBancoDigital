using System;
using AppBancoDigital.Model;
using AppBancoDigital.Service;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conta : ContentPage
    {
        public Conta()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
           
        }

        private async void btn_Voltar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Login());
            }


            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }

        private void btn_sair_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Login());
        }

       
        private void Button_Clicked_Fazer_Pix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.EnviarPix());

        }

        private void Button_Clicked_Receber_Pix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.ReceberPix());
        }
    }
}