using Gen_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Controller
{
    public class EnderecosController
    {
        private Enderecos _endereco;
        public EnderecosController(Enderecos enderecos) => _endereco = enderecos;

        public async Task<Enderecos> GetEndereco(string cep)
        {
            return await _endereco.GetEndereco(cep);
        }
    }
}
