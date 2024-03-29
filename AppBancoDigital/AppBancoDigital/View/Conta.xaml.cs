﻿using System;
using AppBancoDigital.Model;
using AppBancoDigital.Service;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBancoDigital.View.Pix;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conta : ContentPage
    {
        public Conta()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            lbl_nome.Text = "Seja bem-vindo(a)\n" + App.nome;

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

        private void btnolho_Clicked(object sender, EventArgs e)
        {

        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.Chaves());
        }
    }
}