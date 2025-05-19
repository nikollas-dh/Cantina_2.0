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
            txtTroco = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(243, 241, 238);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(81, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(214, 152);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(243, 241, 238);
            listBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(504, 146);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(207, 154);
            listBox2.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(202, 196, 183);
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(301, 146);
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
            btnRemover.Location = new Point(301, 175);
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
            btnFinalizar.Location = new Point(703, 317);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // NumQuantidade
            // 
            NumQuantidade.Location = new Point(81, 319);
            NumQuantidade.Name = "NumQuantidade";
            NumQuantidade.Size = new Size(120, 23);
            NumQuantidade.TabIndex = 5;
            NumQuantidade.ValueChanged += NumQuantidade_ValueChanged;
            // 
            // lblCardápio
            // 
            lblCardápio.AutoSize = true;
            lblCardápio.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardápio.Location = new Point(142, 113);
            lblCardápio.Name = "lblCardápio";
            lblCardápio.Size = new Size(89, 25);
            lblCardápio.TabIndex = 6;
            lblCardápio.Text = "Cardápio";
            lblCardápio.Click += label1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(562, 113);
            lbl.Name = "lbl";
            lbl.Size = new Size(86, 25);
            lbl.TabIndex = 7;
            lbl.Text = "Carrinho";
            lbl.Click += lbl_Click;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.Location = new Point(504, 330);
            total.Name = "total";
            total.Size = new Size(52, 21);
            total.TabIndex = 8;
            total.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(562, 334);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 16);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "aaaa";
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
            comboBoxPagamento.Location = new Point(301, 221);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(86, 23);
            comboBoxPagamento.TabIndex = 11;
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(301, 250);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(86, 23);
            txtValorPago.TabIndex = 12;
            // 
            // txtTroco
            // 
            txtTroco.Location = new Point(301, 279);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(86, 23);
            txtTroco.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(800, 450);
            Controls.Add(txtTroco);
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
        private TextBox txtTroco;
    }
}
