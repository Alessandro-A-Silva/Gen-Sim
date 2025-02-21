using Gen_Sim.Dto;
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
        private Enderecos _endereco = new Enderecos();
        public async Task<EnderecosDto> ReadByCep(string cep)
        {
            var endereco = await  _endereco.ReadByCep(cep);
            return endereco == null ? null : new EnderecosDto()
            {
                cep = endereco.cep,
                logradouro = endereco.logradouro,
                bairro = endereco.bairro,
                localidade = endereco.localidade,
                estado = endereco.estado
            };
        }
    }
}
