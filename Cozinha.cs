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
            if (listBox1.SelectedItems != null)
            {

                listBox1.Items.Remove(listBox1.SelectedItem);
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

                string linha = $"Cliente: {pedido.NomeCliente} | Produtos: {string.Join(", ", itensParaCozinha)}";
                listBox1.Items.Add(linha);
            }
        }
    }
}
