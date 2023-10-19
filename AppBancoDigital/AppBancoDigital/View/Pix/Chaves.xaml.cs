using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Chaves : ContentPage
    {
        public Chaves()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           
        }

    

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conta());

        }

        private void REGISTRAR_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}