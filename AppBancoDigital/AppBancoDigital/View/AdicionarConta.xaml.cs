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
    public partial class AdicionarConta : ContentPage
    {
        public AdicionarConta()
        {

            InitializeComponent();                      
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {      
            try
            {
                Correntista co = await DataServiceCorrentista.Cadastro(new Correntista
                {
                    Nome = txt_nome.Text,
                    CPF = Convert.ToInt32(txt_cpf.Text),         
                    Senha = txt_senha.Text
                });

                string msg = $"Correntista inserido com sucesso. Código gerado: {co.Id} ";

                await DisplayAlert("Sucesso!", msg, "OK");

                await Navigation.PushAsync(new Listar());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            finally
            {
                act_carregando.IsRunning = false;
                act_carregando.IsVisible = false;
            }
        }


        private void btn_cadastrar_Clicked(object sender, EventArgs e)
        {

        }
    }
}