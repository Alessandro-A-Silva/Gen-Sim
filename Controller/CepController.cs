using Gen_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Controller
{
    public class CepController
    {
        private Cep _cep;
        public CepController()
        {
            Cep _cep = new Cep();
        }

        public async Task<Cep> GetEndereco(string cep)
        {
            return await _cep.GetEndereco(cep);
        }
    }
}
