using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class PedidoCompleto
    {
        public string NomeCliente { get; set; }
        public List<Cardapio> Itens { get; set; }
        public DateTime HoraPedido { get; private set; }
        //public bool ParaViagem { get; set; }

        public PedidoCompleto(string nomeCliente, List<Cardapio> itens)
        {
            NomeCliente = string.IsNullOrWhiteSpace(nomeCliente) ? "Cliente" : nomeCliente;
            Itens = new List<Cardapio>(itens);
            HoraPedido = DateTime.Now;
            // ParaViagem = paraViagem;
        }
    }
}
