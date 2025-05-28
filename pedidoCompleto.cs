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
        public string FormaPagamento { get; set; }

        // essa é minha classe
        public PedidoCompleto(string nomeCliente, List<Cardapio> itens, string formaPagamento)
        {
            NomeCliente = string.IsNullOrWhiteSpace(nomeCliente) ? "Cliente" : nomeCliente;
            Itens = new List<Cardapio>(itens);
            HoraPedido = DateTime.Now;
            FormaPagamento = formaPagamento;
            
        }
        public override string ToString()
        {
            return $"Cliente: {NomeCliente} | Itens: {Itens.Count} | Hora: {HoraPedido:t} | Pagamento: {FormaPagamento}";
        }
    }
}
