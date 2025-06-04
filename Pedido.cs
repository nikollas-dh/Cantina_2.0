using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class Pedido
    {
        public string NomeCliente { get; set; }
        public List<Produto> Itens { get; set; }
        public DateTime HoraPedido { get; private set; }
        public string FormaPagamento { get; set; }

        public Pedido(string nomeCliente, List<Produto> itens, string formaPagamento)
        {
            NomeCliente = string.IsNullOrWhiteSpace(nomeCliente) ? "Cliente" : nomeCliente;
            Itens = new List<Produto>(itens);
            HoraPedido = DateTime.Now;
            FormaPagamento = formaPagamento;
            
        }
        //public override string ToString()
        //{
        //    return $"Cliente: {NomeCliente} | Itens: {Itens.Count} | Hora: {HoraPedido:t} | Pagamento: {FormaPagamento}";
        //}

        public override string ToString()
        {
            string produtosTexto = string.Join(", ", Itens.Select(p => $"{p.Quantidade}x {p.Nome}"));
            return $"{NomeCliente} | Produtos: {produtosTexto} | Hora: {HoraPedido:t} | Quantidade de itens: {Itens.Count} ";
        }

    }
}
