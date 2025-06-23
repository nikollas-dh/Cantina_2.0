namespace Cantina_2._0
{
    partial class Cardapio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cardapio));
            listBox1 = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPreco = new TextBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            cmbCozinha = new ComboBox();
            label4 = new Label();
            btnVendas = new Button();
            btnBalcao = new Button();
            btnCozinha = new Button();
            btnChamada = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(75, 212);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(423, 324);
            listBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio__1_;
            pictureBox2.Location = new Point(45, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, -128);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            label1.Location = new Point(75, 124);
            label1.Name = "label1";
            label1.Size = new Size(351, 35);
            label1.TabIndex = 22;
            label1.Text = "Gestão de itens no cardápio:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(774, 216);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(148, 27);
            txtNome.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label2.Location = new Point(546, 216);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 24;
            label2.Text = "Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label3.Location = new Point(546, 277);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 25;
            label3.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(774, 277);
            txtPreco.Margin = new Padding(3, 4, 3, 4);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(148, 27);
            txtPreco.TabIndex = 26;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(202, 196, 183);
            btnAdicionar.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(774, 567);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(146, 60);
            btnAdicionar.TabIndex = 27;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(202, 196, 183);
            btnRemover.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnRemover.Location = new Point(75, 567);
            btnRemover.Margin = new Padding(3, 4, 3, 4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(146, 60);
            btnRemover.TabIndex = 28;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // cmbCozinha
            // 
            cmbCozinha.FormattingEnabled = true;
            cmbCozinha.Items.AddRange(new object[] { "SIM", "NÃO" });
            cmbCozinha.Location = new Point(774, 423);
            cmbCozinha.Margin = new Padding(3, 4, 3, 4);
            cmbCozinha.Name = "cmbCozinha";
            cmbCozinha.Size = new Size(148, 28);
            cmbCozinha.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label4.Location = new Point(546, 423);
            label4.Name = "label4";
            label4.Size = new Size(188, 28);
            label4.TabIndex = 30;
            label4.Text = "Item para cozinha:";
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.FromArgb(202, 196, 183);
            btnVendas.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnVendas.Location = new Point(332, 16);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(94, 31);
            btnVendas.TabIndex = 31;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnBalcao
            // 
            btnBalcao.BackColor = Color.FromArgb(202, 196, 183);
            btnBalcao.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnBalcao.Location = new Point(432, 16);
            btnBalcao.Name = "btnBalcao";
            btnBalcao.Size = new Size(94, 31);
            btnBalcao.TabIndex = 34;
            btnBalcao.Text = "Balcão";
            btnBalcao.UseVisualStyleBackColor = false;
            btnBalcao.Click += btnBalcao_Click;
            // 
            // btnCozinha
            // 
            btnCozinha.BackColor = Color.FromArgb(202, 196, 183);
            btnCozinha.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnCozinha.Location = new Point(532, 16);
            btnCozinha.Name = "btnCozinha";
            btnCozinha.Size = new Size(94, 31);
            btnCozinha.TabIndex = 35;
            btnCozinha.Text = "Cozinha";
            btnCozinha.UseVisualStyleBackColor = false;
            btnCozinha.Click += btnCozinha_Click;
            // 
            // btnChamada
            // 
            btnChamada.BackColor = Color.FromArgb(202, 196, 183);
            btnChamada.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnChamada.Location = new Point(632, 16);
            btnChamada.Name = "btnChamada";
            btnChamada.Size = new Size(94, 31);
            btnChamada.TabIndex = 37;
            btnChamada.Text = "Chamada";
            btnChamada.UseVisualStyleBackColor = false;
            btnChamada.Click += btnChamada_Click;
            // 
            // Cardapio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 728);
            Controls.Add(btnChamada);
            Controls.Add(btnCozinha);
            Controls.Add(btnBalcao);
            Controls.Add(btnVendas);
            Controls.Add(label4);
            Controls.Add(cmbCozinha);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPreco);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cardapio";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private TextBox txtPreco;
        private Button btnAdicionar;
        private Button btnRemover;
        private ComboBox cmbCozinha;
        private Label label4;
        private Button btnVendas;
        private Button btnBalcao;
        private Button btnCozinha;
        private Button btnChamada;
    }
}