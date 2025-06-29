﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_2._0
{
    internal class PedidosBalcao
    {
        private static List<Pedido> pedidosPendentes = new List<Pedido>();
        private static List<Pedido> pedidosEntregues = new List<Pedido>();
       
        private static List<Pedido> pedidosCozinha = new List<Pedido>();


        public static void AdicionarPedido(Pedido pedido)
        {
            if (pedido.Itens.Any(p => p.PrecisaPreparar))
            {
                pedidosCozinha.Add(pedido);
            }
            else
            {
                pedidosPendentes.Add(pedido);
            }
        }
        public static List<Pedido> ObterPedidosCozinha()
        {
            return pedidosCozinha;
        }


        public static List<Pedido> ObterPendentes()
        {
            return pedidosPendentes;
        }

        public static List<Pedido> ObterEntregues()
        {
            return pedidosEntregues;
        }
        public static void RemoverPedidoCozinha(Pedido pedido)
        { 
        if (pedidosCozinha.Remove(pedido))
            {
                pedidosPendentes.Add(pedido);
            }
        }

        public static void MarcarComoEntregue(Pedido pedido)
        {
            if (pedidosPendentes.Remove(pedido))
            {
                pedidosEntregues.Add(pedido);
            }
        }
       



    }
}
