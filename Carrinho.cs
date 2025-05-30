using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class Carrinho
    {
        private List<Produto> itens = new List<Produto>();

        public void Adicionar(Produto produto) => itens.Add(produto);
        public void Remover(Produto produto) => itens.Remove(produto);

        public double Total() => itens.Sum(p => p.Preco);
        public List<Produto> Listar() => new List<Produto>(itens);
        public void Limpar() => itens.Clear();

        
    }
}
