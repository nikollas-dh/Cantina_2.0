﻿namespace Cantina_2._0
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
            listBox1.Location = new Point(33, 166);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(276, 178);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.Font = new Font("Inter", 8.25F);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(623, 163);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(265, 180);
            listBox2.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(202, 196, 183);
            btnAdicionar.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(200, 366);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(109, 37);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(202, 196, 183);
            btnRemover.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnRemover.Location = new Point(623, 366);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(86, 37);
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
            btnFinalizar.Location = new Point(428, 366);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(106, 36);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // NumQuantidade
            // 
            NumQuantidade.Font = new Font("Inter", 8.25F);
            NumQuantidade.Location = new Point(33, 366);
            NumQuantidade.Name = "NumQuantidade";
            NumQuantidade.Size = new Size(137, 21);
            NumQuantidade.TabIndex = 5;
            // 
            // lblCardápio
            // 
            lblCardápio.AutoSize = true;
            lblCardápio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardápio.Location = new Point(95, 116);
            lblCardápio.Name = "lblCardápio";
            lblCardápio.Size = new Size(138, 24);
            lblCardápio.TabIndex = 6;
            lblCardápio.Text = "🍔Cardápio🍔";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(680, 116);
            lbl.Name = "lbl";
            lbl.Size = new Size(152, 27);
            lbl.TabIndex = 7;
            lbl.Text = "\U0001f6d2 Carrinho\U0001f6d2";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(758, 418);
            total.Name = "total";
            total.Size = new Size(54, 23);
            total.TabIndex = 8;
            total.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(818, 419);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 22);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "R$0,00";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(354, -49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.Font = new Font("Inter", 8.25F);
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Location = new Point(428, 246);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(106, 24);
            comboBoxPagamento.TabIndex = 11;
            comboBoxPagamento.SelectedIndexChanged += comboBoxPagamento_SelectedIndexChanged;
            // 
            // txtValorPago
            // 
            txtValorPago.Font = new Font("Inter", 8.25F);
            txtValorPago.Location = new Point(428, 286);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(106, 21);
            txtValorPago.TabIndex = 12;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            lblValor.Location = new Point(334, 286);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(42, 17);
            lblValor.TabIndex = 14;
            lblValor.Text = "Valor:";
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTroco.Location = new Point(334, 323);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(45, 17);
            lblTroco.TabIndex = 16;
            lblTroco.Text = "Troco:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Inter", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(428, 172);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(106, 21);
            txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            lblNome.Location = new Point(334, 173);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 17);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome:";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            lblPagamento.Location = new Point(330, 250);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(78, 17);
            lblPagamento.TabIndex = 19;
            lblPagamento.Text = "Pagamento:";
            // 
            // txtTroco
            // 
            txtTroco.Font = new Font("Inter", 8.25F);
            txtTroco.Location = new Point(427, 323);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(107, 21);
            txtTroco.TabIndex = 20;
            // 
            // cmbViagem
            // 
            cmbViagem.Font = new Font("Inter", 8.25F);
            cmbViagem.FormattingEnabled = true;
            cmbViagem.Items.AddRange(new object[] { "SIM", "NÃO" });
            cmbViagem.Location = new Point(428, 207);
            cmbViagem.Name = "cmbViagem";
            cmbViagem.Size = new Size(106, 24);
            cmbViagem.TabIndex = 21;
            // 
            // lblViagem
            // 
            lblViagem.AutoSize = true;
            lblViagem.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold);
            lblViagem.Location = new Point(334, 211);
            lblViagem.Name = "lblViagem";
            lblViagem.Size = new Size(57, 17);
            lblViagem.TabIndex = 22;
            lblViagem.Text = "Viagem:";
            // 
            // btnBalcao
            // 
            btnBalcao.BackColor = Color.FromArgb(202, 196, 183);
            btnBalcao.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnBalcao.Location = new Point(737, 42);
            btnBalcao.Name = "btnBalcao";
            btnBalcao.Size = new Size(95, 42);
            btnBalcao.TabIndex = 23;
            btnBalcao.Text = "Balcão";
            btnBalcao.UseVisualStyleBackColor = false;
            btnBalcao.Click += btnBalcao_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(918, 722);
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
            Name = "Vendas";
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
    }
}
