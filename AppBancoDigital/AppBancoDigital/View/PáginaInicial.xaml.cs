using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PáginaInicial : ContentPage
    {
        public PáginaInicial()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            Logo.Source = ImageSource.FromResource("AppBancoDigital.Imagens.logo.png");
        }

        private async void btn_logar_Clicked(object sender, EventArgs e)
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
    }
}