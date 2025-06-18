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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            label2.Location = new Point(692, 83);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 33;
            label2.Text = "Histórico";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Inter", 12F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 23;
            listBox2.Location = new Point(611, 145);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(276, 326);
            listBox2.TabIndex = 32;
            // 
            // listBox1
            // 
            listBox1.Enabled = false;
            listBox1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(81, 145);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(276, 326);
            listBox1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            label1.Location = new Point(152, 83);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 30;
            label1.Text = "Chamada";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.raio__1_;
            pictureBox3.Location = new Point(38, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, -96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(1045, 546);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
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
    }
}