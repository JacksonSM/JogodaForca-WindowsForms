
namespace Jogo_da_Forca
{
    partial class TelaDerrota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDerrota));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 459);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProximo.Location = new System.Drawing.Point(359, 395);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(86, 35);
            this.btnProximo.TabIndex = 8;
            this.btnProximo.Text = "Proxima";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // Reiniciar
            // 
            this.Reiniciar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reiniciar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reiniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reiniciar.Location = new System.Drawing.Point(211, 395);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(86, 35);
            this.Reiniciar.TabIndex = 7;
            this.Reiniciar.Text = "Reiniciar";
            this.Reiniciar.UseVisualStyleBackColor = false;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(69, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 449);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(517, 10);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 10);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 439);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(507, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 439);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(420, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // TelaDerrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 459);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaDerrota";
            this.Text = "TelaDerrota";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}