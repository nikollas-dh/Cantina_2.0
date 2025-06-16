namespace Cantina_2._0
{
    partial class VendasForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendasForm));
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnFinalizar = new Button();
            NumQuantidade = new NumericUpDown();
            lblCardápio = new Label();
            lbl = new Label();
            total = new Label();
            lblTotal = new Label();
            pictureBox1 = new PictureBox();
            comboBoxPagamento = new ComboBox();
            txtValorPago = new TextBox();
            lblValor = new Label();
            lblTroco = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblPagamento = new Label();
            txtTroco = new TextBox();
            cmbViagem = new ComboBox();
            lblViagem = new Label();
            btnBalcao = new Button();
            btnCozinha = new Button();
            ((System.ComponentModel.ISupportInitialize)NumQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Inter", 8.25F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(33, 148);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(313, 191);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.Font = new Font("Inter", 8.25F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(722, 148);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(265, 193);
            listBox2.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(202, 196, 183);
            btnAdicionar.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(237, 398);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(109, 53);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(202, 196, 183);
            btnRemover.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnRemover.Location = new Point(722, 398);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(128, 53);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(202, 196, 183);
            btnFinalizar.FlatAppearance.BorderColor = Color.Black;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnFinalizar.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnFinalizar.Location = new Point(479, 398);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(118, 53);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // NumQuantidade
            // 
            NumQuantidade.Font = new Font("Inter", 8.25F);
            NumQuantidade.Location = new Point(33, 398);
            NumQuantidade.Name = "NumQuantidade";
            NumQuantidade.Size = new Size(142, 24);
            NumQuantidade.TabIndex = 5;
            // 
            // lblCardápio
            // 
            lblCardápio.AutoSize = true;
            lblCardápio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardápio.Location = new Point(93, 97);
            lblCardápio.Name = "lblCardápio";
            lblCardápio.Size = new Size(174, 29);
            lblCardápio.TabIndex = 6;
            lblCardápio.Text = "🍔Cardápio🍔";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(754, 97);
            lbl.Name = "lbl";
            lbl.Size = new Size(195, 35);
            lbl.TabIndex = 7;
            lbl.Text = "\U0001f6d2 Carrinho\U0001f6d2";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(862, 491);
            total.Name = "total";
            total.Size = new Size(66, 28);
            total.TabIndex = 8;
            total.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(922, 491);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 27);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "R$0,00";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(403, -74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.Font = new Font("Inter", 8.25F);
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Location = new Point(479, 234);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(118, 29);
            comboBoxPagamento.TabIndex = 11;
            comboBoxPagamento.SelectedIndexChanged += comboBoxPagamento_SelectedIndexChanged;
            // 
            // txtValorPago
            // 
            txtValorPago.Font = new Font("Inter", 8.25F);
            txtValorPago.Location = new Point(479, 297);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(118, 24);
            txtValorPago.TabIndex = 12;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            lblValor.Location = new Point(396, 301);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(53, 22);
            lblValor.TabIndex = 14;
            lblValor.Text = "Valor:";
            lblValor.Click += lblValor_Click;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTroco.Location = new Point(393, 339);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(57, 22);
            lblTroco.TabIndex = 16;
            lblTroco.Text = "Troco:";
            lblTroco.Click += lblTroco_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Inter", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(479, 148);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(118, 24);
            txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            lblNome.Location = new Point(395, 152);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(58, 22);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            lblPagamento.Location = new Point(395, 236);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(98, 22);
            lblPagamento.TabIndex = 19;
            lblPagamento.Text = "Pagamento:";
            // 
            // txtTroco
            // 
            txtTroco.Font = new Font("Inter", 8.25F);
            txtTroco.Location = new Point(479, 335);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(118, 24);
            txtTroco.TabIndex = 20;
            // 
            // cmbViagem
            // 
            cmbViagem.Font = new Font("Inter", 8.25F);
            cmbViagem.FormattingEnabled = true;
            cmbViagem.Items.AddRange(new object[] { "SIM", "NÃO" });
            cmbViagem.Location = new Point(479, 187);
            cmbViagem.Name = "cmbViagem";
            cmbViagem.Size = new Size(118, 29);
            cmbViagem.TabIndex = 21;
            // 
            // lblViagem
            // 
            lblViagem.AutoSize = true;
            lblViagem.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            lblViagem.Location = new Point(395, 194);
            lblViagem.Name = "lblViagem";
            lblViagem.Size = new Size(71, 22);
            lblViagem.TabIndex = 22;
            lblViagem.Text = "Viagem:";
            // 
            // btnBalcao
            // 
            btnBalcao.BackColor = Color.FromArgb(202, 196, 183);
            btnBalcao.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnBalcao.Location = new Point(12, 12);
            btnBalcao.Name = "btnBalcao";
            btnBalcao.Size = new Size(94, 28);
            btnBalcao.TabIndex = 23;
            btnBalcao.Text = "Balcão";
            btnBalcao.UseVisualStyleBackColor = false;
            btnBalcao.Click += btnBalcao_Click;
            // 
            // btnCozinha
            // 
            btnCozinha.BackColor = Color.FromArgb(202, 196, 183);
            btnCozinha.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnCozinha.Location = new Point(115, 12);
            btnCozinha.Name = "btnCozinha";
            btnCozinha.Size = new Size(94, 28);
            btnCozinha.TabIndex = 24;
            btnCozinha.Text = "Cozinha";
            btnCozinha.UseVisualStyleBackColor = false;
            btnCozinha.Click += btnCozinha_Click;
            // 
            // VendasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1045, 722);
            Controls.Add(btnCozinha);
            Controls.Add(btnBalcao);
            Controls.Add(lblViagem);
            Controls.Add(cmbViagem);
            Controls.Add(txtTroco);
            Controls.Add(lblPagamento);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblTroco);
            Controls.Add(lblValor);
            Controls.Add(txtValorPago);
            Controls.Add(comboBoxPagamento);
            Controls.Add(lblTotal);
            Controls.Add(total);
            Controls.Add(lbl);
            Controls.Add(lblCardápio);
            Controls.Add(NumQuantidade);
            Controls.Add(btnFinalizar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "VendasForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnFinalizar;
        private NumericUpDown NumQuantidade;
        private Label lblCardápio;
        private Label lbl;
        private Label total;
        private Label lblTotal;
        private PictureBox pictureBox1;
        private ComboBox comboBoxPagamento;
        private TextBox txtValorPago;
        private Label lblValor;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblPagamento;
        private TextBox txtTroco;
        private Label lblTroco;
        private ComboBox cmbViagem;
        private Label lblViagem;
        private Button btnBalcao;
        private Button btnCozinha;
    }
}
