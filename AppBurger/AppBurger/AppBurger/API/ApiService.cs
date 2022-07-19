using Newtonsoft.Json;
using service_lanche.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppBurger.API
{
    public static class ApiService
    {
        public const string Url = "https://service-lanche.conveyor.cloud/";
        public static async Task<List<clientes>> ObterCliente()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = Url + "api/clientes";
                string response = await client.GetStringAsync(url);
                List<clientes> cliente = JsonConvert.DeserializeObject<List<clientes>>(response);
                return cliente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<List<produtos>> ObterProdutos()
        {
            try
            {
                HttpClient produtos = new HttpClient();
                string url = Url + "api/produtos";
                string response = await produtos.GetStringAsync(url);
                List<produtos> produto = JsonConvert.DeserializeObject<List<produtos>>(response);                
                return produto;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
