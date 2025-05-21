namespace Cantina_2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            ((System.ComponentModel.ISupportInitialize)NumQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(29, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(214, 167);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(547, 146);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(207, 169);
            listBox2.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(202, 196, 183);
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(168, 324);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(202, 196, 183);
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(680, 324);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
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
            btnFinalizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.Location = new Point(355, 324);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(93, 23);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // NumQuantidade
            // 
            NumQuantidade.Location = new Point(29, 324);
            NumQuantidade.Name = "NumQuantidade";
            NumQuantidade.Size = new Size(120, 23);
            NumQuantidade.TabIndex = 5;
            NumQuantidade.ValueChanged += NumQuantidade_ValueChanged;
            // 
            // lblCardápio
            // 
            lblCardápio.AutoSize = true;
            lblCardápio.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardápio.Location = new Point(62, 102);
            lblCardápio.Name = "lblCardápio";
            lblCardápio.Size = new Size(133, 25);
            lblCardápio.TabIndex = 6;
            lblCardápio.Text = "🍔Cardápio🍔";
            lblCardápio.Click += label1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(583, 102);
            lbl.Name = "lbl";
            lbl.Size = new Size(135, 25);
            lbl.TabIndex = 7;
            lbl.Text = "\U0001f6d2 Carrinho\U0001f6d2";
            lbl.Click += lbl_Click;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(631, 373);
            total.Name = "total";
            total.Size = new Size(52, 21);
            total.TabIndex = 8;
            total.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(706, 377);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(48, 16);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "R$0,00";
            lblTotal.Click += lblTotal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(288, -38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Location = new Point(356, 215);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(93, 23);
            comboBoxPagamento.TabIndex = 11;
            comboBoxPagamento.SelectedIndexChanged += comboBoxPagamento_SelectedIndexChanged;
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(354, 252);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(93, 23);
            txtValorPago.TabIndex = 12;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValor.Location = new Point(279, 255);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(38, 15);
            lblValor.TabIndex = 14;
            lblValor.Text = "Valor:";
            lblValor.Click += lblValor_Click;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTroco.Location = new Point(279, 290);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(41, 15);
            lblTroco.TabIndex = 16;
            lblTroco.Text = "Troco:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(355, 154);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(93, 23);
            txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(276, 157);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 15);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome:";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPagamento.Location = new Point(276, 218);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(73, 15);
            lblPagamento.TabIndex = 19;
            lblPagamento.Text = "Pagamento:";
            // 
            // txtTroco
            // 
            txtTroco.Location = new Point(353, 287);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(94, 23);
            txtTroco.TabIndex = 20;
            // 
            // cmbViagem
            // 
            cmbViagem.FormattingEnabled = true;
            cmbViagem.Items.AddRange(new object[] { "SIM", "NÃO" });
            cmbViagem.Location = new Point(355, 186);
            cmbViagem.Name = "cmbViagem";
            cmbViagem.Size = new Size(93, 23);
            cmbViagem.TabIndex = 21;
            // 
            // lblViagem
            // 
            lblViagem.AutoSize = true;
            lblViagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblViagem.Location = new Point(276, 189);
            lblViagem.Name = "lblViagem";
            lblViagem.Size = new Size(52, 15);
            lblViagem.TabIndex = 22;
            lblViagem.Text = "Viagem:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
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
    }
}
