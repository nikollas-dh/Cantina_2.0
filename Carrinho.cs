using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class Carrinho
    {
        private List<Cardapio> itens = new List<Cardapio>();

        public void Adicionar(Cardapio produto) => itens.Add(produto);
        public void Remover(Cardapio produto) => itens.Remove(produto);

        public double Total() => itens.Sum(p => p.Preco);
        public List<Cardapio> Listar() => new List<Cardapio>(itens);
        public void Limpar() => itens.Clear();

        
    }
}
