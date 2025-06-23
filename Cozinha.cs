using System;
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
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string textoSelecionado = listBox1.SelectedItem.ToString();


                var pedido = PedidosBalcao.ObterPedidosCozinha()
                    .FirstOrDefault(p =>
                        $"Cliente: {p.NomeCliente} | Produtos: {string.Join(" | ", p.Itens.Where(i => i.PrecisaPreparar).Select(i => $"{i.Quantidade}x {i.Nome}"))}" == textoSelecionado);

                if (pedido != null)
                {
                    PedidosBalcao.RemoverPedidoCozinha(pedido);
                    PedidosBalcao.AdicionarPedido(pedido);

                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var pedido in PedidosBalcao.ObterPedidosCozinha())
            {
                var itensParaCozinha = pedido.Itens
                    .Where(p => p.PrecisaPreparar)
                    .Select(p => $"{p.Quantidade}x {p.Nome}");

                string linha = $"Cliente: {pedido.NomeCliente} | Produtos: {string.Join(" | ", itensParaCozinha)}";
                listBox1.Items.Add(linha);
            }
        }

        private void btnBalcao_Click(object sender, EventArgs e)
        {
            Balcao novaJanela = new Balcao();
            novaJanela.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            VendasForm telaVendas = new VendasForm(GestaoCardapio.Produtos);
            telaVendas.Show();
        }

        private void btnChamada_Click(object sender, EventArgs e)
        {
            Chamada novaJanela = new Chamada();
            novaJanela.Show();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            Cardapio novaJanela = new Cardapio();
            novaJanela.Show();
        }
    }
}
