
namespace Jogo_da_Forca
{
    partial class TelaCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPalavraSecreta = new System.Windows.Forms.TextBox();
            this.tbDica = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblErro = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra Secreta: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dica: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbPalavraSecreta
            // 
            this.tbPalavraSecreta.Location = new System.Drawing.Point(12, 61);
            this.tbPalavraSecreta.Name = "tbPalavraSecreta";
            this.tbPalavraSecreta.Size = new System.Drawing.Size(290, 23);
            this.tbPalavraSecreta.TabIndex = 2;
            this.tbPalavraSecreta.TextChanged += new System.EventHandler(this.tbPalavraSecreta_TextChanged);
            this.tbPalavraSecreta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPalavraSecreta_KeyPress);
            // 
            // tbDica
            // 
            this.tbDica.Location = new System.Drawing.Point(12, 127);
            this.tbDica.Name = "tbDica";
            this.tbDica.Size = new System.Drawing.Size(290, 23);
            this.tbDica.TabIndex = 3;
            this.tbDica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDica_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(195, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SalvarAction);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apenas letras são permitidas";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(12, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblErro);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 157);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 71);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(3, 0);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(38, 15);
            this.lblErro.TabIndex = 0;
            this.lblErro.Text = "label4";
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 299);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDica);
            this.Controls.Add(this.tbPalavraSecreta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastro";
            this.Text = "Cadastro de Palavra Secreta";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPalavraSecreta;
        private System.Windows.Forms.TextBox tbDica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblErro;
    }
}