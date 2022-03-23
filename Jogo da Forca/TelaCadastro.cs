using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jogo_da_Forca.Model;
using Jogo_da_Forca.Dados;
using System.ComponentModel.DataAnnotations;

namespace Jogo_da_Forca
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SalvarAction(object sender, EventArgs e)
        {
            //Mover os dados para a classe PalavraSecretaBanco
            PalavraSecretaBanco palavraSecretaBanco = new PalavraSecretaBanco();
            palavraSecretaBanco.PalavraSecreta = tbPalavraSecreta.Text.ToUpper();
            palavraSecretaBanco.Dica = tbDica.Text;

            //validar dados
            List<ValidationResult> listErros = new List<ValidationResult>();
            ValidationContext contexto = new ValidationContext(palavraSecretaBanco);
            bool validado = Validator.TryValidateObject(palavraSecretaBanco, contexto,listErros, true);
            if (validado)
            {
                //Validacao OK.
                if (PalavraSecretaDataAccess.SalvarPalavraSecreta(palavraSecretaBanco))
                {
                    this.Close();
                }
                else
                {
                    lblErro.Text += "Erro no salvamento no Banco!";
                }
            }
            else
            {
                //Erro na validacao 
                StringBuilder sb = new StringBuilder();
                foreach(ValidationResult erro in listErros)
                {
                    sb.Append(erro.ErrorMessage + "\n");
                }
                lblErro.Text = sb.ToString();
            }
        }


        private void tbPalavraSecreta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbDica_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)|| (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void lblErro_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPalavraSecreta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
