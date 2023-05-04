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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btn_criar_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.AdicionarConta());
        }


        private async void btn_logar_Clicked_1(object sender, EventArgs e)
        {
            try
                {
                    await Navigation.PushAsync(new AdicionarConta());
                }
              
           
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }

        }
    }
}