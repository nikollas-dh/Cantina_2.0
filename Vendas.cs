using System.Diagnostics.Eventing.Reader;

namespace Cantina_2._0
{
    public partial class Vendas : Form
    {
        private List<Produto> produtos;
        private Pedido carrinho;

        public Vendas()
        {
            InitializeComponent();

            carrinho = new Pedido();

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
            if (listBox2.Items.Count <= 0)
            {
                MessageBox.Show("Escolha os itens no cardápio:");
                return;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Insira o nome:");
                return;
            }

            if (cmbViagem.SelectedItem == null)
            {
                MessageBox.Show("Selecione o SIM ou NÃO para o status da viagem! ");
                return;
            }


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
                    listBox2.Items.Add("*Para Viagem*");
                }
            }
            else if (comboBoxPagamento.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }

            comboBoxPagamento.SelectedIndex = -1;
            cmbViagem.SelectedIndex = -1;

            string extrato = "";
            foreach (var item in listBox2.Items)
            {
                extrato += item.ToString() + "\n";
            }

            MessageBox.Show($"{txtNome.Text}Itens:\n\n{extrato}\nTotal do pedido: R$ {carrinho.Total():F2}", "Extrato");

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

        private void comboBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool dinheiro = comboBoxPagamento.SelectedItem?.ToString() == "Dinheiro";
            txtValorPago.Visible = dinheiro;
            lblValor.Visible = dinheiro;
            lblTroco.Visible = dinheiro;
            txtTroco.Visible = dinheiro;

            lblTroco.Visible = dinheiro;
        }

        private void btnBalcao_Click(object sender, EventArgs e)
        {
            Balcão minhaNovaJanela = new Balcão(); // Criando uma instância da janela Balcao
            minhaNovaJanela.Show(); // Exibindo a nova janela sem bloquear a princip
        }
    }
}
