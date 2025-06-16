namespace Cantina_2._0
{
    partial class Balcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcao));
            listBox2 = new ListBox();
            pictureBox1 = new PictureBox();
            btnEntregue = new Button();
            lblEntregue = new Label();
            lblProntos = new Label();
            pictureBox2 = new PictureBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox2
            // 
            listBox2.Enabled = false;
            listBox2.Font = new Font("Inter", 8.25F);
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(43, 459);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(898, 214);
            listBox2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, -128);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnEntregue
            // 
            btnEntregue.BackColor = Color.FromArgb(202, 196, 183);
            btnEntregue.Font = new Font("Inter ExtraBold", 12F, FontStyle.Bold);
            btnEntregue.Location = new Point(997, 153);
            btnEntregue.Margin = new Padding(3, 4, 3, 4);
            btnEntregue.Name = "btnEntregue";
            btnEntregue.Size = new Size(166, 72);
            btnEntregue.TabIndex = 12;
            btnEntregue.Text = "Entregue";
            btnEntregue.UseVisualStyleBackColor = false;
            btnEntregue.Click += btnEntregue_Click;
            // 
            // lblEntregue
            // 
            lblEntregue.AutoSize = true;
            lblEntregue.Font = new Font("Inter SemiBold", 14F, FontStyle.Bold);
            lblEntregue.Location = new Point(43, 405);
            lblEntregue.Name = "lblEntregue";
            lblEntregue.Size = new Size(233, 35);
            lblEntregue.TabIndex = 13;
            lblEntregue.Text = "Pedidos Retirados:";
            // 
            // lblProntos
            // 
            lblProntos.AutoSize = true;
            lblProntos.Font = new Font("Inter SemiBold", 14F, FontStyle.Bold);
            lblProntos.Location = new Point(43, 92);
            lblProntos.Name = "lblProntos";
            lblProntos.Size = new Size(254, 35);
            lblProntos.TabIndex = 14;
            lblProntos.Text = "Pedidos Finalizados:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio__1_;
            pictureBox2.Location = new Point(43, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(43, 153);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(898, 224);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1194, 728);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Controls.Add(lblProntos);
            Controls.Add(lblEntregue);
            Controls.Add(btnEntregue);
            Controls.Add(listBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Balcao";
            Text = "Balcão";
            Load += Balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox2;
        private PictureBox pictureBox1;
        private Button btnEntregue;
        private Label lblEntregue;
        private Label lblProntos;
        private PictureBox pictureBox2;
        private ListBox listBox1;
    }
}