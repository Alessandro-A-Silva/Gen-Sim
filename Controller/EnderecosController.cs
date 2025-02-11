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
        private Endrecos _endereco;
        public EnderecosController() => _endereco = new Endrecos();

        public async Task<Endrecos> GetEndereco(string cep)
        {
            return await _endereco.GetEndereco(cep);
        }
    }
}
