using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jogo_da_Forca.Entities;

namespace Jogo_da_Forca
{
    public partial class TelaDerrota : Form
    {

        Rodada Rodada;
        public TelaDerrota(Rodada rodada)
        {
            InitializeComponent();
            Rodada = rodada;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            Rodada.Reiniciar();
            this.Close();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Rodada.Proxima();
            this.Close();
        }
    }
}
