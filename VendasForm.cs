using System.Diagnostics.Eventing.Reader;

namespace Cantina_2._0
{
    public partial class VendasForm : Form
    {
        private List<Produto> cardapio = new List<Produto>();
        private Carrinho carrinho;

        public VendasForm(List<Produto> cardapioExterno)
        {
            InitializeComponent();


            carrinho = new Carrinho();
            cardapio = cardapioExterno;

            foreach (var item in cardapio)
            {
                listBox1.Items.Add(item);
            }



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
               
            }

            if (cmbViagem.SelectedItem == "SIM")
            {
                listBox2.Items.Add("*Para Viagem*");
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
                $"Pagamento: {formaPagamento}\n" +
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
            Balcao novaJanela = new Balcao(); 
            novaJanela.Show(); 
        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            Cozinha novaJanela = new Cozinha();
            novaJanela.Show();
        }

        private void lblTroco_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
