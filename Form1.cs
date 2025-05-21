using System.Diagnostics.Eventing.Reader;

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

            listBox1.Items.Add(new Produto { Nome = "Pão de Queijo", Preco = 3.50, });
            listBox1.Items.Add(new Produto { Nome = "Coxinha", Preco = 5, });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Carne", Preco = 6, });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Queijo", Preco = 5.5, });
            listBox1.Items.Add(new Produto { Nome = "Suco Natural (300ml)", Preco = 4, });
            listBox1.Items.Add(new Produto { Nome = "Refrigerante Lata", Preco = 4.5, });
            listBox1.Items.Add(new Produto { Nome = "Hamburguer Simples", Preco = 8, });
            listBox1.Items.Add(new Produto { Nome = "Hamburguer com Queijo", Preco = 9, });
            listBox1.Items.Add(new Produto { Nome = "X-Bacon", Preco = 12, });
            listBox1.Items.Add(new Produto { Nome = "X-Tudo", Preco = 15, });
            listBox1.Items.Add(new Produto { Nome = "Água Mineral (500ml)", Preco = 2.5, });


            NumQuantidade.Minimum = 1;
            NumQuantidade.Maximum = 10;

            Escolha escolha = new Escolha();
            comboBoxPagamento.Items.Add(new Pagamento { FormaPagamento = "Pix" });
            comboBoxPagamento.Items.Add(new Pagamento { FormaPagamento = "Dinheiro" });
            comboBoxPagamento.Items.Add(new Pagamento { FormaPagamento = "Débito" });

            txtValorPago.Visible = false;
            lblValor.Visible = false;
            lblTroco.Visible = false;
            txtTroco.Visible = false;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Produto produtoSelecionado)
            {
                int quantidade = (int)NumQuantidade.Value;

                var novoProduto = new Produto
                {
                    Nome = produtoSelecionado.Nome,
                    Preco = produtoSelecionado.Preco * quantidade,
                    Quantidade = quantidade

                };
                carrinho.Adicionar(novoProduto);
                listBox2.Items.Add(novoProduto);
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
            if (comboBoxPagamento.SelectedItem is Pagamento pagamento)
            {
                if (pagamento.FormaPagamento == "Dinheiro")
                {
                    double valorTotal = carrinho.Total();
                    double valorPago;
                    if (double.TryParse(txtValorPago.Text, out valorPago))
                    {
                        if (valorPago >= valorTotal)
                        {
                            double troco = valorPago - valorTotal;
                            txtTroco.Text = troco.ToString("C");
                            MessageBox.Show($"Troco: {troco:C}", "Troco");
                        }
                        else
                        {
                            double falta = valorTotal - valorPago;
                            MessageBox.Show($"Valor insuficiente. Faltam {falta:C}.", "Aviso");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Digite apenas valores válidos");
                        return;
                    }
                }
                if (cmbViagem.SelectedItem == "SIM") 
                { 
                listBox2.Items.Add("Para Viagem");
                }
            }
            MessageBox.Show($"Total do pedido: R$ {carrinho.Total():F2}", "Pedido Finalizado");
            carrinho.Limpar();
            listBox2.Items.Clear();
            txtNome.Clear();
            txtTroco.Clear();
            txtValorPago.Clear();

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

        private void comboBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool dinheiro = comboBoxPagamento.SelectedItem?.ToString() == "Dinheiro";
            txtValorPago.Visible = dinheiro;
            lblValor.Visible = dinheiro;
            lblTroco.Visible = dinheiro;
            txtTroco.Visible = dinheiro;

            lblTroco.Visible = dinheiro;
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
