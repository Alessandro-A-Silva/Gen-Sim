using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Model
{
    public class Enderecos
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string unidade { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string estado { get; set; }
        public string regiao { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }
       
        public async Task<Enderecos> ReadByCep(string cep)
        {
            var endereco = new Enderecos();
            try
            {
                using(var client = new HttpClient())
                {
                    var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                    if (response.IsSuccessStatusCode)
                    {
                        endereco = await response.Content.ReadFromJsonAsync<Enderecos>();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar por cep! " + ex.Message, "Dados de Endereço", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return endereco;
        }
    }
}
