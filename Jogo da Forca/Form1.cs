using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jogo_da_Forca.Entities;
using Jogo_da_Forca.Dados;

namespace Jogo_da_Forca
{
    public partial class Form1 : Form
    {
        Rodada rodada;
        public Form1()
        {
            
            InitializeComponent();
           
            
            rodada = new Rodada(flpTeclado,flowLayoutPanel, pbForca,lblDica);

            

            rodada.Reiniciar();

        }

        private void ControlsMouseDown(object sender, MouseEventArgs e)
        { 
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
   


        private void Teclado(object sender, EventArgs e)
        {
            string l = (sender as Button).Text;
            (sender as Button).Visible = false;
            rodada.Palpite(char.Parse(l));

        }
        private void btnCadastrarPalavra_Click(object sender, EventArgs e)
        {
            new TelaCadastro().Show();
        }
    }
}
