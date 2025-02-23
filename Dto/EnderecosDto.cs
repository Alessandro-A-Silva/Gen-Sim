using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Dto
{
    public class EnderecosDto
    {
        [DisplayName("CEP")]
        public string? cep { get; set; }
        [DisplayName("LOGRADOURO")]
        public string? logradouro { get; set; }
        [DisplayName("BAIRRO")]
        public string? bairro { get; set; }
        [DisplayName("LOCALIDADE")]
        public string? localidade { get; set; }
        [DisplayName("ESTADO")]
        public string? estado { get; set; }
    }
}
