using System.Net.Http;
using Newtonsoft.Json;
using W4G.Extensions.Interfaces;
using W4G.Extensions.Models;

namespace W4G.Extensions.Services
{
    internal class ViaCepService : ICepService
    {
        public bool Validate(string cep)
        {
            var responseContent = GetApiResponse(cep);
            if (responseContent == null)
            {
                return false;
            }

            var endereco = JsonConvert.DeserializeObject<Endereco>(responseContent);
            return endereco != null && !responseContent.Contains("\"erro\":");
        }

        public Endereco Info(string cep)
        {
            var responseContent = GetApiResponse(cep);
            if (responseContent == null || responseContent.Contains("\"erro\":"))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<Endereco>(responseContent);
        }

        private string GetApiResponse(string cep)
        {
            var response = new HttpClient().GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}