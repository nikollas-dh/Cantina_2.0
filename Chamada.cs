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
    public partial class Chamada : Form
    {
        public Chamada()
        {
            InitializeComponent();
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (var pedido in PedidosBalcao.ObterPendentes())
            {
                listBox1.Items.Add(pedido.NomeCliente.ToString());
            }

            foreach (var pedido in PedidosBalcao.ObterEntregues())
            {
                listBox2.Items.Add(pedido.NomeCliente.ToString());
            }
        }
    }
}
