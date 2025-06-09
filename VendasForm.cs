using System.Diagnostics.Eventing.Reader;

namespace Cantina_2._0
{
    public partial class VendasForm : Form
    {
        private List<Produto> Itens;


        private Carrinho carrinho;

        public VendasForm()
        {
            InitializeComponent();


            carrinho = new Carrinho();

            listBox1.Items.Add(new Produto { Nome = "Pão de Queijo", Preco = 3.50, Quantidade=1, PrecisaPreparar = false });
            listBox1.Items.Add(new Produto { Nome = "Coxinha", Preco = 5, Quantidade = 1, PrecisaPreparar = false });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Carne", Preco = 6, Quantidade = 1, PrecisaPreparar = true });
            listBox1.Items.Add(new Produto { Nome = "Pastel de Queijo", Preco = 5.5, Quantidade = 1, PrecisaPreparar = true });
            listBox1.Items.Add(new Produto { Nome = "Suco Natural (300ml)", Preco = 4, Quantidade = 1, PrecisaPreparar = false });
            listBox1.Items.Add(new Produto { Nome = "Refrigerante Lata", Preco = 4.5, Quantidade = 1, PrecisaPreparar = false });
            listBox1.Items.Add(new Produto { Nome = "Cachorro Quente", Preco = 8, Quantidade = 1, PrecisaPreparar = true });
            listBox1.Items.Add(new Produto { Nome = "X-Burger", Preco = 9, Quantidade = 1, PrecisaPreparar = true });
            listBox1.Items.Add(new Produto { Nome = "X-Bacon", Preco = 12, Quantidade = 1, PrecisaPreparar = true });
            listBox1.Items.Add(new Produto { Nome = "X-Tudo", Preco = 15, Quantidade = 1, PrecisaPreparar = true });
            listBox1.Items.Add(new Produto { Nome = "Água Mineral (500ml)", Preco = 2.5, Quantidade = 1, PrecisaPreparar = false });


            NumQuantidade.Minimum = 1;
            NumQuantidade.Maximum = 10;

            comboBoxPagamento.Items.Add("Pix");
            comboBoxPagamento.Items.Add("Dinheiro");
            comboBoxPagamento.Items.Add("Débito");

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

                var novoPedido = new Produto
                {
                    Nome = produtoSelecionado.Nome,
                    Preco = produtoSelecionado.Preco * quantidade,
                    Quantidade = quantidade,
                    PrecisaPreparar = produtoSelecionado.PrecisaPreparar

                };
                carrinho.Adicionar(novoPedido);
                listBox2.Items.Add(novoPedido);
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
            if (comboBoxPagamento.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }

            string formaPagamento = comboBoxPagamento.SelectedItem.ToString();

            if (formaPagamento == "Dinheiro")
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

                if (cmbViagem.SelectedItem == "SIM")
                {
                    listBox2.Items.Add("*Para Viagem*");
                }
            }

            string extrato = "";
            foreach (var item in carrinho.Listar())
            {
                extrato += item.ToString() + "\n";
            }

            Pedido pedido = new Pedido(txtNome.Text, carrinho.Listar(), formaPagamento);

            string mensagem =
                $"{pedido.NomeCliente}\n" +
                $"Hora do pedido: {pedido.HoraPedido:dd/MM/yyyy HH:mm}\n" +
                $"Pagamento: {pedido.FormaPagamento}\n" +
                $"Itens:\n{extrato}\n" +
                $"Total do pedido: R$ {carrinho.Total():F2}";

            MessageBox.Show(mensagem, "Extrato");

            PedidosBalcao.AdicionarPedido(pedido);


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
            Balcao novaJanela = new Balcao(); // Criando uma instância da janela Balcao
            novaJanela.Show(); // Exibindo a nova janela sem bloquear a princip
        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            Cozinha novaJanela = new Cozinha(); 
            novaJanela.Show();
        }
    }
}
