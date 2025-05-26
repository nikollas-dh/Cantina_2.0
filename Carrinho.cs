using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class Carrinho
    {
        private List<Pedido> itens = new List<Pedido>();

        public void Adicionar(Pedido produto) => itens.Add(produto);
        public void Remover(Pedido produto) => itens.Remove(produto);

        public double Total() => itens.Sum(p => p.Preco);
        public List<Pedido> Listar() => new List<Pedido>(itens);
        public void Limpar() => itens.Clear();

        
    }
}
