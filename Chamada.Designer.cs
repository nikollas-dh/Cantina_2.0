namespace Cantina_2._0
{
    partial class Chamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chamada));
            label2 = new Label();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnVendas = new Button();
            btnBalcao = new Button();
            btnCozinha = new Button();
            btnCardapio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            label2.Location = new Point(791, 111);
            label2.Name = "label2";
            label2.Size = new Size(135, 39);
            label2.TabIndex = 33;
            label2.Text = "Histórico";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Inter", 12F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 28;
            listBox2.Location = new Point(698, 193);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(315, 424);
            listBox2.TabIndex = 32;
            // 
            // listBox1
            // 
            listBox1.Enabled = false;
            listBox1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(93, 193);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(315, 424);
            listBox1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            label1.Location = new Point(174, 111);
            label1.Name = "label1";
            label1.Size = new Size(143, 39);
            label1.TabIndex = 30;
            label1.Text = "Chamada";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.raio__1_;
            pictureBox3.Location = new Point(43, 16);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, -128);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.FromArgb(202, 196, 183);
            btnVendas.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnVendas.Location = new Point(332, 16);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(94, 31);
            btnVendas.TabIndex = 34;
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
            btnBalcao.TabIndex = 35;
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
            btnCozinha.TabIndex = 36;
            btnCozinha.Text = "Cozinha";
            btnCozinha.UseVisualStyleBackColor = false;
            btnCozinha.Click += btnCozinha_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.FromArgb(202, 196, 183);
            btnCardapio.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnCardapio.Location = new Point(632, 16);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(94, 31);
            btnCardapio.TabIndex = 38;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1194, 728);
            Controls.Add(btnCardapio);
            Controls.Add(btnCozinha);
            Controls.Add(btnBalcao);
            Controls.Add(btnVendas);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Chamada";
            Text = "Chamada";
            Load += Chamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button btnVendas;
        private Button btnBalcao;
        private Button btnCozinha;
        private Button btnCardapio;
    }
}