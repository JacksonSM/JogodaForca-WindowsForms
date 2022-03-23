using System;
using System.Collections.Generic;
using System.Text;
using Jogo_da_Forca.Entities;
using System.Windows.Forms;
using Jogo_da_Forca.Properties;
using System.Drawing;
using Jogo_da_Forca.Model;
using Jogo_da_Forca.Dados;


namespace Jogo_da_Forca.Entities
{

    public class Rodada
    {

        Bitmap[] ImagensForca = new Bitmap[8];
        private int SequenciaImagem = 0;
        private PalavraSecreta varPalavraSecreta;
        public bool Resultado { get; private set; }

        FlowLayoutPanel flpTeclado;
        FlowLayoutPanel palavra;
        PictureBox PictureBox;
        Label lblDica;


        public Rodada(FlowLayoutPanel flpTeclado, FlowLayoutPanel palavra, PictureBox pictureBox, Label lblDica)
        {
            this.flpTeclado = flpTeclado;
            this.palavra = palavra;
            PictureBox = pictureBox;
            this.lblDica = lblDica;

            varPalavraSecreta = new PalavraSecreta(" ", " ", palavra, lblDica);
      
            CarregarImagens();
            Proxima();
        }

        void CarregarImagens()
        {
            ImagensForca[0] = new Bitmap(Properties.Resources.forca0);
            ImagensForca[1] = new Bitmap(Properties.Resources.forca1);
            ImagensForca[2] = new Bitmap(Properties.Resources.forca2);
            ImagensForca[3] = new Bitmap(Properties.Resources.forca3);
            ImagensForca[4] = new Bitmap(Properties.Resources.forca4);
            ImagensForca[5] = new Bitmap(Properties.Resources.forca5);
            ImagensForca[6] = new Bitmap(Properties.Resources.forca6);
            ImagensForca[7] = new Bitmap(Properties.Resources.forca7);


        }

        public Boolean Palpite(char letra)
        {
            bool i = false;
            //Verificação de acentos
            i = VerificarAcento(letra);
            if (i == false)
            {
                SequenciaImagem++;
                PictureBox.BackgroundImage = ImagensForca[SequenciaImagem];
                // condicao para derrota
                if (SequenciaImagem.Equals(7))
                {

                    new TelaDerrota(this).ShowDialog();

                }
                return i;
            }

            CondicaoVitoria();
            if (Resultado)
            {
                new TelaVitoria(this).ShowDialog();
                Resultado = false;
            }
            return i;
        }
        private void CondicaoVitoria()
        {

            foreach (Label obj in varPalavraSecreta.Flow.Controls)
            {
                if (obj.Text == "_")
                {
                    return;
                }

            }
            Resultado = true;
        }
        public void AdicionarPalavra(string palavraSecreta, string dica)
        {
            SequenciaImagem = 0;
            PictureBox.BackgroundImage = ImagensForca[SequenciaImagem];
            varPalavraSecreta.MudarPalavra(palavraSecreta, dica);
            foreach (Button button in flpTeclado.Controls)
            {
                if (button.Visible == false)
                {
                    button.Visible = true;
                }
            }
        }
        public void Reiniciar()
        {
            foreach (Button button in flpTeclado.Controls)
            {
                if (button.Visible == false)
                {
                    button.Visible = true;
                }
            }
            SequenciaImagem = 0;
            PictureBox.BackgroundImage = ImagensForca[SequenciaImagem];
            varPalavraSecreta.MudarPalavra(varPalavraSecreta._PalavraSecreta, varPalavraSecreta.Dica);
        }
        public void Proxima()
        {
            PalavraSecretaBanco palavra = SelecionarAleatoriamentePalavra();
            AdicionarPalavra(palavra.PalavraSecreta, palavra.Dica);

        }
        private bool VerificarAcento(char letra)
        {
            var i = false;
            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                char[] arry = Acentos.VerificarAcentos(letra);
                for (int x = 0; x <= (arry.Length - 1); x++)
                {
                    var u = varPalavraSecreta.LetraDigitada(arry[x]);
                    if (u) i = true;
                }

            }
            else
            {
                i = varPalavraSecreta.LetraDigitada(letra);
            }
            return i;
        }
        private PalavraSecretaBanco SelecionarAleatoriamentePalavra()
        {
            List<PalavraSecretaBanco> listPalavras = PalavraSecretaDataAccess.ColetarPalavasSecretas();
            Random randNum = new Random();
            int n = randNum.Next(0,listPalavras.Count);
            return listPalavras[n];
            
        }
    }
}
