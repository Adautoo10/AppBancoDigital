﻿using AppBancoDigital.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital
{
    public partial class App : Application
    {

        public static string nome;
        public static Model.Correntista DadosCorrentista { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.PáginaInicial());

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new AdicionarConta();
            else
                MainPage = new Login();

            MainPage = new NavigationPage(new View.Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
