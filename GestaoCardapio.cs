using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace Cantina_2._0
{
    public static class GestaoCardapio
    {
        public static List<Produto> cardapio = new List<Produto>()
        {
            new Produto { Nome = "Pão de Queijo", Preco = 3.50, PrecisaPreparar = false },
            new Produto { Nome = "Coxinha", Preco = 5, PrecisaPreparar = false },
            new Produto { Nome = "Esfiha", Preco = 5, PrecisaPreparar = false },
            new Produto { Nome = "Pastel de Carne", Preco = 6, PrecisaPreparar = true },
            new Produto { Nome = "Pastel de Queijo", Preco = 5.5, PrecisaPreparar = true },
            new Produto { Nome = "Suco Natural (300ml)", Preco = 4, PrecisaPreparar = false },
            new Produto { Nome = "Refrigerante Lata", Preco = 4.5, PrecisaPreparar = false },
            new Produto { Nome = "Cachorro Quente", Preco = 8, PrecisaPreparar = true },
            new Produto { Nome = "X-Burger", Preco = 9, PrecisaPreparar = true },
            new Produto { Nome = "X-Bacon", Preco = 12, PrecisaPreparar = true },
            new Produto { Nome = "X-Tudo", Preco = 15, PrecisaPreparar = true },
            new Produto { Nome = "Água Mineral (500ml)", Preco = 2.5, PrecisaPreparar = false },
            new Produto { Nome = "Mini-Pizza", Preco = 10, PrecisaPreparar = false }
        };

        public static List<Produto> Produtos => cardapio;

        public static void AdicionarProduto(Produto produto)
        {
            cardapio.Add(produto);
        }

        public static void RemoverProduto(Produto produto)
        {
            cardapio.Remove(produto);
        }
    }
}
