using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Dto
{
    public class ProdutosDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("NOME")]
        public string? Nome { get; set; }
        [DisplayName("DESCRIÇÃO")]
        public string? Descricao { get; set; }
        [DisplayName("PREÇO")]
        public decimal Preco { get; set; }
        [DisplayName("ESTOQUE")]
        public int Estoque { get; set; }

    }
}
