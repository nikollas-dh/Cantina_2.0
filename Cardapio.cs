using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cantina_2._0;

namespace Cantina_2._0
{
    public partial class Cardapio : Form
    {
        private List<Produto> cardapio;

        public Cardapio()
        {
            InitializeComponent();
            cardapio = GestaoCardapio.cardapio;
            AtualizarListBox();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Por favor, informe o nome do produto:");
                return;
            }

            double preco;
            if (double.TryParse(txtPreco.Text, out preco))
            {
                if (preco <= 0)
                {
                    MessageBox.Show("O preço deve ser maior que zero.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Digite um preço válido!");
                return;
            }
            if (cmbCozinha.SelectedItem == null)
            {
                MessageBox.Show("Selecione se o produto precisa ser preparado na cozinha.");
                return;
            }

            bool precisaPreparar = cmbCozinha.SelectedItem.ToString() == "SIM";
            Produto novoProduto = new Produto

            {
                Nome = txtNome.Text,
                Preco = preco,
                Quantidade = 0,
                PrecisaPreparar = precisaPreparar
            };

            GestaoCardapio.AdicionarProduto(novoProduto);
            AtualizarListBox();

            txtNome.Clear();
            txtPreco.Clear();
            cmbCozinha.SelectedIndex = -1;


        }
        private void AtualizarListBox()
        {
            listBox1.Items.Clear();
            foreach (var produto in cardapio)
            {
                listBox1.Items.Add(produto);
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            VendasForm telaVendas = new VendasForm(cardapio);
            telaVendas.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            Produto selecionado = (Produto)listBox1.SelectedItem;
            GestaoCardapio.RemoverProduto(selecionado);
            AtualizarListBox();
        }

        private void btnBalcao_Click(object sender, EventArgs e)
        {
            Balcao novaJanela = new Balcao();
            novaJanela.Show();
        }

        private void btnChamada_Click(object sender, EventArgs e)
        {
            Chamada novaJanela = new Chamada();
            novaJanela.Show();
        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            Cozinha novaJanela = new Cozinha();
            novaJanela.Show();
        }
    }
}
