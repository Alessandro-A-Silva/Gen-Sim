using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Dto
{
    public class ClientesDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CnpjCpf { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Whatssap { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
    }
}
