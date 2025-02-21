using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Dto
{
    public class ClientesDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("NOME")]
        public string? Nome { get; set; }
        [DisplayName("CNPJ/CPF")]
        public string? CnpjCpf { get; set; }
        [DisplayName("INSC. ESTADUAL")]
        public string? InscricaoEstadual { get; set; }
        [DisplayName("CEP")]
        public string? Cep { get; set; }
        [DisplayName("LOGRADOURO")]
        public string? Logradouro { get; set; }
        [DisplayName("BAIRRO")]
        public string? Bairro { get; set; }
        [DisplayName("NÚMERO")]
        public int Numero { get; set; }
        [DisplayName("ESTADO")]
        public string? Estado { get; set; }
        [DisplayName("TELEFONE")]
        public string? Telefone { get; set; }
        [DisplayName("WHATSSAP")]
        public string? Whatssap { get; set; }
        [DisplayName("E-MAIL")]
        public string? Email { get; set; }
        [DisplayName("CIDADE")]
        public string? Cidade { get; set; }
    }
}
