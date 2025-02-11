using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Model
{
    public class Pedidos
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal Total { get; set; }
        public bool Entregue { get; set; }
        public bool Cancelado { get; set; }
    }
}
