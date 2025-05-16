namespace Cantina_2._0
{
    public partial class Form1 : Form
    {
        private List<Produto> produtos;
        private Carrinho carrinho;


        public Form1()
        {
            InitializeComponent();
            carrinho = new Carrinho();
            listBox1.DataSource = produtos;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Preco";
            listBox2.DisplayMember = "Nome";
            listBox2.ValueMember = "Preco";
            listBox1.Items.Add(new Produto { Nome = "Pão de Queijo - R$3,50", Preco = 3.50 });
            listBox1.Items.Add(new Produto { Nome = "Coxinha - R$5,00", Preco = 5 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Carne - R$6,00", Preco = 6 });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Queijo - R$5,50", Preco = 5.5 });
            listBox1.Items.Add(new Produto { Nome = "Suco Natural (300ml) - R$4,00", Preco = 4 });
            listBox1.Items.Add(new Produto { Nome = "Refrigerante Lata - R$4,50", Preco = 4.5 });
            listBox1.Items.Add(new Produto { Nome = "Hamburguer Simples - R$8,00", Preco = 8 });
            listBox1.Items.Add(new Produto { Nome = "Hamburguer com Queijo - R$9,00", Preco = 9 });
            listBox1.Items.Add(new Produto { Nome = "X-Tudo - R$12,00", Preco = 12 });
            listBox1.Items.Add(new Produto { Nome = "Água Mineral (500ml) - R$2,50", Preco = 2.5 });

            NumQuantidade.Minimum = 1;
            NumQuantidade.Maximum = 10;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Produto produto)
            {
                int quantidade = (int)NumQuantidade.Value;

                carrinho.Adicionar(produto);
                listBox2.Items.Add(produto);
                AtualizarTotal();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Produto produto)
            {
                carrinho.Remover(produto);
                listBox2.Items.Remove(produto);
                AtualizarTotal();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total do pedido: R$ {carrinho.Total():F2}", "Pedido Finalizado");
            carrinho.Limpar();
            listBox2.Items.Clear();
            AtualizarTotal();
        }
        private void AtualizarTotal()
        {
            lblTotal.Text = $"R${carrinho.Total():F2}";
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void NumQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
