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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(66, 159);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(371, 244);
            listBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio__1_;
            pictureBox2.Location = new Point(39, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, -96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            label1.Location = new Point(66, 93);
            label1.Name = "label1";
            label1.Size = new Size(275, 27);
            label1.TabIndex = 22;
            label1.Text = "Gestão de itens no cardápio:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(677, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label2.Location = new Point(478, 162);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 24;
            label2.Text = "Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label3.Location = new Point(478, 208);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 25;
            label3.Text = "Preço:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(677, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 26;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(202, 196, 183);
            btnAdicionar.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(677, 425);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(128, 45);
            btnAdicionar.TabIndex = 27;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(202, 196, 183);
            btnRemover.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnRemover.Location = new Point(66, 425);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(128, 45);
            btnRemover.TabIndex = 28;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SIM", "NÃO" });
            comboBox1.Location = new Point(677, 317);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label4.Location = new Point(478, 317);
            label4.Name = "label4";
            label4.Size = new Size(151, 23);
            label4.TabIndex = 30;
            label4.Text = "Item para cozinha:";
            // 
            // Cardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 546);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
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
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button btnAdicionar;
        private Button btnRemover;
        private ComboBox comboBox1;
        private Label label4;
    }
}