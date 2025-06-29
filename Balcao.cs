﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_2._0
{
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();


        }

        private void btnEntregue_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string textoSelecionado = listBox1.SelectedItem.ToString();
                var pedidoParaEntregar = PedidosBalcao.ObterPendentes()

                .FirstOrDefault(p => p.ToString() == textoSelecionado);




                if (pedidoParaEntregar != null)
                {
                    PedidosBalcao.MarcarComoEntregue(pedidoParaEntregar);

                    listBox1.Items.Remove(textoSelecionado);
                    listBox2.Items.Add(textoSelecionado + " | ENTREGUE");
                }

                if (listBox2.Items.Count > 5)
                {
                    listBox2.Items.RemoveAt(0);
                }
            }
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (var pedido in PedidosBalcao.ObterPendentes())
            {
                listBox1.Items.Add(pedido.ToString());
            }

            foreach (var pedido in PedidosBalcao.ObterEntregues())
            {
                listBox2.Items.Add(pedido.ToString() + " | ENTREGUE");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            VendasForm telaVendas = new VendasForm(GestaoCardapio.Produtos);
            telaVendas.Show();
        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            Cozinha novaJanela = new Cozinha();
            novaJanela.Show();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            Cardapio novaJanela = new Cardapio();
            novaJanela.Show();
        }
    }
}
