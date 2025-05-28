namespace Cantina_2._0
{
    partial class Balcão
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcão));
            listbox2 = new ListBox();
            listbox1 = new ListBox();
            pictureBox1 = new PictureBox();
            btnEntregue = new Button();
            lblEntregue = new Label();
            lblProntos = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listbox2
            // 
            listbox2.Enabled = false;
            listbox2.Font = new Font("Inter", 8.25F);
            listbox2.FormattingEnabled = true;
            listbox2.Location = new Point(38, 344);
            listbox2.Name = "listbox2";
            listbox2.Size = new Size(634, 164);
            listbox2.TabIndex = 0;
            // 
            // listbox1
            // 
            listbox1.Font = new Font("Inter", 8.25F);
            listbox1.FormattingEnabled = true;
            listbox1.Location = new Point(38, 108);
            listbox1.Name = "listbox1";
            listbox1.Size = new Size(634, 164);
            listbox1.TabIndex = 1;
            listbox1.SelectedIndexChanged += lbxProntos_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, -69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnEntregue
            // 
            btnEntregue.BackColor = Color.FromArgb(202, 196, 183);
            btnEntregue.Font = new Font("Inter ExtraBold", 9F, FontStyle.Bold);
            btnEntregue.Location = new Point(734, 108);
            btnEntregue.Name = "btnEntregue";
            btnEntregue.Size = new Size(145, 54);
            btnEntregue.TabIndex = 12;
            btnEntregue.Text = "Entregue";
            btnEntregue.UseVisualStyleBackColor = false;
            btnEntregue.Click += btnEntregue_Click;
            // 
            // lblEntregue
            // 
            lblEntregue.AutoSize = true;
            lblEntregue.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntregue.Location = new Point(38, 305);
            lblEntregue.Name = "lblEntregue";
            lblEntregue.Size = new Size(154, 23);
            lblEntregue.TabIndex = 13;
            lblEntregue.Text = "Pedidos Retirados:";
            // 
            // lblProntos
            // 
            lblProntos.AutoSize = true;
            lblProntos.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            lblProntos.Location = new Point(38, 69);
            lblProntos.Name = "lblProntos";
            lblProntos.Size = new Size(168, 23);
            lblProntos.TabIndex = 14;
            lblProntos.Text = "Pedidos Finalizados:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio__1_;
            pictureBox2.Location = new Point(38, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // Balcão
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(915, 541);
            Controls.Add(pictureBox2);
            Controls.Add(lblProntos);
            Controls.Add(lblEntregue);
            Controls.Add(btnEntregue);
            Controls.Add(listbox1);
            Controls.Add(listbox2);
            Controls.Add(pictureBox1);
            Name = "Balcão";
            Text = "Balcão";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox2;
        private ListBox listbox1;
        private PictureBox pictureBox1;
        private Button btnEntregue;
        private Label lblEntregue;
        private Label lblProntos;
        private PictureBox pictureBox2;
    }
}