using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class PedidosBalcao
    {
        private static List<Pedido> pedidos = new List<Pedido>();

        public static void  AdicionarPedido(Pedido pedido) 
        {
            pedidos.Add(pedido);
        }
        public static List<Pedido> ObterPedidos() 
        { 
        return new List<Pedido>(pedidos);
        }
        public static void LimparPedidos()
        {
        pedidos.Clear();
        }
       

    }
}
