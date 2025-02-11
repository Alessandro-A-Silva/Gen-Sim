using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Model
{
    public class PedidosDetalhes
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public int IdServico { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal PrecoTotal
        {
            get { return PrecoUnitario * Quantidade; }
        } 
            
    }
}
