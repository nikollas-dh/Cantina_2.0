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
    public partial class Balcão : Form
    {

        private List<Pedido> pedidos;

        public Balcão()
        {
            InitializeComponent();
           
           listBox1.Items.Add(new PedidosBalcao);

        }

        private void btnEntregue_Click(object sender, EventArgs e)
        {

        }

        
    }
}
