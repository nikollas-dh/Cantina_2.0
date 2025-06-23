namespace Cantina_2._0
{
    partial class Cozinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cozinha));
            listBox1 = new ListBox();
            pictureBox2 = new PictureBox();
            lblCozinha = new Label();
            btnFinalizar = new Button();
            pictureBox1 = new PictureBox();
            btnVendas = new Button();
            btnBalcao = new Button();
            btnCardapio = new Button();
            btnChamada = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Inter Medium", 10F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(45, 187);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(818, 364);
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
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // lblCozinha
            // 
            lblCozinha.AutoSize = true;
            lblCozinha.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblCozinha.Location = new Point(45, 97);
            lblCozinha.Name = "lblCozinha";
            lblCozinha.Size = new Size(313, 39);
            lblCozinha.TabIndex = 17;
            lblCozinha.Text = "Pedidos para Cozinha:";
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(202, 196, 183);
            btnFinalizar.Font = new Font("Inter ExtraBold", 14F, FontStyle.Bold);
            btnFinalizar.Location = new Point(949, 187);
            btnFinalizar.Margin = new Padding(3, 4, 3, 4);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(170, 81);
            btnFinalizar.TabIndex = 18;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, -128);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.FromArgb(202, 196, 183);
            btnVendas.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnVendas.Location = new Point(332, 16);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(94, 31);
            btnVendas.TabIndex = 32;
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
            btnBalcao.TabIndex = 33;
            btnBalcao.Text = "Balcão";
            btnBalcao.UseVisualStyleBackColor = false;
            btnBalcao.Click += btnBalcao_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.FromArgb(202, 196, 183);
            btnCardapio.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnCardapio.Location = new Point(632, 16);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(94, 31);
            btnCardapio.TabIndex = 34;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnChamada
            // 
            btnChamada.BackColor = Color.FromArgb(202, 196, 183);
            btnChamada.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnChamada.Location = new Point(532, 16);
            btnChamada.Name = "btnChamada";
            btnChamada.Size = new Size(94, 31);
            btnChamada.TabIndex = 35;
            btnChamada.Text = "Chamada";
            btnChamada.UseVisualStyleBackColor = false;
            btnChamada.Click += btnChamada_Click;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1194, 728);
            Controls.Add(btnChamada);
            Controls.Add(btnCardapio);
            Controls.Add(btnBalcao);
            Controls.Add(btnVendas);
            Controls.Add(btnFinalizar);
            Controls.Add(lblCozinha);
            Controls.Add(pictureBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cozinha";
            Text = "Form1";
            Load += Cozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private PictureBox pictureBox2;
        private Label lblCozinha;
        private Button btnFinalizar;
        private PictureBox pictureBox1;
        private Button btnVendas;
        private Button btnBalcao;
        private Button btnCardapio;
        private Button btnChamada;
    }
}