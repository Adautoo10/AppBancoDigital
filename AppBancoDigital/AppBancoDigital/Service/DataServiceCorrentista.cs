using AppBancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {
        public static async Task<List<Correntista>> GetCorrentistasAsync()
        {
            string json = await DataService.GetDataFromService("/correntista");

            List<Correntista> arr_corretistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_corretistas;
        }


        public static async Task<Correntista> Cadastro(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/salvar");

            Correntista co = JsonConvert.DeserializeObject<Correntista>(json);

            return co;
        }
    }
}

