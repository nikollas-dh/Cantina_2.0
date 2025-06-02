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
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();

        }

        private void btnEntregue_Click(object sender, EventArgs e)
        {
            string textoSelecionado = listBox1.SelectedItem.ToString();
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(textoSelecionado);
                listBox2.Items.Add($"{textoSelecionado} | Entregue");

                if (listBox2.Items.Count > 5) 
                {
                    listBox2.Items.RemoveAt(0);
                }
            }
            else 
            {
                MessageBox.Show("Selecione um Item:"); 
            }
        }

        private void Balcao_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var pedido in PedidosBalcao.ObterPedidos())
            {
                listBox1.Items.Add(pedido.ToString());
            }
        }
    }
}
