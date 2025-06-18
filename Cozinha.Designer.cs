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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Inter Medium", 10F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(39, 140);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(716, 274);
            listBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.raio__1_;
            pictureBox2.Location = new Point(39, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // lblCozinha
            // 
            lblCozinha.AutoSize = true;
            lblCozinha.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblCozinha.Location = new Point(39, 73);
            lblCozinha.Name = "lblCozinha";
            lblCozinha.Size = new Size(254, 31);
            lblCozinha.TabIndex = 17;
            lblCozinha.Text = "Pedidos para Cozinha:";
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(202, 196, 183);
            btnFinalizar.Font = new Font("Inter ExtraBold", 14F, FontStyle.Bold);
            btnFinalizar.Location = new Point(830, 140);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(149, 61);
            btnFinalizar.TabIndex = 18;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, -96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1045, 546);
            Controls.Add(btnFinalizar);
            Controls.Add(lblCozinha);
            Controls.Add(pictureBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
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
    }
}